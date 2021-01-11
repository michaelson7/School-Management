namespace WindowsForms_school_management
{
  partial class Main_Dashboard
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
      this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
      this.profile = new System.Windows.Forms.TabPage();
      this.Settings = new System.Windows.Forms.TabPage();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.button9 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
      this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
      this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.panel1.SuspendLayout();
      this.materialTabControl1.SuspendLayout();
      this.profile.SuspendLayout();
      this.Settings.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
      this.panel1.Controls.Add(this.materialTabSelector1);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 75);
      this.panel1.TabIndex = 0;
      // 
      // materialTabSelector1
      // 
      this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
      this.materialTabSelector1.Depth = 0;
      this.materialTabSelector1.Location = new System.Drawing.Point(0, 52);
      this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialTabSelector1.Name = "materialTabSelector1";
      this.materialTabSelector1.Size = new System.Drawing.Size(800, 23);
      this.materialTabSelector1.TabIndex = 2;
      this.materialTabSelector1.Text = "materialTabSelector1";
      // 
      // materialTabControl1
      // 
      this.materialTabControl1.Controls.Add(this.profile);
      this.materialTabControl1.Controls.Add(this.Settings);
      this.materialTabControl1.Depth = 0;
      this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
      this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialTabControl1.Name = "materialTabControl1";
      this.materialTabControl1.SelectedIndex = 0;
      this.materialTabControl1.Size = new System.Drawing.Size(800, 375);
      this.materialTabControl1.TabIndex = 0;
      // 
      // profile
      // 
      this.profile.BackColor = System.Drawing.Color.White;
      this.profile.Controls.Add(this.materialSingleLineTextField3);
      this.profile.Controls.Add(this.materialSingleLineTextField4);
      this.profile.Controls.Add(this.materialLabel3);
      this.profile.Controls.Add(this.materialLabel4);
      this.profile.Location = new System.Drawing.Point(4, 22);
      this.profile.Name = "profile";
      this.profile.Padding = new System.Windows.Forms.Padding(3);
      this.profile.Size = new System.Drawing.Size(792, 349);
      this.profile.TabIndex = 0;
      this.profile.Text = "Profile";
      // 
      // Settings
      // 
      this.Settings.BackColor = System.Drawing.Color.White;
      this.Settings.Controls.Add(this.materialSingleLineTextField5);
      this.Settings.Controls.Add(this.materialLabel5);
      this.Settings.Controls.Add(this.materialSingleLineTextField2);
      this.Settings.Controls.Add(this.materialSingleLineTextField1);
      this.Settings.Controls.Add(this.materialLabel2);
      this.Settings.Controls.Add(this.materialLabel1);
      this.Settings.Location = new System.Drawing.Point(4, 22);
      this.Settings.Name = "Settings";
      this.Settings.Padding = new System.Windows.Forms.Padding(3);
      this.Settings.Size = new System.Drawing.Size(792, 349);
      this.Settings.TabIndex = 1;
      this.Settings.Text = "Settings";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(12, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(330, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "SCHOOL MANAGEMENT";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.materialTabControl1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 75);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(800, 375);
      this.panel2.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.tableLayoutPanel1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 75);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(400, 375);
      this.panel3.TabIndex = 2;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 375);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // button9
      // 
      this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button9.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button9.Location = new System.Drawing.Point(269, 253);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(128, 119);
      this.button9.TabIndex = 8;
      this.button9.Text = "Roles";
      this.button9.UseVisualStyleBackColor = true;
      // 
      // button8
      // 
      this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button8.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button8.Location = new System.Drawing.Point(136, 253);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(127, 119);
      this.button8.TabIndex = 7;
      this.button8.Text = "Levels";
      this.button8.UseVisualStyleBackColor = true;
      // 
      // button7
      // 
      this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button7.Location = new System.Drawing.Point(3, 253);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(127, 119);
      this.button7.TabIndex = 6;
      this.button7.Text = "Periods";
      this.button7.UseVisualStyleBackColor = true;
      // 
      // button6
      // 
      this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button6.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button6.Location = new System.Drawing.Point(269, 128);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(128, 119);
      this.button6.TabIndex = 5;
      this.button6.Text = "Time";
      this.button6.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button5.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button5.Location = new System.Drawing.Point(136, 128);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(127, 119);
      this.button5.TabIndex = 4;
      this.button5.Text = "Subjects";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button4.Location = new System.Drawing.Point(3, 128);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(127, 119);
      this.button4.TabIndex = 3;
      this.button4.Text = "Class Scheduling";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button3.Location = new System.Drawing.Point(269, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(128, 119);
      this.button3.TabIndex = 2;
      this.button3.Text = "Classes";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button2.Location = new System.Drawing.Point(136, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(127, 119);
      this.button2.TabIndex = 1;
      this.button2.Text = "Teachers";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.button1.Location = new System.Drawing.Point(3, 3);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(127, 119);
      this.button1.TabIndex = 0;
      this.button1.Text = "Admission";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // materialLabel1
      // 
      this.materialLabel1.AutoSize = true;
      this.materialLabel1.Depth = 0;
      this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel1.Location = new System.Drawing.Point(415, 50);
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
      this.materialLabel2.Location = new System.Drawing.Point(415, 106);
      this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel2.Name = "materialLabel2";
      this.materialLabel2.Size = new System.Drawing.Size(101, 19);
      this.materialLabel2.TabIndex = 1;
      this.materialLabel2.Text = "Old Password";
      // 
      // materialSingleLineTextField1
      // 
      this.materialSingleLineTextField1.Depth = 0;
      this.materialSingleLineTextField1.Hint = "";
      this.materialSingleLineTextField1.Location = new System.Drawing.Point(522, 46);
      this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
      this.materialSingleLineTextField1.PasswordChar = '\0';
      this.materialSingleLineTextField1.SelectedText = "";
      this.materialSingleLineTextField1.SelectionLength = 0;
      this.materialSingleLineTextField1.SelectionStart = 0;
      this.materialSingleLineTextField1.Size = new System.Drawing.Size(211, 23);
      this.materialSingleLineTextField1.TabIndex = 2;
      this.materialSingleLineTextField1.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField2
      // 
      this.materialSingleLineTextField2.Depth = 0;
      this.materialSingleLineTextField2.Hint = "";
      this.materialSingleLineTextField2.Location = new System.Drawing.Point(522, 102);
      this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
      this.materialSingleLineTextField2.PasswordChar = '\0';
      this.materialSingleLineTextField2.SelectedText = "";
      this.materialSingleLineTextField2.SelectionLength = 0;
      this.materialSingleLineTextField2.SelectionStart = 0;
      this.materialSingleLineTextField2.Size = new System.Drawing.Size(211, 23);
      this.materialSingleLineTextField2.TabIndex = 3;
      this.materialSingleLineTextField2.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField3
      // 
      this.materialSingleLineTextField3.Depth = 0;
      this.materialSingleLineTextField3.Hint = "";
      this.materialSingleLineTextField3.Location = new System.Drawing.Point(505, 109);
      this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
      this.materialSingleLineTextField3.PasswordChar = '\0';
      this.materialSingleLineTextField3.SelectedText = "";
      this.materialSingleLineTextField3.SelectionLength = 0;
      this.materialSingleLineTextField3.SelectionStart = 0;
      this.materialSingleLineTextField3.Size = new System.Drawing.Size(211, 23);
      this.materialSingleLineTextField3.TabIndex = 7;
      this.materialSingleLineTextField3.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField4
      // 
      this.materialSingleLineTextField4.Depth = 0;
      this.materialSingleLineTextField4.Hint = "";
      this.materialSingleLineTextField4.Location = new System.Drawing.Point(505, 53);
      this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
      this.materialSingleLineTextField4.PasswordChar = '\0';
      this.materialSingleLineTextField4.SelectedText = "";
      this.materialSingleLineTextField4.SelectionLength = 0;
      this.materialSingleLineTextField4.SelectionStart = 0;
      this.materialSingleLineTextField4.Size = new System.Drawing.Size(211, 23);
      this.materialSingleLineTextField4.TabIndex = 6;
      this.materialSingleLineTextField4.UseSystemPasswordChar = false;
      // 
      // materialLabel3
      // 
      this.materialLabel3.AutoSize = true;
      this.materialLabel3.Depth = 0;
      this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel3.Location = new System.Drawing.Point(417, 113);
      this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel3.Name = "materialLabel3";
      this.materialLabel3.Size = new System.Drawing.Size(82, 19);
      this.materialLabel3.TabIndex = 5;
      this.materialLabel3.Text = "Last Name";
      // 
      // materialLabel4
      // 
      this.materialLabel4.AutoSize = true;
      this.materialLabel4.Depth = 0;
      this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel4.Location = new System.Drawing.Point(416, 57);
      this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel4.Name = "materialLabel4";
      this.materialLabel4.Size = new System.Drawing.Size(83, 19);
      this.materialLabel4.TabIndex = 4;
      this.materialLabel4.Text = "First Name";
      // 
      // materialLabel5
      // 
      this.materialLabel5.AutoSize = true;
      this.materialLabel5.Depth = 0;
      this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel5.Location = new System.Drawing.Point(415, 155);
      this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel5.Name = "materialLabel5";
      this.materialLabel5.Size = new System.Drawing.Size(109, 19);
      this.materialLabel5.TabIndex = 4;
      this.materialLabel5.Text = "New Password";
      // 
      // materialSingleLineTextField5
      // 
      this.materialSingleLineTextField5.Depth = 0;
      this.materialSingleLineTextField5.Hint = "";
      this.materialSingleLineTextField5.Location = new System.Drawing.Point(522, 151);
      this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
      this.materialSingleLineTextField5.PasswordChar = '\0';
      this.materialSingleLineTextField5.SelectedText = "";
      this.materialSingleLineTextField5.SelectionLength = 0;
      this.materialSingleLineTextField5.SelectionStart = 0;
      this.materialSingleLineTextField5.Size = new System.Drawing.Size(211, 23);
      this.materialSingleLineTextField5.TabIndex = 5;
      this.materialSingleLineTextField5.UseSystemPasswordChar = false;
      // 
      // Main_Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "Main_Dashboard";
      this.Text = "Main_Dashboard";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.materialTabControl1.ResumeLayout(false);
      this.profile.ResumeLayout(false);
      this.profile.PerformLayout();
      this.Settings.ResumeLayout(false);
      this.Settings.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
    private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    private System.Windows.Forms.TabPage profile;
    private System.Windows.Forms.TabPage Settings;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialLabel materialLabel4;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
    private MaterialSkin.Controls.MaterialLabel materialLabel5;
  }
}