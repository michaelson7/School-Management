using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_school_management
{
  public partial class LoginForm : Dashboard
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private void materialSingleLineTextField1_Click(object sender, EventArgs e)
    {
      if (materialSingleLineTextField1.Text == "Enter Username")
      {
        materialSingleLineTextField1.Text = "";
        materialSingleLineTextField1.ForeColor = Color.Black;

      }
    }

    private void materialSingleLineTextField1_Leave(object sender, EventArgs e)
    {
      if (materialSingleLineTextField1.Text == "Enter Username")
      {
        materialSingleLineTextField1.Text = "";
        materialSingleLineTextField1.ForeColor = Color.Black;

      }

    }

    private void txtpassword_Click(object sender, EventArgs e)
    {
      if (txtpassword.Text == "Enter Password")
      {
        txtpassword.Text = "";
        txtpassword.ForeColor = Color.Black;
      }
      
    }

    private void txtpassword_Leave(object sender, EventArgs e)
    {
      if (txtpassword.Text == "Enter Password")
      {
        txtpassword.Text = "";
        txtpassword.ForeColor = Color.Silver;
      }
    }

    private void ShowPassword_CheckedChanged(object sender, EventArgs e)
    {
      if (ShowPassword.Checked)
      {
        txtpassword.UseSystemPasswordChar = false;
      }
      else
      {
        txtpassword.UseSystemPasswordChar = true;
      }
    }
  }
}
