﻿using System;
using System.Text.Json.Serialization;

namespace TTConfTool.Shared.DTO
{
    public class Media
    {
        public MediaType Type { get; set; }
        public Uri Url { get; set; }
        public string Label { get; set; }
    }
}
