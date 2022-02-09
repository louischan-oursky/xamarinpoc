

namespace authgear
{
    public interface Authgear
    {
        void SayHello(System.Action<string> completion);
    }

    public class UseXamarinEssentials
    {
        public void PrintBuildString()
        {
            System.Console.WriteLine("BuildString: " + Xamarin.Essentials.AppInfo.BuildString);
        }
    }
}
