using Radzen;

namespace GeneralApp.Components.Pages.Dashboard
{
    public partial class GrapPiePage
    {
        bool showDataLabels = true;

        void OnSeriesClick(SeriesClickEventArgs args)
        {
            //console.Log(args);
        }

        private class DataItem
        {
            public string Quarter { get; set; }
            public double Revenue { get; set; }
        }

        DataItem[] revenue = new DataItem[] {
        new DataItem
        {
            Quarter = "Q1",
            Revenue = 30000
        },
        new DataItem
        {
            Quarter = "Q2",
            Revenue = 40000
        },
        new DataItem
        {
            Quarter = "Q3",
            Revenue = 50000
        },
        new DataItem
        {
            Quarter = "Q4",
            Revenue = 80000
        },
    };
    }
}