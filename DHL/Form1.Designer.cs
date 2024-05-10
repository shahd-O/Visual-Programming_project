namespace DHL
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.usernamelbl = new System.Windows.Forms.Label();
            this.pswdlbl = new System.Windows.Forms.Label();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.pswdtxtbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.usernamelbl.Location = new System.Drawing.Point(107, 184);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(100, 24);
            this.usernamelbl.TabIndex = 0;
            this.usernamelbl.Text = "Username";
            // 
            // pswdlbl
            // 
            this.pswdlbl.AutoSize = true;
            this.pswdlbl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pswdlbl.Location = new System.Drawing.Point(110, 238);
            this.pswdlbl.Name = "pswdlbl";
            this.pswdlbl.Size = new System.Drawing.Size(94, 24);
            this.pswdlbl.TabIndex = 1;
            this.pswdlbl.Text = "Password";
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.usernametxtbox.Location = new System.Drawing.Point(234, 184);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(203, 32);
            this.usernametxtbox.TabIndex = 2;
            this.usernametxtbox.TextChanged += new System.EventHandler(this.usernametxtbox_TextChanged);
            // 
            // pswdtxtbox
            // 
            this.pswdtxtbox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pswdtxtbox.Location = new System.Drawing.Point(234, 238);
            this.pswdtxtbox.Name = "pswdtxtbox";
            this.pswdtxtbox.PasswordChar = '*';
            this.pswdtxtbox.Size = new System.Drawing.Size(203, 32);
            this.pswdtxtbox.TabIndex = 3;
            this.pswdtxtbox.TextChanged += new System.EventHandler(this.pswdtxtbox_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(234, 302);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(94, 32);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pswdtxtbox);
            this.Controls.Add(this.usernametxtbox);
            this.Controls.Add(this.pswdlbl);
            this.Controls.Add(this.usernamelbl);
            this.Name = "LoginScreen";
            this.Text = "Login Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label pswdlbl;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.TextBox pswdtxtbox;
        private System.Windows.Forms.Button loginbtn;
    }
}

