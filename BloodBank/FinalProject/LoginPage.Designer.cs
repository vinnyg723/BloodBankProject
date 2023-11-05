namespace FinalProject
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkEmployee = new System.Windows.Forms.CheckBox();
            this.lblLoginErrorOutput = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.btnNewDonor = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username or Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(97, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(168, 25);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(136, 20);
            this.txtEmailLogin.TabIndex = 2;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(168, 57);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(136, 20);
            this.txtPasswordLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Red;
            this.btnLogin.Location = new System.Drawing.Point(175, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 34);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkEmployee
            // 
            this.chkEmployee.AutoSize = true;
            this.chkEmployee.BackColor = System.Drawing.Color.Transparent;
            this.chkEmployee.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkEmployee.Location = new System.Drawing.Point(175, 83);
            this.chkEmployee.Name = "chkEmployee";
            this.chkEmployee.Size = new System.Drawing.Size(117, 21);
            this.chkEmployee.TabIndex = 4;
            this.chkEmployee.Text = "Employee Login";
            this.chkEmployee.UseVisualStyleBackColor = false;
            // 
            // lblLoginErrorOutput
            // 
            this.lblLoginErrorOutput.AutoSize = true;
            this.lblLoginErrorOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginErrorOutput.Location = new System.Drawing.Point(172, 146);
            this.lblLoginErrorOutput.Name = "lblLoginErrorOutput";
            this.lblLoginErrorOutput.Size = new System.Drawing.Size(0, 13);
            this.lblLoginErrorOutput.TabIndex = 8;
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewUser.Location = new System.Drawing.Point(33, 199);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(340, 17);
            this.lblNewUser.TabIndex = 9;
            this.lblNewUser.Text = "Would you like to donate but don\'t have an account?";
            // 
            // btnNewDonor
            // 
            this.btnNewDonor.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDonor.ForeColor = System.Drawing.Color.Red;
            this.btnNewDonor.Location = new System.Drawing.Point(153, 219);
            this.btnNewDonor.Name = "btnNewDonor";
            this.btnNewDonor.Size = new System.Drawing.Size(111, 44);
            this.btnNewDonor.TabIndex = 10;
            this.btnNewDonor.Text = "Sign Up Here";
            this.btnNewDonor.UseVisualStyleBackColor = true;
            this.btnNewDonor.Click += new System.EventHandler(this.btnNewDonor_Click);
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.ForeColor = System.Drawing.Color.Red;
            this.btnNewEmployee.Location = new System.Drawing.Point(319, 240);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnNewEmployee.TabIndex = 11;
            this.btnNewEmployee.Text = "Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(406, 288);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnNewDonor);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.lblLoginErrorOutput);
            this.Controls.Add(this.chkEmployee);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkEmployee;
        private System.Windows.Forms.Label lblLoginErrorOutput;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.Button btnNewDonor;
        private System.Windows.Forms.Button btnNewEmployee;
    }
}

