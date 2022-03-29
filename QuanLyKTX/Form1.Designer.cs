
namespace QuanLyKTX
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
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.txtHeading = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(210, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(73, 17);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Location = new System.Drawing.Point(210, 112);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(69, 17);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Password";
            this.txtPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxUsername
            // 
            this.boxUsername.Location = new System.Drawing.Point(289, 76);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(261, 22);
            this.boxUsername.TabIndex = 2;
            this.boxUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boxUsername_MouseClick);
            // 
            // boxPass
            // 
            this.boxPass.Location = new System.Drawing.Point(289, 112);
            this.boxPass.Name = "boxPass";
            this.boxPass.PasswordChar = '*';
            this.boxPass.Size = new System.Drawing.Size(261, 22);
            this.boxPass.TabIndex = 3;
            this.boxPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boxPass_MouseClick);
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Location = new System.Drawing.Point(289, 152);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(140, 21);
            this.checkPass.TabIndex = 4;
            this.checkPass.Text = "Hiển thị mật khẩu";
            this.checkPass.UseVisualStyleBackColor = true;
            this.checkPass.CheckedChanged += new System.EventHandler(this.checkPass_CheckedChanged);
            // 
            // txtHeading
            // 
            this.txtHeading.AutoSize = true;
            this.txtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Location = new System.Drawing.Point(284, 24);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(263, 29);
            this.txtHeading.TabIndex = 5;
            this.txtHeading.Text = "Thông tin đăng nhập";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(203, 206);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(155, 56);
            this.btnDangnhap.TabIndex = 6;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 56);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.boxUsername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Label txtHeading;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnExit;
    }
}

