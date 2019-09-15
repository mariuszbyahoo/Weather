﻿using System;

namespace Weather.Core
{
    public class WeatherModel
    {
        public string Location { get; set; }
        public double Temperature { get; set; }

        public WeatherModel(string location)
        {
            Location = location;
        }
    }
}
