﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class UserForm : Form
  {
    public UserForm()
    {
      InitializeComponent();
    }

    public void ShowUserForm()
    {
      this.ShowDialog();
    }
  }
}
