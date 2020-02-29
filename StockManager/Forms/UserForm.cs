﻿using StockManager.Storage.Models;
using StockManager.Types;
using StockManager.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class UserForm : Form
  {
    private int userId = 0;
    private readonly UsersUserControl usersUserControl;

    public UserForm(UsersUserControl usersUserControl)
    {
      InitializeComponent();
      this.usersUserControl = usersUserControl;
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
    /// Show User Form and set the initial values
    /// </summary>
    public async Task ShowUserForm(User user = null)
    {
      this.InitSpinner();

      // Set the userId. Means that is a edit
      this.userId = (user != null) ? user.UserId : 0;

      // Set the Form title
      this.Text = (this.userId != 0)
        ? "Stock Manager | Edit user"
        : "Stock Manager | Create new user";

      // hide the error labels
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      // Populate the combo box
      IEnumerable<Role> roles = await Program.RoleService.GetRolesAsync();
      cbRoles.DataSource = roles;
      cbRoles.ValueMember = "RoleId";
      cbRoles.DisplayMember = "Code";

      // Edit
      if (user != null)
      {
        tbUsername.Text = user.Username;
        cbRoles.SelectedItem = roles.First(x => x.RoleId == user.RoleId);
        cbRoles.Enabled = (user.UserId == Program.LoggedInUser.UserId) ? false : true;
      }

      this.StopSpinner();
      this.ShowDialog();
    }

    /// <summary>
    /// Show the form errors, if any.
    /// </summary>
    private void ShowFormErrors(List<ErrorType> errors)
    {
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      foreach (var err in errors)
      {
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
    /// Create/Update button click
    /// </summary>
    private void btnSave_Click(object sender, EventArgs e)
    {
      User user = new User();
      user.Username = tbUsername.Text;
      user.Password = tbPassword.Text;
      user.RoleId = int.Parse(cbRoles.SelectedValue.ToString());

      List<ErrorType> errors = (this.userId != 0)
        ? Program.UserServices.UpdateUser(this.userId, user)
        : Program.UserServices.CreateUser(user);

      if (errors.Count == 0)
      {
        this.usersUserControl.LoadUsers();
        this.Close();
      }
      else
      {
        this.ShowFormErrors(errors);
      }
    }

    /// <summary>
    /// Close button click
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
