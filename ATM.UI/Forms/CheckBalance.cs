using ATM.BLL.Implementations;


namespace ATM.UI.Forms
{
    public class CheckBalance: UserAuthService
    {
        public static void Checkbalance()
        {
            Console.WriteLine($"Your Balance is #{Balance}");
        }
    }
}
