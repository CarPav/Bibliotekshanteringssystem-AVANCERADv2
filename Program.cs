namespace Bibliotekshanteringssystem_AVANCERAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface();
            userInterface.PrintStartMenu();

            Console.ReadKey();
        }
    }
}
