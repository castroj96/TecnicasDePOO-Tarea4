namespace Clase_8
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
            this.lbl_doctorNumber = new System.Windows.Forms.Label();
            this.txt_doctorNumber = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_doctorNumber
            // 
            this.lbl_doctorNumber.AutoSize = true;
            this.lbl_doctorNumber.Location = new System.Drawing.Point(12, 9);
            this.lbl_doctorNumber.Name = "lbl_doctorNumber";
            this.lbl_doctorNumber.Size = new System.Drawing.Size(49, 13);
            this.lbl_doctorNumber.TabIndex = 0;
            this.lbl_doctorNumber.Text = "Doctor #";
            // 
            // txt_doctorNumber
            // 
            this.txt_doctorNumber.Location = new System.Drawing.Point(67, 6);
            this.txt_doctorNumber.Name = "txt_doctorNumber";
            this.txt_doctorNumber.Size = new System.Drawing.Size(143, 20);
            this.txt_doctorNumber.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(67, 32);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 70);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_doctorNumber);
            this.Controls.Add(this.lbl_doctorNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_doctorNumber;
        private System.Windows.Forms.TextBox txt_doctorNumber;
        private System.Windows.Forms.Button btn_Login;
    }
}

