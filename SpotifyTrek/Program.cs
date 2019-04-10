using System;
using System.Windows.Forms;
using SpotifyTrek.Service;

namespace SpotifyTrek
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SpotifyAPIHandler aH = new SpotifyAPIHandler();
            SoundHandler sH = new SoundHandler();
            var serv = new Service.Service(aH,sH);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(serv));
            serv.StopPlaying();
        }
    }
}
