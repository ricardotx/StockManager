﻿using StockManager.Database.Source.Models;
using StockManager.Translations.Source;
using System;

namespace StockManager.Source.Extensions
{
    public static class Extensions
    {
        public static string ConcatMovementString(this StockMovement stockMovement)
        {
            string fromLocation = (stockMovement.FromLocation != null)
               ? stockMovement.FromLocation.Name
               : stockMovement.FromLocationName;

            string toLocation = (stockMovement.ToLocation != null)
              ? stockMovement.ToLocation.Name
              : stockMovement.ToLocationName;

            string concat = $"{Phrases.StockMovementFrom}: {(fromLocation ?? "---")}"
              + Environment.NewLine
              + $"{Phrases.StockMovementTo}: {toLocation}";

            return concat;
        }

        public static string ShortDateWithTime(this DateTime? date)
        {
            if (date == null)
            {
                return "";
            }

            return date?.ToString("dd MMM yyyy, HH:mm:ss");
        }
    }
}