﻿using System.Collections.Generic;

namespace TWADotNetCore.MVC.Models
{
    public class ChartJsRadarChartModel
    {
        public List<int> Data { get; set; }
        public List<string> Labels { get; set; }
        public List<int> SecondDataSet { get; set; }
    }
}
