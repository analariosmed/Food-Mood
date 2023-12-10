namespace Food_Mood
{
    partial class NewAccount
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNAName = new System.Windows.Forms.TextBox();
            this.textBoxNAPassword = new System.Windows.Forms.TextBox();
            this.textBoxNAEmail = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // textBoxNAName
            // 
            this.textBoxNAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNAName.Location = new System.Drawing.Point(110, 74);
            this.textBoxNAName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxNAName.Name = "textBoxNAName";
            this.textBoxNAName.Size = new System.Drawing.Size(212, 26);
            this.textBoxNAName.TabIndex = 4;
            // 
            // textBoxNAPassword
            // 
            this.textBoxNAPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNAPassword.Location = new System.Drawing.Point(110, 113);
            this.textBoxNAPassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxNAPassword.Name = "textBoxNAPassword";
            this.textBoxNAPassword.Size = new System.Drawing.Size(212, 26);
            this.textBoxNAPassword.TabIndex = 5;
            // 
            // textBoxNAEmail
            // 
            this.textBoxNAEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNAEmail.Location = new System.Drawing.Point(110, 165);
            this.textBoxNAEmail.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxNAEmail.Name = "textBoxNAEmail";
            this.textBoxNAEmail.Size = new System.Drawing.Size(212, 26);
            this.textBoxNAEmail.TabIndex = 7;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonCreate.Location = new System.Drawing.Point(138, 240);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(95, 51);
            this.buttonCreate.TabIndex = 10;
            this.buttonCreate.Text = "Create Account";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "New Account";
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 341);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxNAEmail);
            this.Controls.Add(this.textBoxNAPassword);
            this.Controls.Add(this.textBoxNAName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNAName;
        private System.Windows.Forms.TextBox textBoxNAPassword;
        private System.Windows.Forms.TextBox textBoxNAEmail;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label5;
    }
}