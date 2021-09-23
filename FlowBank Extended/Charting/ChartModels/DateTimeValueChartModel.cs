using System;

namespace FlowBank_Extended.Charting.ChartModels
{
    public class DateTimeValueChartModel
    {
        public DateTime DateTime { get; set; }
        public double Value { get; set; }

        public DateTimeValueChartModel(DateTime dateTime, double value)
        {
            this.DateTime = dateTime;
            this.Value = value;
        }
    }
}
