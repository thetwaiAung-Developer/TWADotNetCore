﻿using System.Collections.Generic;

namespace  TWADotNetCore.MVC.Models
{
    public class HighChartBasicColumnChartModel
    {
        public List<List<int>> Data { get; set; }
        public List<string> Name { get; set; }
        public List<string> Categories { get; set; }
    }
}
