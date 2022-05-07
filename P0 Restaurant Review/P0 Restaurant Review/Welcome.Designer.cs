namespace P0_Restaurant_Review
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Userlogin = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Button();
            this.Adminusername = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Adminpassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hi There!. Get started Below";
            // 
            // Userlogin
            // 
            this.Userlogin.Location = new System.Drawing.Point(55, 127);
            this.Userlogin.Name = "Userlogin";
            this.Userlogin.Size = new System.Drawing.Size(206, 23);
            this.Userlogin.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(96, 92);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(114, 20);
            this.Username.TabIndex = 2;
            this.Username.Text = "Your Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(96, 203);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(108, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Your Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 23);
            this.textBox1.TabIndex = 4;
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(55, 309);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(216, 63);
            this.User.TabIndex = 5;
            this.User.Text = "Submit";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // Adminusername
            // 
            this.Adminusername.AutoSize = true;
            this.Adminusername.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Adminusername.Location = new System.Drawing.Point(592, 92);
            this.Adminusername.Name = "Adminusername";
            this.Adminusername.Size = new System.Drawing.Size(125, 20);
            this.Adminusername.TabIndex = 6;
            this.Adminusername.Text = "Admin Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(535, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 23);
            this.textBox2.TabIndex = 7;
            // 
            // Adminpassword
            // 
            this.Adminpassword.AutoSize = true;
            this.Adminpassword.Font = new System.Drawing.Font("Josefin Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Adminpassword.Location = new System.Drawing.Point(580, 203);
            this.Adminpassword.Name = "Adminpassword";
            this.Adminpassword.Size = new System.Drawing.Size(119, 20);
            this.Adminpassword.TabIndex = 8;
            this.Adminpassword.Text = "Admin Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(535, 235);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 23);
            this.textBox3.TabIndex = 9;
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Josefin Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Admin.Location = new System.Drawing.Point(535, 309);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(216, 63);
            this.Admin.TabIndex = 10;
            this.Admin.Text = "Submit";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Adminpassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Adminusername);
            this.Controls.Add(this.User);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Userlogin);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Userlogin;
        private Label Username;
        private Label Password;
        private TextBox textBox1;
        private Button User;
        private Label Adminusername;
        private TextBox textBox2;
        private Label Adminpassword;
        private TextBox textBox3;
        private Button Admin;
    }
}