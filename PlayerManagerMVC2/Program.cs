using PlayerManagerMVC2.Controller;
using PlayerManagerMVC2.View;

namespace PlayerManagerMVC2
{

    public class Program
    {
        private static void Main(string[] args)
        {
            string file = args[0];
            // Create the view
            PlayerView view = new PlayerView();
            // Create the controller
            PlayerController controller = new PlayerController(view, file);
            // Start the controller
            controller.Start();
        }
    }
}