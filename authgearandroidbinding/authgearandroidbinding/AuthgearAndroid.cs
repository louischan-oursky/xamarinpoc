using System;
using authgear;
using Com.Iawaknahc.Xamarin.Kotlin;

namespace authgearandroidbinding
{
	public class AuthgearAndroid: Authgear
	{
        private AuthgearKotlin authgearKotlin;


		public AuthgearAndroid()
		{
            this.authgearKotlin = new AuthgearKotlin();
		}

        public void SayHello(Action<string> completion)
        {
            this.authgearKotlin.Greet("AndroidKotlin", new Completion(delegate (Java.Lang.Object result, Java.Lang.Throwable error)
            {
                Java.Lang.String jString = (Java.Lang.String) result;
                completion.Invoke(result.ToString());
            }));
        }
    }

    public class Completion: Java.Lang.Object, ICompletion
    {
        private Action<Java.Lang.Object, Java.Lang.Throwable> action;

        public Completion(Action<Java.Lang.Object, Java.Lang.Throwable> action)
        {
            this.action = action;
        }

        public void Invoke(Java.Lang.Object result, Java.Lang.Throwable error)
        {
            this.action.Invoke(result, error);
        }
    }
}

