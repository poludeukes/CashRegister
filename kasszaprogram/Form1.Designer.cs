namespace kasszaprogram
{
    partial class Form1
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
            this.BT_Submit = new System.Windows.Forms.Button();
            this.BT_SetAllToZero = new System.Windows.Forms.Button();
            this.LL_BasketSum = new System.Windows.Forms.Label();
            this.LL_Currency = new System.Windows.Forms.Label();
            this.LL_SumText = new System.Windows.Forms.Label();
            this.CX_price = new System.Windows.Forms.CheckBox();
            this.CX_stock = new System.Windows.Forms.CheckBox();
            this.LL_ProductNameText = new System.Windows.Forms.Label();
            this.BT_Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Submit
            // 
            this.BT_Submit.Location = new System.Drawing.Point(604, 110);
            this.BT_Submit.Name = "BT_Submit";
            this.BT_Submit.Size = new System.Drawing.Size(143, 78);
            this.BT_Submit.TabIndex = 0;
            this.BT_Submit.Text = "Eladom";
            this.BT_Submit.UseVisualStyleBackColor = true;
            this.BT_Submit.Click += new System.EventHandler(this.BT_Submit_Click);
            // 
            // BT_SetAllToZero
            // 
            this.BT_SetAllToZero.Location = new System.Drawing.Point(685, 9);
            this.BT_SetAllToZero.Name = "BT_SetAllToZero";
            this.BT_SetAllToZero.Size = new System.Drawing.Size(79, 21);
            this.BT_SetAllToZero.TabIndex = 1;
            this.BT_SetAllToZero.Text = "Kosár törlése";
            this.BT_SetAllToZero.UseVisualStyleBackColor = true;
            // 
            // LL_BasketSum
            // 
            this.LL_BasketSum.AutoSize = true;
            this.LL_BasketSum.Location = new System.Drawing.Point(676, 79);
            this.LL_BasketSum.Name = "LL_BasketSum";
            this.LL_BasketSum.Size = new System.Drawing.Size(13, 13);
            this.LL_BasketSum.TabIndex = 2;
            this.LL_BasketSum.Text = "0";
            // 
            // LL_Currency
            // 
            this.LL_Currency.AutoSize = true;
            this.LL_Currency.Location = new System.Drawing.Point(718, 79);
            this.LL_Currency.Name = "LL_Currency";
            this.LL_Currency.Size = new System.Drawing.Size(29, 13);
            this.LL_Currency.TabIndex = 3;
            this.LL_Currency.Text = "HUF";
            // 
            // LL_SumText
            // 
            this.LL_SumText.AutoSize = true;
            this.LL_SumText.Location = new System.Drawing.Point(601, 79);
            this.LL_SumText.Name = "LL_SumText";
            this.LL_SumText.Size = new System.Drawing.Size(53, 13);
            this.LL_SumText.TabIndex = 4;
            this.LL_SumText.Text = "Összesen";
            // 
            // CX_price
            // 
            this.CX_price.AutoSize = true;
            this.CX_price.Location = new System.Drawing.Point(86, 13);
            this.CX_price.Name = "CX_price";
            this.CX_price.Size = new System.Drawing.Size(64, 17);
            this.CX_price.TabIndex = 6;
            this.CX_price.Text = "egyégár";
            this.CX_price.UseVisualStyleBackColor = true;
            // 
            // CX_stock
            // 
            this.CX_stock.AutoSize = true;
            this.CX_stock.Location = new System.Drawing.Point(156, 13);
            this.CX_stock.Name = "CX_stock";
            this.CX_stock.Size = new System.Drawing.Size(59, 17);
            this.CX_stock.TabIndex = 6;
            this.CX_stock.Text = "készlet";
            this.CX_stock.UseVisualStyleBackColor = true;
            // 
            // LL_ProductNameText
            // 
            this.LL_ProductNameText.AutoSize = true;
            this.LL_ProductNameText.Location = new System.Drawing.Point(13, 13);
            this.LL_ProductNameText.Name = "LL_ProductNameText";
            this.LL_ProductNameText.Size = new System.Drawing.Size(27, 13);
            this.LL_ProductNameText.TabIndex = 7;
            this.LL_ProductNameText.Text = "Név";
            // 
            // BT_Options
            // 
            this.BT_Options.Location = new System.Drawing.Point(685, 305);
            this.BT_Options.Name = "BT_Options";
            this.BT_Options.Size = new System.Drawing.Size(75, 23);
            this.BT_Options.TabIndex = 8;
            this.BT_Options.Text = "Beállítások";
            this.BT_Options.UseVisualStyleBackColor = true;
            this.BT_Options.Click += new System.EventHandler(this.BT_Options_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 340);
            this.Controls.Add(this.BT_Options);
            this.Controls.Add(this.LL_ProductNameText);
            this.Controls.Add(this.CX_stock);
            this.Controls.Add(this.CX_price);
            this.Controls.Add(this.LL_SumText);
            this.Controls.Add(this.LL_Currency);
            this.Controls.Add(this.LL_BasketSum);
            this.Controls.Add(this.BT_SetAllToZero);
            this.Controls.Add(this.BT_Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Submit;
        private System.Windows.Forms.Button BT_SetAllToZero;
        private System.Windows.Forms.Label LL_BasketSum;
        private System.Windows.Forms.Label LL_Currency;
        private System.Windows.Forms.Label LL_SumText;
        private System.Windows.Forms.CheckBox CX_price;
        private System.Windows.Forms.CheckBox CX_stock;
        private System.Windows.Forms.Label LL_ProductNameText;
        private System.Windows.Forms.Button BT_Options;
    }
}

