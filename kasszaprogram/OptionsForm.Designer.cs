namespace kasszaprogram
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TX_NewProductNameText = new System.Windows.Forms.TextBox();
            this.TX_NewProductAmountText = new System.Windows.Forms.TextBox();
            this.TX_NewProductPriceText = new System.Windows.Forms.TextBox();
            this.BT_AddNewProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LL_StartAmount = new System.Windows.Forms.Label();
            this.LL_PriceText = new System.Windows.Forms.Label();
            this.LLsub_ProductName = new System.Windows.Forms.Label();
            this.TXsub_NewPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTsub_SetNewPrice = new System.Windows.Forms.Button();
            this.FLP_ProductsOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPsubDemo = new System.Windows.Forms.FlowLayoutPanel();
            this.CXsub_Hide = new System.Windows.Forms.CheckBox();
            this.TX_apport = new System.Windows.Forms.TextBox();
            this.BT_apport = new System.Windows.Forms.Button();
            this.FLPsubDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TX_NewProductNameText
            // 
            this.TX_NewProductNameText.Location = new System.Drawing.Point(12, 31);
            this.TX_NewProductNameText.Name = "TX_NewProductNameText";
            this.TX_NewProductNameText.Size = new System.Drawing.Size(144, 20);
            this.TX_NewProductNameText.TabIndex = 0;
            // 
            // TX_NewProductAmountText
            // 
            this.TX_NewProductAmountText.Location = new System.Drawing.Point(161, 31);
            this.TX_NewProductAmountText.Name = "TX_NewProductAmountText";
            this.TX_NewProductAmountText.Size = new System.Drawing.Size(87, 20);
            this.TX_NewProductAmountText.TabIndex = 0;
            // 
            // TX_NewProductPriceText
            // 
            this.TX_NewProductPriceText.Location = new System.Drawing.Point(254, 31);
            this.TX_NewProductPriceText.Name = "TX_NewProductPriceText";
            this.TX_NewProductPriceText.Size = new System.Drawing.Size(58, 20);
            this.TX_NewProductPriceText.TabIndex = 0;
            // 
            // BT_AddNewProduct
            // 
            this.BT_AddNewProduct.Location = new System.Drawing.Point(318, 14);
            this.BT_AddNewProduct.Name = "BT_AddNewProduct";
            this.BT_AddNewProduct.Size = new System.Drawing.Size(75, 37);
            this.BT_AddNewProduct.TabIndex = 1;
            this.BT_AddNewProduct.Text = "Hozzáadás";
            this.BT_AddNewProduct.UseVisualStyleBackColor = true;
            this.BT_AddNewProduct.Click += new System.EventHandler(this.BT_AddNewProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név";
            // 
            // LL_StartAmount
            // 
            this.LL_StartAmount.AutoSize = true;
            this.LL_StartAmount.Location = new System.Drawing.Point(158, 14);
            this.LL_StartAmount.Name = "LL_StartAmount";
            this.LL_StartAmount.Size = new System.Drawing.Size(90, 13);
            this.LL_StartAmount.TabIndex = 3;
            this.LL_StartAmount.Text = "Kezdő mennyiség";
            // 
            // LL_PriceText
            // 
            this.LL_PriceText.AutoSize = true;
            this.LL_PriceText.Location = new System.Drawing.Point(274, 14);
            this.LL_PriceText.Name = "LL_PriceText";
            this.LL_PriceText.Size = new System.Drawing.Size(16, 13);
            this.LL_PriceText.TabIndex = 3;
            this.LL_PriceText.Text = "ár";
            // 
            // LLsub_ProductName
            // 
            this.LLsub_ProductName.AutoSize = true;
            this.LLsub_ProductName.Location = new System.Drawing.Point(6, 6);
            this.LLsub_ProductName.Margin = new System.Windows.Forms.Padding(6);
            this.LLsub_ProductName.Name = "LLsub_ProductName";
            this.LLsub_ProductName.Size = new System.Drawing.Size(69, 13);
            this.LLsub_ProductName.TabIndex = 4;
            this.LLsub_ProductName.Text = "valamitermék";
            // 
            // TXsub_NewPrice
            // 
            this.TXsub_NewPrice.Location = new System.Drawing.Point(129, 3);
            this.TXsub_NewPrice.Name = "TXsub_NewPrice";
            this.TXsub_NewPrice.Size = new System.Drawing.Size(46, 20);
            this.TXsub_NewPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Név,                 elrejtés,         új ár, új ár rögzítése";
            // 
            // BTsub_SetNewPrice
            // 
            this.BTsub_SetNewPrice.Location = new System.Drawing.Point(181, 3);
            this.BTsub_SetNewPrice.Name = "BTsub_SetNewPrice";
            this.BTsub_SetNewPrice.Size = new System.Drawing.Size(90, 20);
            this.BTsub_SetNewPrice.TabIndex = 5;
            this.BTsub_SetNewPrice.Text = "új ár beállítása";
            this.BTsub_SetNewPrice.UseVisualStyleBackColor = true;
            // 
            // FLP_ProductsOptions
            // 
            this.FLP_ProductsOptions.Location = new System.Drawing.Point(15, 129);
            this.FLP_ProductsOptions.Name = "FLP_ProductsOptions";
            this.FLP_ProductsOptions.Size = new System.Drawing.Size(611, 409);
            this.FLP_ProductsOptions.TabIndex = 7;
            // 
            // FLPsubDemo
            // 
            this.FLPsubDemo.Controls.Add(this.LLsub_ProductName);
            this.FLPsubDemo.Controls.Add(this.CXsub_Hide);
            this.FLPsubDemo.Controls.Add(this.TXsub_NewPrice);
            this.FLPsubDemo.Controls.Add(this.BTsub_SetNewPrice);
            this.FLPsubDemo.Controls.Add(this.TX_apport);
            this.FLPsubDemo.Controls.Add(this.BT_apport);
            this.FLPsubDemo.Location = new System.Drawing.Point(15, 568);
            this.FLPsubDemo.Name = "FLPsubDemo";
            this.FLPsubDemo.Size = new System.Drawing.Size(435, 25);
            this.FLPsubDemo.TabIndex = 8;
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
            // TX_apport
            // 
            this.TX_apport.Location = new System.Drawing.Point(277, 3);
            this.TX_apport.Name = "TX_apport";
            this.TX_apport.Size = new System.Drawing.Size(46, 20);
            this.TX_apport.TabIndex = 6;
            // 
            // BT_apport
            // 
            this.BT_apport.Location = new System.Drawing.Point(329, 3);
            this.BT_apport.Name = "BT_apport";
            this.BT_apport.Size = new System.Drawing.Size(90, 20);
            this.BT_apport.TabIndex = 5;
            this.BT_apport.Text = "új ár beállítása";
            this.BT_apport.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 710);
            this.Controls.Add(this.FLPsubDemo);
            this.Controls.Add(this.FLP_ProductsOptions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LL_PriceText);
            this.Controls.Add(this.LL_StartAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_AddNewProduct);
            this.Controls.Add(this.TX_NewProductPriceText);
            this.Controls.Add(this.TX_NewProductAmountText);
            this.Controls.Add(this.TX_NewProductNameText);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.FLPsubDemo.ResumeLayout(false);
            this.FLPsubDemo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TX_NewProductNameText;
        private System.Windows.Forms.TextBox TX_NewProductAmountText;
        private System.Windows.Forms.TextBox TX_NewProductPriceText;
        private System.Windows.Forms.Button BT_AddNewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LL_StartAmount;
        private System.Windows.Forms.Label LL_PriceText;
        private System.Windows.Forms.Label LLsub_ProductName;
        private System.Windows.Forms.TextBox TXsub_NewPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTsub_SetNewPrice;
        private System.Windows.Forms.FlowLayoutPanel FLP_ProductsOptions;
        private System.Windows.Forms.FlowLayoutPanel FLPsubDemo;
        private System.Windows.Forms.CheckBox CXsub_Hide;
        private System.Windows.Forms.TextBox TX_apport;
        private System.Windows.Forms.Button BT_apport;
    }
}