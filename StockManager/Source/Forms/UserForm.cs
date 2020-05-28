﻿using StockManager.Source.Components;
using StockManager.Services.Source;
using StockManager.Database.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using StockManager.Source.UserControls;
using StockManager.Utilities.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Source.Forms {
  public partial class UserForm : Form {
    private int _userId = 0;
    private readonly UsersUserControl _usersUserControl;

    public UserForm(UsersUserControl usersUserControl) {
      InitializeComponent();
      _usersUserControl = usersUserControl;
      this.SetTranslatedPhrases();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      lbTitle.Text = Phrases.UserInfo;
      lbFirstName.Text = Phrases.GlobalUsername;
      lbPassword.Text = Phrases.GlobalPassword;
      lbRole.Text = Phrases.UserRole;
      btnCancel.Text = Phrases.GlobalCancel;
      btnSave.Text = Phrases.GlobalSave;
    }

    /// <summary>
    /// Show User Form and set the initial values
    /// </summary>
    public async Task ShowUserFormAsync(User user = null) {
      Spinner.InitSpinner();

      // Set the userId. Means that is a edit
      _userId = (user != null) ? user.UserId : 0;

      // Set the Form title
      this.Text = (_userId != 0)
        ? AppInfo.GetViewTitle(Phrases.UserEditUser)
        : AppInfo.GetViewTitle(Phrases.UserCreateNewUser);

      // hide the error labels
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      // Populate the combo box
      IEnumerable<Role> roles = await AppServices.RoleService.GetRolesAsync();
      cbRoles.DataSource = roles;
      cbRoles.ValueMember = "RoleId";
      cbRoles.DisplayMember = "Code";

      // Edit
      if (user != null) {
        tbUsername.Text = user.Username;
        cbRoles.SelectedItem = roles.First(x => x.RoleId == user.RoleId);
        cbRoles.Enabled = (user.UserId == Program.LoggedInUser.UserId) ? false : true;
      }

      Spinner.StopSpinner();
      this.ShowDialog();
    }

    /// <summary>
    /// Show the form errors, if any.
    /// </summary>
    private void ShowFormErrors(List<ErrorType> errors) {
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      foreach (ErrorType err in errors) {
        if (err.Field == "Username") {
          lbErrorUsername.Text = err.Error;
          lbErrorUsername.Visible = true;
        }

        if (err.Field == "Password") {
          lbErrorPassword.Text = err.Error;
          lbErrorPassword.Visible = true;
        }
      }
    }

    /// <summary>
    /// Create/Update button click
    /// </summary>
    private async void btnSave_Click(object sender, EventArgs e) {
      try {
        User user = new User {
          Username = tbUsername.Text,
          Password = tbPassword.Text,
          RoleId = int.Parse(cbRoles.SelectedValue.ToString())
        };

        Spinner.InitSpinner();

        if ((_userId != 0)) {
          user.UserId = _userId;
          await AppServices.UserService.EditUserAsync(user);
        } else {
          await AppServices.UserService.CreateUserAsync(user);
        }

        Spinner.StopSpinner();

        await _usersUserControl.LoadUsersAsync();

        this.Close();
      } catch (OperationErrorException ex) {
        Spinner.StopSpinner();

        if (ex.Errors.Count() > 0) {
          this.ShowFormErrors(ex.Errors);
        }
      }
    }

    /// <summary>
    /// Close button click
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
