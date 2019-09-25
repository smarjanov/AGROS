using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROS
{
    public partial class AGROS_MAIN : Form
    {
        public AGROS_MAIN()
        {
            InitializeComponent();
            newClientsPanel.Visible = false;
        }

        private void UnosNovihKlijenataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            newClientsPanel.Visible = true;
        }

        private void NewClientsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
