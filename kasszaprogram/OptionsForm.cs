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
    public sealed partial class OptionsForm : Form
    {
        private static volatile OptionsForm optionsFormSingleton;

        private static object _syncRoot = new object();

        public static OptionsForm GetSingletonInstance()
        {
            if(optionsFormSingleton == null)
            {
                lock (_syncRoot)
                {
                    if (optionsFormSingleton == null)
                    {
                        optionsFormSingleton = new OptionsForm();
                    }
                }
            }
            return optionsFormSingleton;
        }

        private OptionsForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            
            e.Cancel = true;
            this.Hide();
            
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
            

            this.FLP_ProductsOptions.SuspendLayout();
            this.FLP_ProductsOptions.Controls.Add(optionsFormSubFLP);
            // this.FLP_ProductsOptions.Controls.Add(new Button());
            this.FLP_ProductsOptions.ResumeLayout(false);
            this.FLP_ProductsOptions.PerformLayout();
            // this.Refresh();
            // 
            // private System.Windows.Forms.Button PROBA = new Button();
            // 
            // this.FLP_ProductsOptions.Controls.Add(new Button());
        }
    }
}
