﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

using StockManager.Core.Source;
using StockManager.Core.Source.Extensions;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;
using StockManager.Core.Source.Types;

namespace StockManager.Services.Source.Services
{
    public class PdfService : IPdfService
    {
        private readonly IAppRepository _repository;
        private const float _documentDefaultfontSize = 8;

        public PdfService(IAppRepository repository)
        {
            _repository = repository;
        }

        public void ExportStockMovementsToPdfAsync(ExportData<IEnumerable<StockMovement>, StockMovementOptions> data)
        {
            IEnumerable<StockMovement> movements = data.Data;
            StockMovementOptions options = data?.Options;

            Document document = CreateDocument();
            Section section = document.AddSection();
            SetSectionStyles(section);
            SetPageFooter(section);

            // Set title
            AddParagraph(section, "Stock movements", true, 16); // TODO: change this

            if (options != null) // TODO: Verify if the dates are sent
            {
                AddParagraph(section, $"{options.StartDate.ShortDate()} - {options.EndDate.ShortDate()}", false, null, 2); // TODO: change this
            }

            // Define table and table columns
            Table table = CreateTable();
            AddTableColumn(table, ParagraphAlignment.Left);
            AddTableColumn(table, ParagraphAlignment.Left);
            AddTableColumn(table, ParagraphAlignment.Left);
            AddTableColumn(table, ParagraphAlignment.Left);
            AddTableColumn(table, ParagraphAlignment.Center);
            AddTableColumn(table, ParagraphAlignment.Center);
            AddTableColumn(table, ParagraphAlignment.Left);

            // Define table header
            Row row = table.AddRow();
            AddTableRowCell(row, 0, ParagraphAlignment.Left, "Date", true); // TODO: change this
            AddTableRowCell(row, 1, ParagraphAlignment.Left, "Reference", true);
            AddTableRowCell(row, 2, ParagraphAlignment.Left, "Name", true);
            AddTableRowCell(row, 3, ParagraphAlignment.Left, "Movement", true);
            AddTableRowCell(row, 4, ParagraphAlignment.Center, "Qty", true);
            AddTableRowCell(row, 5, ParagraphAlignment.Center, "Stock acc.", true);
            AddTableRowCell(row, 6, ParagraphAlignment.Left, "User", true);

            // Populate the table rows
            movements.ToList().ForEach((movement) => {
                row = table.AddRow();
                AddTableRowCell(row, 0, ParagraphAlignment.Left, movement.CreatedAt.ShortDateWithTime());
                AddTableRowCell(row, 1, ParagraphAlignment.Left, movement.Product.Reference);
                AddTableRowCell(row, 2, ParagraphAlignment.Left, movement.Product.Name);
                AddTableRowCell(row, 3, ParagraphAlignment.Left, movement.ConcatMovementString());
                AddTableRowCell(row, 4, ParagraphAlignment.Center, movement.Qty.ToString());
                AddTableRowCell(row, 5, ParagraphAlignment.Center, movement.Stock.ToString());
                AddTableRowCell(row, 6, ParagraphAlignment.Left, movement.User.Username);
            });

            // Add the table to the document
            document.LastSection.Add(table);

            // Rendering the document
            RenderAndShowPdf(document);
        }

        private Document CreateDocument()
        {
            Document document = new Document();
            Style style = document.Styles.Normal;
            style.Font.Name = "Arial";
            style.Font.Size = _documentDefaultfontSize;

            return document;
        }

        private void SetSectionStyles(Section section)
        {
            section.PageSetup.PageFormat = PageFormat.A4;
            section.PageSetup.Orientation = Orientation.Portrait;
            section.PageSetup.TopMargin = Unit.FromCentimeter(1);
            section.PageSetup.BottomMargin = Unit.FromCentimeter(1);
        }

        private void SetPageFooter(Section section)
        {
            // http://www.pdfsharp.net/wiki/MigraDoc_PageSetup.ashx?HL=oddandevenpagesheaderfooter
            section.PageSetup.OddAndEvenPagesHeaderFooter = true;
            section.PageSetup.StartingNumber = 1;

            // Footer
            Paragraph footerText = new Paragraph();
            footerText.AddText("Stock manager v.0.0.1"); // TODO: get from AppInfo and add DateTime
            footerText.Format.Font.Size = 6;
            footerText.Format.Alignment = ParagraphAlignment.Left;
            footerText.Format.Font.Italic = true;
            footerText.Format.Font.Color = Colors.LightGray;

            Paragraph footerPage = new Paragraph();
            footerPage.Format.Font.Size = 8;
            footerPage.Format.Alignment = ParagraphAlignment.Right;
            footerPage.Format.Font.Italic = false;
            footerPage.AddTab();
            footerPage.AddPageField();

            section.Footers.Primary.Add(footerText);
            section.Footers.Primary.Add(footerPage);
            section.Footers.EvenPage.Add(footerText.Clone());
            section.Footers.EvenPage.Add(footerPage.Clone());
        }

        private void AddParagraph(Section section, string text, bool bold = false, float? fontSize = null, float? spaceAfter = null)
        {
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(text);
            paragraph.Format.Font.Size = fontSize ?? _documentDefaultfontSize;
            paragraph.Format.Font.Bold = bold;

            if (spaceAfter != null)
            {
                paragraph.Format.SpaceAfter = Unit.FromCentimeter(( double )spaceAfter);
            }

            section.Add(paragraph);
        }

        private Table CreateTable()
        {
            Table table = new Table { Style = "Table" };
            table.TopPadding = 2;
            table.BottomPadding = 2;
            table.Borders.Bottom.Color = Colors.LightGray;
            table.Borders.Bottom.Width = 0.5;

            return table;
        }

        private void AddTableColumn(Table table, ParagraphAlignment alignment)
        {
            Column column = table.AddColumn();
            column.Format.Alignment = alignment;
        }

        private void AddTableRowCell(Row row, int index, ParagraphAlignment alignment, string text, bool bold = false)
        {
            row.Cells[index].AddParagraph(text);
            row.Cells[index].Format.Font.Bold = bold;
            row.Cells[index].Format.Alignment = alignment;
            row.Cells[index].VerticalAlignment = VerticalAlignment.Center;
        }

        private void RenderAndShowPdf(Document document)
        {
            // Rendering the document
            PdfDocumentRenderer documentRenderer = new PdfDocumentRenderer(false) { Document = document };
            documentRenderer.RenderDocument();

            // Open file
            string filename = $"StockMovements_{DateTime.Now.FileNameDateTime()}.pdf"; // TODO: Change this
            documentRenderer.PdfDocument.Save(filename);

            // Show the pdf
            Process.Start(filename);
        }
    }
}
