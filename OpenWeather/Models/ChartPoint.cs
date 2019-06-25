using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenWeather.Models
{
    public class ChartPoint
    {

            public ChartPoint( int y, string label)
            {
                this.y = y;
                this.label = label;
            }

            public int y;
            public string label;

    }
}