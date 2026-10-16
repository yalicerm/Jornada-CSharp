using UVVkedin_forms.Control;

namespace UVVkedin_forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            ApplicationConfiguration.Initialize();
            Application.Run(new RedeAmigos());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AmigoRepository repository = new AmigoRepository();

        
            RedeAmigos view = new RedeAmigos();

            AmigoController controller = new AmigoController(view, repository);

            Application.Run(view);

        }
    }
}