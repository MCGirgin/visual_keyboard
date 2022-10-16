using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_keyboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        static class KeyboardSend
        {
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

            private const int KEYEVENTF_EXTENDEDKEY = 1;
            private const int KEYEVENTF_KEYUP = 2;

            public static void KeyDown(Keys vKey)
            {
                keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
            }

            public static void KeyUp(Keys vKey)
            {
                keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        private void space_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void Alphabet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (caps_lock.Checked == true || shift_sol.Checked == true || shift_sağ.Checked == true)
            {
                SendKeys.Send((btn.Text).ToUpper());
                shift_sol.Checked = false;
                shift_sağ.Checked = false;
            }
            else
            {
                SendKeys.Send((btn.Text).ToLower());
            }
        }

        private void Alphabet_MouseDown(object sender, MouseEventArgs e)
        {
            Alphabet_delay.Enabled = true;
        }

        private void Ahphabet_MouseUp(object sender, MouseEventArgs e)
        {
            Alphabet_timer.Enabled = false;
            Alphabet_delay.Enabled = false;
        }

        private void Alphabet_timer_Tick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (caps_lock.Checked == true || shift_sol.Checked == true || shift_sağ.Checked == true)
            {
                SendKeys.Send((btn.Text).ToUpper());
                shift_sol.Checked = false;
                shift_sağ.Checked = false;
            }
            else
            {
                SendKeys.Send((btn.Text).ToLower());
            }
        }

        private void Alphabet_delay_Tick(object sender, EventArgs e)
        {
            Alphabet_timer.Enabled = true;
        }

        private void caps_lock_CheckedChanged(object sender, EventArgs e)
        {
            if (caps_lock.Checked == true)
            {
                caps_lock.BackColor = Color.FromArgb(185, 209, 234);
            }
            else
            {
                caps_lock.BackColor = Color.FromArgb(215, 228, 242);
            }
        }

        private void shift_sol_CheckedChanged(object sender, EventArgs e)
        {
            if (shift_sol.Checked == true)
            {
                shift_sol.BackColor = Color.FromArgb(185, 209, 234);
            }
            else
            {
                shift_sol.BackColor = Color.FromArgb(215, 228, 242);
            }
        }

        private void shift_sağ_CheckedChanged(object sender, EventArgs e)
        {
            if (shift_sağ.Checked == true)
            {
                shift_sağ.BackColor = Color.FromArgb(185, 209, 234);
            }
            else
            {
                shift_sağ.BackColor = Color.FromArgb(215, 228, 242);
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BS}");
        }


        private void delete_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void prt_sc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void yukarı_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void aşağı_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void sağ_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void sol_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void tab_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void numbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SendKeys.Send((btn.Text));
        }

        private void esc_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void windows_Click(object sender, EventArgs e)
        {
            KeyboardSend.KeyDown(Keys.LWin);
            KeyboardSend.KeyUp(Keys.LWin);
        }

        private void ctrl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void others(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SendKeys.Send((btn.Text));
        }

        private void f1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void f2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void f3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void f4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void f5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void f6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void f7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void f8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void f9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void f10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void f11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void f12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        

        private void sil_MouseDown(object sender, MouseEventArgs e)
        {
            sil_delay.Enabled = true;
        }

        private void sil_MouseUp(object sender, MouseEventArgs e)
        {
            sil_timer.Enabled = false;
            sil_delay.Enabled = false;
        }

        private void sil_timer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void sil_delay_Tick(object sender, EventArgs e)
        {
            sil_timer.Enabled = true;
        }

        private void Alphabet_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
