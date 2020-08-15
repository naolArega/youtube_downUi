using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_downUi
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void settingTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach (Control cntr in this.Controls.OfType<Panel>())
            {
                if(cntr.Tag != e.Node.Tag)
                {
                    cntr.Visible = false;
                }
                else
                {
                    cntr.Visible = true;
                }
            }
        }
    }
}
