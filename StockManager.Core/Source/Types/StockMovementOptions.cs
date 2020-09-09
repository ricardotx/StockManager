﻿using System;

namespace StockManager.Core.Source.Types
{
    public class StockMovementOptions
    {
        public string SearchValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
