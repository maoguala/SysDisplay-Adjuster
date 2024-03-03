using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysDisplayer_Adjuster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //800*600
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_800x600",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //Exit to Application
            this.Close();//Exit this App
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //1920*1080
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1920x1080",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1024x768
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1024x768",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1152x864
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1152x864",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //1280x600
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1280x600",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //1280x720
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1280x720",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //1280x768
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1280x768",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //1280x800
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1280x800",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //1280x1024
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1280x1024",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //1360x768
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1360x768",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //1366x768
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1366x768",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //4K
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_3840x2160",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //1400x1050
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1400x1050",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //1440x900
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1440x900",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //1600x900
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1600x900",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //1680x1050
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1680x1050",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //1920x1440
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_1920x1440",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //2048x1536
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_2048x1536",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //2056x1440
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_2056x1440",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //2560x1600
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"res.bat",
                WorkingDirectory = @".\RES\res_2560x1600",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //30fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_30",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //50fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_50",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //59.94fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_59.94",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //60fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_60",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //75fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_75",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //90fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_90",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //120fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_120",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //144fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_144",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //160fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_160",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //165fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_165",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //240fps
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_240",
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //200hz
            string Data0 = "\"" + @"Data0" + "\"";
            string Data1 = "\"" + @"Data1" + "\"";

            ProcessStartInfo Info = new ProcessStartInfo()
            {
                FileName = @"hz.bat",
                WorkingDirectory = @".\hz\h_200",//Not Working?
                Arguments = String.Format(Data0, Data1),
            };
            Process.Start(Info);
        }
    }
}
