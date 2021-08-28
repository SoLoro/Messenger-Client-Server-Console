namespace DotChatWF
{
  partial class AuthentificationForm
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
	    this.btnLogin = new System.Windows.Forms.Button();
	    this.loginBox = new System.Windows.Forms.TextBox();
	    this.passBox = new System.Windows.Forms.TextBox();
	    this.label1 = new System.Windows.Forms.Label();
	    this.label2 = new System.Windows.Forms.Label();
	    this.label3 = new System.Windows.Forms.Label();
	    this.ipBoxBox = new System.Windows.Forms.TextBox();
	    this.SuspendLayout();
	    // 
	    // btnLogin
	    // 
	    this.btnLogin.Location = new System.Drawing.Point(331, 109);
	    this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	    this.btnLogin.Name = "btnLogin";
	    this.btnLogin.Size = new System.Drawing.Size(92, 50);
	    this.btnLogin.TabIndex = 0;
	    this.btnLogin.Text = "Login";
	    this.btnLogin.UseVisualStyleBackColor = true;
	    this.btnLogin.Click += new System.EventHandler(this.button1_Click);
	    // 
	    // loginBox
	    // 
	    this.loginBox.Location = new System.Drawing.Point(12, 48);
	    this.loginBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	    this.loginBox.Name = "loginBox";
	    this.loginBox.Size = new System.Drawing.Size(276, 22);
	    this.loginBox.TabIndex = 1;
	    // 
	    // passBox
	    // 
	    this.passBox.Location = new System.Drawing.Point(12, 123);
	    this.passBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	    this.passBox.Name = "passBox";
	    this.passBox.PasswordChar = '*';
	    this.passBox.Size = new System.Drawing.Size(276, 22);
	    this.passBox.TabIndex = 2;
	    // 
	    // label1
	    // 
	    this.label1.AutoSize = true;
	    this.label1.Location = new System.Drawing.Point(111, 18);
	    this.label1.Name = "label1";
	    this.label1.Size = new System.Drawing.Size(77, 17);
	    this.label1.TabIndex = 4;
	    this.label1.Text = "Username:";
	    this.label1.Click += new System.EventHandler(this.label1_Click);
	    // 
	    // label2
	    // 
	    this.label2.AutoSize = true;
	    this.label2.Location = new System.Drawing.Point(115, 93);
	    this.label2.Name = "label2";
	    this.label2.Size = new System.Drawing.Size(73, 17);
	    this.label2.TabIndex = 5;
	    this.label2.Text = "Password:";
	    // 
	    // label3
	    // 
	    this.label3.AutoSize = true;
	    this.label3.Location = new System.Drawing.Point(138, 166);
	    this.label3.Name = "label3";
	    this.label3.Size = new System.Drawing.Size(28, 17);
	    this.label3.TabIndex = 6;
	    this.label3.Text = "IP: ";
	    this.label3.Click += new System.EventHandler(this.label3_Click);
	    // 
	    // ipBoxBox
	    // 
	    this.ipBoxBox.Location = new System.Drawing.Point(12, 194);
	    this.ipBoxBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	    this.ipBoxBox.Name = "ipBoxBox";
	    this.ipBoxBox.Size = new System.Drawing.Size(276, 22);
	    this.ipBoxBox.TabIndex = 7;
	    this.ipBoxBox.TextChanged += new System.EventHandler(this.ipBoxBox_TextChanged);
	    // 
	    // AuthentificationForm
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(457, 247);
	    this.Controls.Add(this.ipBoxBox);
	    this.Controls.Add(this.label3);
	    this.Controls.Add(this.label2);
	    this.Controls.Add(this.label1);
	    this.Controls.Add(this.passBox);
	    this.Controls.Add(this.loginBox);
	    this.Controls.Add(this.btnLogin);
	    this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
	    this.Name = "AuthentificationForm";
	    this.Text = "AuthentificationForm";
	    this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthentificationForm_FormClosed);
	    this.Load += new System.EventHandler(this.AuthentificationForm_Load);
	    this.ResumeLayout(false);
	    this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.TextBox loginBox;
    private System.Windows.Forms.TextBox passBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ipBoxBox;
	}
}