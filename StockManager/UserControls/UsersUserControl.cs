﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.UserControls
{
  public partial class UsersUserControl : UserControl
  {
    public UsersUserControl()
    {
      InitializeComponent();
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
      Program.userForm.ShowUserForm();
    }
  }
}
