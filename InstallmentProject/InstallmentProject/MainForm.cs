using MyTabControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstallmentProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            TabPanelControl tpc = new TabPanelControl();
            Form1 frm = new Form1(tabControlX1);
            tpc.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            //frm.FormBorderStyle = FormBorderStyle.None;
            tpc.Controls.Clear();
            tpc.Controls.Add(frm);

            tabControlX1.AddTab(frm.Text, tpc);
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            TabPanelControl tpc = new TabPanelControl();
            Form2 frm = new Form2(tabControlX1);
            tpc.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            //frm.FormBorderStyle = FormBorderStyle.None;
            tpc.Controls.Clear();
            tpc.Controls.Add(frm);

            tabControlX1.AddTab(frm.Text, tpc);
        }
    }
}
