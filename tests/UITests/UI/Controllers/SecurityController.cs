namespace UITests.UI.Controllers
{
    public class SecurityController
    {
        public static bool IsLoggedIn 
        {
            get
            {
                try
                {
                    return false;
                }
                catch (System.Exception)
                {
                    return true;
                }
            }
        }

        public static void Login(string username, string password)
        {

        }
    }
}