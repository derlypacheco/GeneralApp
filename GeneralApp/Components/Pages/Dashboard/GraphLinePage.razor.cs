using System.Globalization;

namespace GeneralApp.Components.Pages.Dashboard
{
    public partial class GraphLinePage
    {
        bool smooth = false;
        bool showDataLabels = false;
        bool showMarkers = true;

        private class DataItem
        {
            public string Date { get; set; }
            public double Revenue { get; set; }
        }

        string FormatAsUSD(object value)
        {
            return ((double)value).ToString("C0", CultureInfo.CreateSpecificCulture("en-US"));
        }

        DataItem[] revenue2023 = new DataItem[] {
    new DataItem
    {
    Date = "Jan",
    Revenue = 234000
    },
    new DataItem
    {
    Date = "Feb",
    Revenue = 269000
    },
    new DataItem
    {
    Date = "Mar",
    Revenue = 233000
    },
    new DataItem
    {
    Date = "Apr",
    Revenue = 244000
    },
    new DataItem
    {
    Date = "May",
    Revenue = 214000
    },
    new DataItem
    {
    Date = "Jun",
    Revenue = 253000
    },
    new DataItem
    {
    Date = "Jul",
    Revenue = 274000
    },
    new DataItem
    {
    Date = "Aug",
    Revenue = 284000
    },
    new DataItem
    {
    Date = "Sept",
    Revenue = 273000
    },
    new DataItem
    {
    Date = "Oct",
    Revenue = 282000
    },
    new DataItem
    {
    Date = "Nov",
    Revenue = 289000
    },
    new DataItem
    {
    Date = "Dec",
    Revenue = 294000
    }
    };

        DataItem[] revenue2024 = new DataItem[] {
    new DataItem
    {
    Date = "Jan",
    Revenue = 334000
    },
    new DataItem
    {
    Date = "Feb",
    Revenue = 369000
    },
    new DataItem
    {
    Date = "Mar",
    Revenue = 333000
    },
    new DataItem
    {
    Date = "Apr",
    Revenue = 344000
    },
    new DataItem
    {
    Date = "May",
    Revenue = 314000
    },
    new DataItem
    {
    Date = "Jun",
    Revenue = 353000
    },
    new DataItem
    {
    Date = "Jul",
    Revenue = 374000
    },
    new DataItem
    {
    Date = "Aug",
    Revenue = 384000
    },
    new DataItem
    {
    Date = "Sept",
    Revenue = 373000
    },
    new DataItem
    {
    Date = "Oct",
    Revenue = 382000
    },
    new DataItem
    {
    Date = "Nov",
    Revenue = 389000
    },
    new DataItem
    {
    Date = "Dec",
    Revenue = 394000
    }
    };

    }
}