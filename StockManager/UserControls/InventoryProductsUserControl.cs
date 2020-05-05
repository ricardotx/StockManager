﻿using StockManager.Components;
using StockManager.Forms;
using StockManager.Services;
using StockManager.Storage.Models;
using StockManager.Translations.Source;
using StockManager.Types.Types;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.UserControls {
  public partial class InventoryProductsUserControl : UserControl {
    public InventoryProductsUserControl() {
      InitializeComponent();

      // Hide the X button on the search textbox
      btnClearSearchValue.Visible = false;
      this.SetTranslatedPhrases();
      this.LoadProductsAsync().Wait();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      btnCreate.Text = Phrases.GlobalCreate;
      btnEdit.Text = Phrases.GlobalEdit;
      btnDelete.Text = Phrases.GlobalDelete;
      dgvProducts.Columns[1].HeaderText = Phrases.GlobalReference;
      dgvProducts.Columns[2].HeaderText = Phrases.GlobalName;
      dgvProducts.Columns[3].HeaderText = Phrases.GlobalStock;
      dgvProducts.Columns[4].HeaderText = Phrases.GlobalCreatedAt;
    }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public async Task LoadProductsAsync(string searchValue = null) {
      Spinner.InitSpinner();
      dgvProducts.Rows.Clear();

      IEnumerable<Product> products = await AppServices.ProductService
        .GetProductsAsync(searchValue);

      foreach (Product product in products) {
        dgvProducts.Rows.Add(
          product.ProductId,
          product.Reference,
          product.Name,
          product.Stock,
          product.CreatedAt?.ToString("MM/dd/yyyy HH:mm:ss")
        );
      }

      Spinner.StopSpinner();
    }

    /// <summary>
    /// Create product button click
    /// </summary>
    private void btnCreate_Click(object sender, EventArgs e) {
      ProductForm productForm = new ProductForm(this);
      productForm.ShowProductForm();
    }

    /// <summary>
    /// Edit product button click
    /// </summary>
    private async void btnEdit_Click(object sender, EventArgs e) {
      if (dgvProducts.SelectedRows.Count > 0) {
        Spinner.InitSpinner();

        Product product = await AppServices.ProductService
          .GetProductByIdAsync(int.Parse(dgvProducts.SelectedRows[0].Cells[0].Value.ToString()));

        Spinner.StopSpinner();

        ProductForm productForm = new ProductForm(this);
        productForm.ShowProductForm(product);
      }
    }

    /// <summary>
    /// Delete product button click
    /// </summary>
    private async void btnDelete_Click(object sender, EventArgs e) {
      DataGridViewSelectedRowCollection selectedProducts = dgvProducts.SelectedRows;

      if ((selectedProducts.Count > 0) && MessageBox.Show(
        string.Format(Phrases.ProductDialogDeleteBody, selectedProducts.Count),
        Phrases.GlobalDialogDeleteTitle,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
      ) {
        try {
          Spinner.InitSpinner();

          int[] productIds = new int[selectedProducts.Count];

          for (int i = 0; i < selectedProducts.Count; i++) {
            productIds[i] = int.Parse(selectedProducts[i].Cells[0].Value.ToString());
          }

          await AppServices.ProductService.DeleteProductAsync(productIds);

          Spinner.StopSpinner();
          await this.LoadProductsAsync();

        } catch (OperationErrorException ex) {
          Spinner.StopSpinner();

          MessageBox.Show(
            $"{ex.Errors[0].Error}",
            Phrases.GlobalDialogWarningTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
          );

        } catch (ServiceErrorException ex) {
          Spinner.StopSpinner();

          MessageBox.Show(
            $"{ex.Errors[0].Error}",
            Phrases.GlobalDialogErrorTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
          );
        }
      }
    }

    /// <summary>
    /// Search button click
    /// </summary>
    private async void pbSearchIcon_Click(object sender, EventArgs e) {
      string searchValue = tbSeachText.Text;

      if (!string.IsNullOrEmpty(searchValue)) {
        await this.LoadProductsAsync(searchValue);
      }
    }

    /// <summary>
    /// Clear search value picture box click
    /// </summary>
    private async void btnClearSearchValue_Click(object sender, EventArgs e) {
      tbSeachText.Text = "";
      await this.LoadProductsAsync();
    }

    /// <summary>
    /// Call search button click when pressed enter in the textbox
    /// </summary>
    private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == (char)Keys.Enter) {
        this.pbSearchIcon_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      } else if (e.KeyChar == (char)Keys.Escape) {
        this.btnClearSearchValue_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }

    /// <summary>
    /// Show/Hide the X button on the search textbox
    /// </summary>
    private void tbSeachText_TextChanged(object sender, EventArgs e) {
      btnClearSearchValue.Visible = (tbSeachText.Text.Length > 0);
    }
  }
}
