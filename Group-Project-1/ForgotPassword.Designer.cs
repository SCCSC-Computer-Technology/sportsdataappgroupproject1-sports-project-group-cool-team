namespace Group_Project_1
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecoverPassword = new System.Windows.Forms.TextBox();
            this.btnSendReset = new System.Windows.Forms.Button();
            this.btnReturnToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // txtRecoverPassword
            // 
            this.txtRecoverPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecoverPassword.Location = new System.Drawing.Point(97, 28);
            this.txtRecoverPassword.Name = "txtRecoverPassword";
            this.txtRecoverPassword.Size = new System.Drawing.Size(198, 23);
            this.txtRecoverPassword.TabIndex = 1;
            // 
            // btnSendReset
            // 
            this.btnSendReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendReset.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendReset.Location = new System.Drawing.Point(124, 72);
            this.btnSendReset.Name = "btnSendReset";
            this.btnSendReset.Size = new System.Drawing.Size(120, 23);
            this.btnSendReset.TabIndex = 2;
            this.btnSendReset.Text = "&Send Reset Link";
            this.btnSendReset.UseVisualStyleBackColor = true;
            // 
            // btnReturnToLogin
            // 
            this.btnReturnToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnToLogin.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToLogin.Location = new System.Drawing.Point(124, 115);
            this.btnReturnToLogin.Name = "btnReturnToLogin";
            this.btnReturnToLogin.Size = new System.Drawing.Size(120, 23);
            this.btnReturnToLogin.TabIndex = 3;
            this.btnReturnToLogin.Text = "&Return to Login";
            this.btnReturnToLogin.UseVisualStyleBackColor = true;
            this.btnReturnToLogin.Click += new System.EventHandler(this.btnReturnToLogin_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(354, 187);
            this.Controls.Add(this.btnReturnToLogin);
            this.Controls.Add(this.btnSendReset);
            this.Controls.Add(this.txtRecoverPassword);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecoverPassword;
        private System.Windows.Forms.Button btnSendReset;
        private System.Windows.Forms.Button btnReturnToLogin;
    }
}