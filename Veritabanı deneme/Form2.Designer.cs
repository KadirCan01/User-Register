namespace Veritabanı_Deneme
{
    partial class Form2
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
            this.name = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.tbbirthday = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Red;
            this.name.Location = new System.Drawing.Point(23, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 16);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(23, 86);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(72, 16);
            this.lastname.TabIndex = 1;
            this.lastname.Text = "LastName:";
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(23, 131);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(59, 16);
            this.birthday.TabIndex = 2;
            this.birthday.Text = "Birthday:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(23, 176);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(44, 16);
            this.email.TabIndex = 3;
            this.email.Text = "Email:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(23, 220);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 4;
            this.password.Text = "Password:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(23, 269);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(35, 16);
            this.age.TabIndex = 5;
            this.age.Text = "Age:";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(223, 34);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(192, 22);
            this.tbname.TabIndex = 6;
            // 
            // tblastname
            // 
            this.tblastname.Location = new System.Drawing.Point(223, 80);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(192, 22);
            this.tblastname.TabIndex = 7;
            // 
            // tbbirthday
            // 
            this.tbbirthday.Location = new System.Drawing.Point(223, 125);
            this.tbbirthday.Name = "tbbirthday";
            this.tbbirthday.Size = new System.Drawing.Size(192, 22);
            this.tbbirthday.TabIndex = 8;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(223, 170);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(192, 22);
            this.tbemail.TabIndex = 9;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(223, 214);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(192, 22);
            this.tbpassword.TabIndex = 10;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(223, 263);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(192, 22);
            this.tbage.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(223, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Veri Tabanına Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(816, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbbirthday);
            this.Controls.Add(this.tblastname);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.age);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label birthday;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.TextBox tbbirthday;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.Button button1;
    }
}