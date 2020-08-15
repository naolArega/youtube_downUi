using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace youtube_downUi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void expandCollapseBtn_Click(object sender, EventArgs e)
        {
            Size sz = new Size();
            Point lc = new Point();
            if(MaximumSize.Width == 870)
            {
                expandCollapseBtn.Text = ">";
                lc.X = 403;
                lc.Y = expandCollapseBtn.Location.Y;
                sz.Width = 435;
                sz.Height = 460;
                expandCollapseBtn.Location = lc;
                MaximumSize = sz;
            }
            else
            {
                expandCollapseBtn.Text = "<";
                lc.X = 838;
                lc.Y = expandCollapseBtn.Location.Y;
                sz.Width = 870;
                sz.Height = 460;
                expandCollapseBtn.Location = lc;
                MinimumSize = sz;
            }
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            Settings st = new Settings();
            st.ShowDialog();
        }

        private string argProcess()
        {
            string argu = "";
            if (!noPlaylist.Checked)
            {
                argu += " --playlist-start " + playlistStr.Value +
                    " --playlist-end " + playlistEnd.Value;
            }
            else
            {
                argu += " --no-playlist";
            }
            argu += " -f " + FormatCbx.Text;
            return argu;
        }

        private void play()
        {
            string output = "";
            string arg = argProcess();
            string com = "/bin/youtube-dl.exe " + arg + " " + urlTbx.Text;
            Process cmd = new Process();

            cmd.StartInfo.FileName = "cmd";
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(com);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            MessageBox.Show(output, "cmd return");
        }

        private void addToQueueBtn_Click(object sender, EventArgs e)
        {
            Thread ctr = Thread.CurrentThread;
            ThreadStart thstr = new ThreadStart(play);
            Thread tr = new Thread(thstr);
            tr.Start();
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            Point pt=new Point();
            debugLbl.Text = ">>location: X= " + Location.X + " Y= " + Location.Y;
            if(Location.X > 918 && Size.Width == 435)
            {
                pt.X = 938;
                pt.Y = Location.Y;
                Location = pt;
            }
            if(Location.X > 483 && Size.Width == 870)
            {
                pt.X = 503;
                pt.Y = Location.Y;
                Location = pt;
            }
            if (Location.X < 20)
            {
                pt.X = 0;
                pt.Y = Location.Y;
                Location = pt;
            }
            if (Location.Y > 265)
            {
                pt.Y = 285;
                pt.X = Location.X;
                Location = pt;
            }
            if (Location.Y < 20)
            {
                pt.Y = 0;
                pt.X = Location.X;
                Location = pt;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
