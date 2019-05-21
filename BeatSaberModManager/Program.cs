﻿using System;
using System.Windows.Forms;
using System.Reflection;
using BeatSaberModManager.Forms;

namespace BeatSaberModManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool close = false;
            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i])
                {
                    case "--install":
                        Core.OneClickInstaller.InstallFile(args[i + 1]);
                        close = true;
                        break;

                    default:
                        break;
                }
            }

            if (close)
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Open the announcement window
            Application.Run(new FormAnnouncement());
            Application.Run(new FormMain());
        }
    }
}
