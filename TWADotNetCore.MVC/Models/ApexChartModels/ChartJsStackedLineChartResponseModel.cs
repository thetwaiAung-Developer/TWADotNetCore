﻿using System.Collections.Generic;

namespace TWADotNetCore.MVC.Models
{
    public class ChartJsStackedLineChartResponseModel
    {
        public List<string> Labels { get; set; }
        public List<ChartJsStackedLineChartModel> Datasets { get; set; }
    }
}