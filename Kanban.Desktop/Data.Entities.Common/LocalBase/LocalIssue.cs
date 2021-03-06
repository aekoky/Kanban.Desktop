﻿using System;

namespace Data.Entities.Common.LocalBase
{
    public class LocalIssue
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public RowInfo Row { get; set; }
        public ColumnInfo Column { get; set; }
        public string Color { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
