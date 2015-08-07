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
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private int howManyMemberFLPs = 0;

        private void OptionsForm_Load(object sender, EventArgs e)
        {

        }

        private void CXsub_Hide_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Elrejtve");
        }

        private void AddNewProductFLP()
        {

        }

        private void BT_AddNewProduct_Click(object sender, EventArgs e)
        {
            string newProductName = this.TX_NewProductNameText.Text;
            int newProductPrice = Convert.ToInt32(this.TX_NewProductPriceText.Text);
            int newProductAmount = Convert.ToInt32(this.TX_NewProductAmountText.Text);

            OptionsFormSubFLP optionsFormSubFLP = new OptionsFormSubFLP(newProductName, newProductPrice, newProductAmount);
            howManyMemberFLPs++;
            optionsFormSubFLP.Name = howManyMemberFLPs.ToString();
            this.FLP_ProductsOptions.Controls.Add(optionsFormSubFLP);
        }
    }
}
