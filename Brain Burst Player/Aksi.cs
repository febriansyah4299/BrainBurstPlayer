using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Brain_Burst_Player
{
    class Aksi
    {
        [DllImport("winmm.dll", CharSet=CharSet.Unicode)]
        private static extern int mciSendString(string strCommand,
        StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        private string status = "";

        public void BukaDikitJos(String file)
        {
            String isi = "open \"" + file + "\" type mpegvideo alias MP3";
            mciSendString(isi, null, 0, IntPtr.Zero);
        }

        public void TarikMang(String file)
        {
            if (status.Equals("stop"))
            {
                BukaDikitJos(file);

                String command = "play MP3";
                mciSendString(command, null, 0, IntPtr.Zero);
            }
            else
            {
                String command = "play MP3";
                mciSendString(command, null, 0, IntPtr.Zero);
            }
        }

        public void TahanSebentar()
        {
            String command = "pause MP3";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        public void SampunRampung()
        {
            String command = "stop MP3";
            mciSendString(command, null, 0, IntPtr.Zero);

            Halah();

            status = "stop";
        }

        public void Halah()
        {
            String command = "close MP3";
            mciSendString(command, null, 0, IntPtr.Zero);
        }

        }
}
