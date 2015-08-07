using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasszaprogram
{
    class OptionsFormSubFLP : FlowLayoutPanel
    {
        private string productName;
        private int price;
        private int amount;

        private System.Windows.Forms.Button BTsub_SetNewPrice;
        private System.Windows.Forms.TextBox TXsub_NewPrice;
        private System.Windows.Forms.Label LLsub_ProductName;
        private System.Windows.Forms.CheckBox CXsub_Hide;
        private System.Windows.Forms.TextBox TXsub_NewAmount;
        private System.Windows.Forms.Button BTsub_SetNewAmount;

        public OptionsFormSubFLP(string newProductName, int startPrice, int newAmount)
        {
            this.productName = newProductName;            
            this.price = startPrice;
            this.amount = newAmount;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.BTsub_SetNewPrice = new System.Windows.Forms.Button();
            this.TXsub_NewPrice = new System.Windows.Forms.TextBox();
            this.LLsub_ProductName = new System.Windows.Forms.Label();
            this.CXsub_Hide = new System.Windows.Forms.CheckBox();            
            this.TXsub_NewAmount    = new System.Windows.Forms.TextBox();
            this.BTsub_SetNewAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // LLsub_ProductName
            // 
            this.LLsub_ProductName.AutoSize = true;
            this.LLsub_ProductName.Location = new System.Drawing.Point(6, 6);
            this.LLsub_ProductName.Margin = new System.Windows.Forms.Padding(6);
            this.LLsub_ProductName.Name = "LLsub_ProductName";
            this.LLsub_ProductName.Size = new System.Drawing.Size(69, 13);
            this.LLsub_ProductName.TabIndex = 4;
            this.LLsub_ProductName.Text = this.productName;
            // 
            // TXsub_NewPrice
            // 
            this.TXsub_NewPrice.Location = new System.Drawing.Point(129, 3);
            this.TXsub_NewPrice.Name = "TXsub_NewPrice";
            this.TXsub_NewPrice.Size = new System.Drawing.Size(46, 20);
            this.TXsub_NewPrice.Text = price.ToString();
            this.TXsub_NewPrice.TabIndex = 6;
            // 
            // BTsub_SetNewPrice
            // 
            this.BTsub_SetNewPrice.Location = new System.Drawing.Point(181, 3);
            this.BTsub_SetNewPrice.Name = "BTsub_SetNewPrice";
            this.BTsub_SetNewPrice.Size = new System.Drawing.Size(90, 20);
            this.BTsub_SetNewPrice.TabIndex = 5;
            this.BTsub_SetNewPrice.Text = "új ár beállítása";
            this.BTsub_SetNewPrice.UseVisualStyleBackColor = true;
            this.BTsub_SetNewPrice.Click += new System.EventHandler(this.BTsub_SetNewPrice_Click);
            // 
            // CXsub_Hide
            // 
            this.CXsub_Hide.Appearance = System.Windows.Forms.Appearance.Button;
            this.CXsub_Hide.AutoSize = true;
            this.CXsub_Hide.Location = new System.Drawing.Point(84, 3);
            this.CXsub_Hide.Name = "CXsub_Hide";
            this.CXsub_Hide.Size = new System.Drawing.Size(39, 23);
            this.CXsub_Hide.TabIndex = 9;
            this.CXsub_Hide.Text = "elrejt";
            this.CXsub_Hide.UseVisualStyleBackColor = true;
            this.CXsub_Hide.Click += new System.EventHandler(this.CXsub_Hide_Click);
            // 
            // TXsub_NewAmount
            // 
            this.TXsub_NewAmount.Location = new System.Drawing.Point(129, 3);
            this.TXsub_NewAmount.Name = "TXsub_NewPrice";
            this.TXsub_NewAmount.Size = new System.Drawing.Size(46, 20);
            this.TXsub_NewAmount.Text = price.ToString();
            this.TXsub_NewAmount.TabIndex = 6;
            // 
            // BTsub_SetNewAmount
            // 
            this.BTsub_SetNewAmount.Location = new System.Drawing.Point(181, 3);
            this.BTsub_SetNewAmount.Name = "BTsub_SetNewPrice";
            this.BTsub_SetNewAmount.Size = new System.Drawing.Size(90, 20);
            this.BTsub_SetNewAmount.TabIndex = 5;
            this.BTsub_SetNewAmount.Text = "új ár beállítása";
            this.BTsub_SetNewAmount.UseVisualStyleBackColor = true;
            this.BTsub_SetNewAmount.Click += new System.EventHandler(this.BTsub_SetNewPrice_Click);
            // 
            // OptionsForm
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 710);
            this.Controls.Add(this.BTsub_SetNewPrice);
            this.Controls.Add(this.CXsub_Hide);
            this.Controls.Add(this.TXsub_NewPrice);
            this.Controls.Add(this.LLsub_ProductName);
            this.Controls.Add(this.TXsub_NewAmount);
            this.Controls.Add(this.BTsub_SetNewAmount);

            // this.Name = "OptionsForm";
            // this.Text = "OptionsForm";
            // this.Load += new System.EventHandler(this.OptionsForm_Load);            
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }


        private void BTsub_SetNewPrice_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("");
        }
        private void CXsub_Hide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elrejtve");
        }
    }
}
