﻿using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TCPSender
{
    public static class VolumeHandling
    {


        public static void MainHandler()
        {
            VolumeMaster master = new VolumeMaster();
            bool done = false;
            foreach (AudioSession session in master.Sessions)
            {
                if (session.Process != null)
                {
                    Console.WriteLine("ProcessName: " + session.Process.ProcessName);
                    Console.WriteLine("AudioSession IconPath: " + session.IconPath);
                    Icon icon = session.GetIcon32x32();
                   

                }
                Console.WriteLine("DisplayName: " + session.DisplayName);
                Console.WriteLine("Volume: " + session.Volume);
                Console.WriteLine("Muted: " + session.Mute);
                Console.WriteLine("State: " + session.State.ToString());

                Console.WriteLine("AudioSession IconPath: " + session.IconPath);

                Console.WriteLine();

                //session.Volume = 100;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("begin coreaudio testing");
            Console.WriteLine(master.MasterVolumeLevel.ToString());
            master.MasterVolumeLevel = 35;
            Console.WriteLine(master.MasterVolumeLevel.ToString());


            Console.ReadLine();
        }


    }
}
