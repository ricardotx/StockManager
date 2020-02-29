﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Types;
using StockManager.Forms;
using StockManager.Storage.Models;

namespace StockManager.UserControls
{
  public partial class LoginUserControl : UserControl
  {
    private readonly MainForm mainForm;

    public LoginUserControl(MainForm mainForm)
    {
      InitializeComponent();
      this.mainForm = mainForm;

      // hide the error labels
      lbErrorGeneric.Visible = false;
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
    }

    /// <summary>  
    /// Init the loading spinner  
    /// </summary>  
    private void InitSpinner() { Cursor.Current = Cursors.WaitCursor; }
    /// <summary>  
    /// Stop the loading spinner  
    /// </summary>  
    private void StopSpinner() { Cursor.Current = Cursors.Default; }

    /// <summary>
    /// Set the form errors
    /// </summary>
    private void SetFormErrors(List<ErrorType> errors)
    {
      lbErrorGeneric.Visible = false;
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      foreach (var err in errors)
      {
        if (err.Field == "Generic")
        {
          lbErrorGeneric.Text = err.Error;
          lbErrorGeneric.Visible = true;
        }

        if (err.Field == "Username")
        {
          lbErrorUsername.Text = err.Error;
          lbErrorUsername.Visible = true;
        }

        if (err.Field == "Password")
        {
          lbErrorPassword.Text = err.Error;
          lbErrorPassword.Visible = true;
        }
      }
    }

    /// <summary>
    /// Clean all the form content
    /// </summary>
    private void btnClean_Click(object sender, EventArgs e)
    {
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
      tbUsername.Text = "";
      tbPassword.Text = "";
    }

    /// <summary>
    /// Login button click
    /// </summary>
    private async void btnLogin_Click(object sender, EventArgs e)
    {
      try
      {
        this.InitSpinner();

        User user = await Program.UserService
          .AuthenticateAsync(tbUsername.Text, tbPassword.Text);

        this.StopSpinner();

        Program.SetLoggedInUser(user);
        mainForm.SetUi();
      }
      catch (OperationErrorException ex)
      {
        this.SetFormErrors(ex.Errors);
      }
    }

    /// <summary>
    /// Call Login button click when pressed enter in the password textbox
    /// </summary>
    private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        this.btnLogin_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }
  }
}
