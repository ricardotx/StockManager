﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class SettingsUc : UserControl
    {
        private AppSettings _appSettings;
        private bool _flagIsRestartRequired;

        public SettingsUc()
        {
            InitializeComponent();

            _flagIsRestartRequired = false;

            SetTranslatedPhrases();
            LoadSettingsAsync().Wait();

        }

        private void SetTranslatedPhrases()
        {
            btnSave.Text = Phrases.GlobalSave;
            btnCancel.Text = Phrases.GlobalCancel;

            lbLanguage.Text = Phrases.GlobalLanguage;
            lbLanguageWarning.Text = $"*{Phrases.AppSettingRestartRequired}";

            lbDefaultGlobalMinStock.Text = Phrases.AppSettingsDefaultGlobalMinStock;
            lbDefaultGlobalMinStockWarning.Text = $"*{Phrases.AppSettingsOnlyAppliedToNewProducts}";
        }

        private async Task LoadSettingsAsync()
        {
            Spinner.InitSpinner();

            _appSettings = await AppServices.AppSettingsService.GetAppSettingsAsync();

            // Populate the language combo
            cbLanguage.DataSource = AppConstants.AppLanguages;
            cbLanguage.ValueMember = "Code";
            cbLanguage.DisplayMember = "Name";
            cbLanguage.SelectedItem = AppConstants.AppLanguages.FirstOrDefault(x => x.Code == _appSettings.Language);

            // Global default min stock
            numDefaultGlobalMinStock.Value = ( decimal )_appSettings.DefaultGlobalMinStock;

            Spinner.StopSpinner();
        }

        private void cbLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedLanguage = cbLanguage.SelectedValue.ToString();
            _flagIsRestartRequired = (selectedLanguage != _appSettings.Language);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                AppSettings appSettings = new AppSettings
                {
                    AppSettingsId = _appSettings.AppSettingsId,
                    Language = cbLanguage.SelectedValue.ToString(),
                    DefaultGlobalMinStock = float.Parse(numDefaultGlobalMinStock.Value.ToString())
                };

                await AppServices.AppSettingsService.UpdateAppSettingsAsync(appSettings);

                Spinner.StopSpinner();

                if (_flagIsRestartRequired)
                {
                    // Show msg box to the user asking if he want to restart de app for the changes take effect
                    if (MessageBox.Show(
                        Phrases.AppSettingsDialogRestartBody,
                        Phrases.AppSettingsDialogRestartTitle,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes
                    )
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                // Reload the settings
                await LoadSettingsAsync();

                // Show success msg box
                MessageBox.Show(
                 Phrases.AppSettingsDialogSuccessBody,
                  Phrases.AppSettingsDialogSuccessTitle,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
                );
            }
            catch (ServiceErrorException ex)
            {
                Spinner.StopSpinner();

                MessageBox.Show(
                  $"{ex.Errors[0].Error}",
                  Phrases.GlobalDialogErrorTitle,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Phrases.GlobalDialogDeleteTitle,
                Phrases.AppSettingsDialogCancelChangesTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes
            )
            {
                // Reset the flag
                _flagIsRestartRequired = false;

                await LoadSettingsAsync();
            }
        }
    }
}
