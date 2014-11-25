using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace rm_ibivk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // dockPanel1 already added to this form 
            dockPanel1.Dock = DockStyle.Fill;
            dockPanel1.BringToFront();

            Form2 frm2 = new Form2(); // These forms inherit from DockContent 
            frm2.ShowHint = DockState.Document;
            frm2.Show(dockPanel1);

            Form3 frm3 = new Form3();
            frm3.ShowHint = DockState.Document;
            frm3.Show(dockPanel1);

            Form4 frm4 = new Form4();
            frm4.ShowHint = DockState.Document;
            frm4.Show(dockPanel1);
           // frm4.DockHandler.FloatPane.DockTo(dockPanel1.DockWindows[DockState.DockRight]);
        }
    }
}
