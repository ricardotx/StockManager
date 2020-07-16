﻿using System;
using System.Collections.Generic;

namespace StockManager.Types.Source
{
    public class OperationErrorException : ArgumentException
    {
        public OperationErrorException(OperationErrorsList operationErrors)
        {
            this.Errors = operationErrors.ErrorsList;
        }

        public List<ErrorType> Errors { get; private set; }
    }
}
