namespace Veritabanı_deneme
{
    partial class Form4
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LİSTELE = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbadres = new System.Windows.Forms.TextBox();
            this.txbadres2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(759, 208);
            this.dataGridView2.TabIndex = 0;
            // 
            // LİSTELE
            // 
            this.LİSTELE.Location = new System.Drawing.Point(12, 241);
            this.LİSTELE.Name = "LİSTELE";
            this.LİSTELE.Size = new System.Drawing.Size(224, 55);
            this.LİSTELE.TabIndex = 1;
            this.LİSTELE.Text = "Listele";
            this.LİSTELE.UseVisualStyleBackColor = true;
            this.LİSTELE.Click += new System.EventHandler(this.LİSTELE_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(364, 241);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(123, 23);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "SEÇ";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbadres
            // 
            this.txbadres.Location = new System.Drawing.Point(521, 274);
            this.txbadres.Name = "txbadres";
            this.txbadres.Size = new System.Drawing.Size(234, 22);
            this.txbadres.TabIndex = 4;
            // 
            // txbadres2
            // 
            this.txbadres2.Location = new System.Drawing.Point(521, 366);
            this.txbadres2.Name = "txbadres2";
            this.txbadres2.Size = new System.Drawing.Size(234, 22);
            this.txbadres2.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbadres2);
            this.Controls.Add(this.txbadres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.LİSTELE);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button LİSTELE;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbadres;
        private System.Windows.Forms.TextBox txbadres2;
    }
}