namespace WindowsForms_school_management
{
  partial class LoginForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
      this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.txtpassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
      this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.ShowPassword = new MaterialSkin.Controls.MaterialCheckBox();
      this.CheckBoxRemeber = new MaterialSkin.Controls.MaterialCheckBox();
      this.Sidebarpanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // contentpanel
      // 
      this.contentpanel.Size = new System.Drawing.Size(800, 482);
      // 
      // Sidebarpanel
      // 
      this.Sidebarpanel.BackColor = System.Drawing.Color.Silver;
      this.Sidebarpanel.Controls.Add(this.CheckBoxRemeber);
      this.Sidebarpanel.Controls.Add(this.ShowPassword);
      this.Sidebarpanel.Controls.Add(this.pictureBox2);
      this.Sidebarpanel.Controls.Add(this.pictureBox1);
      this.Sidebarpanel.Controls.Add(this.materialFlatButton2);
      this.Sidebarpanel.Controls.Add(this.materialFlatButton1);
      this.Sidebarpanel.Controls.Add(this.txtpassword);
      this.Sidebarpanel.Controls.Add(this.materialSingleLineTextField1);
      this.Sidebarpanel.Controls.Add(this.materialLabel2);
      this.Sidebarpanel.Controls.Add(this.materialLabel1);
      this.Sidebarpanel.Size = new System.Drawing.Size(400, 482);
      // 
      // materialLabel1
      // 
      this.materialLabel1.AutoSize = true;
      this.materialLabel1.Depth = 0;
      this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel1.Location = new System.Drawing.Point(27, 123);
      this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel1.Name = "materialLabel1";
      this.materialLabel1.Size = new System.Drawing.Size(77, 19);
      this.materialLabel1.TabIndex = 0;
      this.materialLabel1.Text = "Username";
      // 
      // materialLabel2
      // 
      this.materialLabel2.AutoSize = true;
      this.materialLabel2.Depth = 0;
      this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel2.Location = new System.Drawing.Point(27, 185);
      this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel2.Name = "materialLabel2";
      this.materialLabel2.Size = new System.Drawing.Size(75, 19);
      this.materialLabel2.TabIndex = 1;
      this.materialLabel2.Text = "Password";
      // 
      // materialSingleLineTextField1
      // 
      this.materialSingleLineTextField1.Depth = 0;
      this.materialSingleLineTextField1.Hint = "";
      this.materialSingleLineTextField1.Location = new System.Drawing.Point(110, 119);
      this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
      this.materialSingleLineTextField1.PasswordChar = '\0';
      this.materialSingleLineTextField1.SelectedText = "";
      this.materialSingleLineTextField1.SelectionLength = 0;
      this.materialSingleLineTextField1.SelectionStart = 0;
      this.materialSingleLineTextField1.Size = new System.Drawing.Size(233, 23);
      this.materialSingleLineTextField1.TabIndex = 2;
      this.materialSingleLineTextField1.Text = "Enter Username";
      this.materialSingleLineTextField1.UseSystemPasswordChar = false;
      this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
      this.materialSingleLineTextField1.Leave += new System.EventHandler(this.materialSingleLineTextField1_Leave);
      // 
      // txtpassword
      // 
      this.txtpassword.Depth = 0;
      this.txtpassword.Hint = "";
      this.txtpassword.Location = new System.Drawing.Point(108, 181);
      this.txtpassword.MouseState = MaterialSkin.MouseState.HOVER;
      this.txtpassword.Name = "txtpassword";
      this.txtpassword.PasswordChar = '\0';
      this.txtpassword.SelectedText = "";
      this.txtpassword.SelectionLength = 0;
      this.txtpassword.SelectionStart = 0;
      this.txtpassword.Size = new System.Drawing.Size(184, 23);
      this.txtpassword.TabIndex = 3;
      this.txtpassword.Text = "Enter Password";
      this.txtpassword.UseSystemPasswordChar = false;
      this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
      this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
      // 
      // materialFlatButton1
      // 
      this.materialFlatButton1.AutoSize = true;
      this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.materialFlatButton1.BackColor = System.Drawing.Color.White;
      this.materialFlatButton1.Depth = 0;
      this.materialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.materialFlatButton1.Location = new System.Drawing.Point(110, 253);
      this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialFlatButton1.Name = "materialFlatButton1";
      this.materialFlatButton1.Primary = false;
      this.materialFlatButton1.Size = new System.Drawing.Size(52, 36);
      this.materialFlatButton1.TabIndex = 4;
      this.materialFlatButton1.Text = "LOGIN";
      this.materialFlatButton1.UseVisualStyleBackColor = false;
      // 
      // materialFlatButton2
      // 
      this.materialFlatButton2.AutoSize = true;
      this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.materialFlatButton2.BackColor = System.Drawing.Color.White;
      this.materialFlatButton2.Depth = 0;
      this.materialFlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.materialFlatButton2.Location = new System.Drawing.Point(209, 253);
      this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialFlatButton2.Name = "materialFlatButton2";
      this.materialFlatButton2.Primary = false;
      this.materialFlatButton2.Size = new System.Drawing.Size(159, 36);
      this.materialFlatButton2.TabIndex = 5;
      this.materialFlatButton2.Text = "FORGOTEN PASSWORD";
      this.materialFlatButton2.UseVisualStyleBackColor = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(362, 116);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(26, 26);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(362, 178);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(26, 26);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox2.TabIndex = 7;
      this.pictureBox2.TabStop = false;
      // 
      // ShowPassword
      // 
      this.ShowPassword.AutoSize = true;
      this.ShowPassword.Depth = 0;
      this.ShowPassword.Font = new System.Drawing.Font("Roboto", 10F);
      this.ShowPassword.Location = new System.Drawing.Point(291, 181);
      this.ShowPassword.Margin = new System.Windows.Forms.Padding(0);
      this.ShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
      this.ShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
      this.ShowPassword.Name = "ShowPassword";
      this.ShowPassword.Ripple = true;
      this.ShowPassword.Size = new System.Drawing.Size(64, 30);
      this.ShowPassword.TabIndex = 8;
      this.ShowPassword.Text = "Show";
      this.ShowPassword.UseVisualStyleBackColor = true;
      this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
      // 
      // CheckBoxRemeber
      // 
      this.CheckBoxRemeber.AutoSize = true;
      this.CheckBoxRemeber.Depth = 0;
      this.CheckBoxRemeber.Font = new System.Drawing.Font("Roboto", 10F);
      this.CheckBoxRemeber.Location = new System.Drawing.Point(124, 217);
      this.CheckBoxRemeber.Margin = new System.Windows.Forms.Padding(0);
      this.CheckBoxRemeber.MouseLocation = new System.Drawing.Point(-1, -1);
      this.CheckBoxRemeber.MouseState = MaterialSkin.MouseState.HOVER;
      this.CheckBoxRemeber.Name = "CheckBoxRemeber";
      this.CheckBoxRemeber.Ripple = true;
      this.CheckBoxRemeber.Size = new System.Drawing.Size(120, 30);
      this.CheckBoxRemeber.TabIndex = 9;
      this.CheckBoxRemeber.Text = "Remember Me";
      this.CheckBoxRemeber.UseVisualStyleBackColor = true;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 557);
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LoginForm";
      this.Sidebarpanel.ResumeLayout(false);
      this.Sidebarpanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtpassword;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialCheckBox CheckBoxRemeber;
    private MaterialSkin.Controls.MaterialCheckBox ShowPassword;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}