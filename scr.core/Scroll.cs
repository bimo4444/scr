using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scr.core
{
    public class Scroll
    {
        private const byte VK_SCROLL = 0x91;
        private const uint KEYEVENTF_KEYUP = 0x2;

        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        [DllImport("user32.dll", EntryPoint = "GetKeyState", SetLastError = true)]
        static extern short GetKeyState(uint nVirtKey);

        public Scroll()
        {
            while(true)
            {
                keybd_event(VK_SCROLL, 0, 0, 0);
                keybd_event(VK_SCROLL, 0, KEYEVENTF_KEYUP, 0);
                if (GetKeyState(VK_SCROLL) != 0) break;
            }
        }
    }
}
