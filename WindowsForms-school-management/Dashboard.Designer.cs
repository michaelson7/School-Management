namespace WindowsForms_school_management
{
  partial class Dashboard
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
      this.navbarpanel = new System.Windows.Forms.Panel();
      this.contentpanel = new System.Windows.Forms.Panel();
      this.Sidebarpanel = new System.Windows.Forms.Panel();
      this.panel4 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.navbarpanel.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // navbarpanel
      // 
      this.navbarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
      this.navbarpanel.Controls.Add(this.label1);
      this.navbarpanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.navbarpanel.Location = new System.Drawing.Point(0, 0);
      this.navbarpanel.Name = "navbarpanel";
      this.navbarpanel.Size = new System.Drawing.Size(800, 75);
      this.navbarpanel.TabIndex = 0;
      // 
      // contentpanel
      // 
      this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.contentpanel.Location = new System.Drawing.Point(0, 75);
      this.contentpanel.Name = "contentpanel";
      this.contentpanel.Size = new System.Drawing.Size(800, 375);
      this.contentpanel.TabIndex = 1;
      // 
      // Sidebarpanel
      // 
      this.Sidebarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
      this.Sidebarpanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Sidebarpanel.Location = new System.Drawing.Point(0, 0);
      this.Sidebarpanel.Name = "Sidebarpanel";
      this.Sidebarpanel.Size = new System.Drawing.Size(400, 375);
      this.Sidebarpanel.TabIndex = 2;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.Sidebarpanel);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel4.Location = new System.Drawing.Point(0, 75);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(400, 375);
      this.panel4.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(25, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(330, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "SCHOOL MANAGEMENT";
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.ControlBox = false;
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.contentpanel);
      this.Controls.Add(this.navbarpanel);
      this.Name = "Dashboard";
      this.Text = "Dashboard";
      this.navbarpanel.ResumeLayout(false);
      this.navbarpanel.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel navbarpanel;
    private System.Windows.Forms.Panel contentpanel;
    private System.Windows.Forms.Panel Sidebarpanel;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label1;
  }
}