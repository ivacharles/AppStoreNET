
namespace AppStoreNET
{
    partial class productList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productLlabelTItle = new System.Windows.Forms.Label();
            this.productLabelDesc = new System.Windows.Forms.Label();
            this.productLabelPrice = new System.Windows.Forms.Label();
            this.prodcutLabelCateg = new System.Windows.Forms.Label();
            this.productpictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productLlabelTItle
            // 
            this.productLlabelTItle.AutoSize = true;
            this.productLlabelTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLlabelTItle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.productLlabelTItle.Location = new System.Drawing.Point(322, 32);
            this.productLlabelTItle.Name = "productLlabelTItle";
            this.productLlabelTItle.Size = new System.Drawing.Size(124, 42);
            this.productLlabelTItle.TabIndex = 1;
            this.productLlabelTItle.Text = "label1";
            // 
            // productLabelDesc
            // 
            this.productLabelDesc.AutoSize = true;
            this.productLabelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabelDesc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.productLabelDesc.Location = new System.Drawing.Point(322, 87);
            this.productLabelDesc.Name = "productLabelDesc";
            this.productLabelDesc.Size = new System.Drawing.Size(100, 37);
            this.productLabelDesc.TabIndex = 2;
            this.productLabelDesc.Text = "label1";
            // 
            // productLabelPrice
            // 
            this.productLabelPrice.AutoSize = true;
            this.productLabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabelPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.productLabelPrice.Location = new System.Drawing.Point(322, 148);
            this.productLabelPrice.Name = "productLabelPrice";
            this.productLabelPrice.Size = new System.Drawing.Size(100, 37);
            this.productLabelPrice.TabIndex = 3;
            this.productLabelPrice.Text = "label1";
            // 
            // prodcutLabelCateg
            // 
            this.prodcutLabelCateg.AutoSize = true;
            this.prodcutLabelCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcutLabelCateg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prodcutLabelCateg.Location = new System.Drawing.Point(322, 203);
            this.prodcutLabelCateg.Name = "prodcutLabelCateg";
            this.prodcutLabelCateg.Size = new System.Drawing.Size(100, 37);
            this.prodcutLabelCateg.TabIndex = 4;
            this.prodcutLabelCateg.Text = "label1";
            // 
            // productpictureBox
            // 
            this.productpictureBox.Location = new System.Drawing.Point(25, 16);
            this.productpictureBox.Name = "productpictureBox";
            this.productpictureBox.Size = new System.Drawing.Size(259, 233);
            this.productpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productpictureBox.TabIndex = 0;
            this.productpictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(1671, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prodcutLabelCateg);
            this.Controls.Add(this.productLabelPrice);
            this.Controls.Add(this.productLabelDesc);
            this.Controls.Add(this.productLlabelTItle);
            this.Controls.Add(this.productpictureBox);
            this.Name = "productList";
            this.Size = new System.Drawing.Size(1945, 265);
            ((System.ComponentModel.ISupportInitialize)(this.productpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productpictureBox;
        private System.Windows.Forms.Label productLlabelTItle;
        private System.Windows.Forms.Label productLabelDesc;
        private System.Windows.Forms.Label productLabelPrice;
        private System.Windows.Forms.Label prodcutLabelCateg;
        private System.Windows.Forms.Button button1;
    }
}
