using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasszaprogram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Submit_Click(object sender, EventArgs e)
        {
            CashStockRegister cr = new CashStockRegister();
            
            cr.AddNewProduct("erfergfer", 1, 10);

            

        }

        private void BT_Options_Click(object sender, EventArgs e)
        {
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new OptionsForm());

            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }
    }
}
