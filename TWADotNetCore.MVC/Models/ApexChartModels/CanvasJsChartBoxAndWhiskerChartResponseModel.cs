﻿using System.Collections.Generic;

namespace TWADotNetCore.MVC.Models
{
    public class CanvasJsChartBoxAndWhiskerChartResponseModel
	{
		public string XAxisTitle { get; set; }

		public string XAxisFormatting { get; set; }

		public string YAxisTitle { get; set;}

		public List<CanvasJsChartBoxAndWhiskerChartModel> Data {  get; set; }
	}
}
