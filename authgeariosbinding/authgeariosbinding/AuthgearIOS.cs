using System;
using Foundation;
using authgear;

namespace authgeariosbinding
{
    public class AuthgearIOS: Authgear
    {

        private AuthgearSwift authgearSwift;

        public AuthgearIOS()
        {
            this.authgearSwift = new AuthgearSwift();
        }

        public void SayHello(Action<string> completion)
        {
            this.authgearSwift.Greet("Swift", delegate (NSString s) {
                completion(s.ToString());
	        });
        }
    }
}
