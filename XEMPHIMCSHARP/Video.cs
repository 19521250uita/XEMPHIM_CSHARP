using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XEMPHIMCSHARP
{
   

    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

       
        public void Video_Load(object sender, EventArgs e)
        {
            video1.URL = Home.SharedVar.url;
            this.Text = Home.SharedVar.name;
        }
        public void stop()
        {
            video1.Ctlcontrols.stop();
        }

        private void Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop();
        }
    }
}
