using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.Entry;

namespace XamarinCharts
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                Label = "January",
                ValueLabel ="200"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#00BFFF"),
                Label = "February",
                ValueLabel ="400"
            },
            new Entry(-100)
            {
                Color = SKColor.Parse("#00CED1"),
                Label = "March",
                ValueLabel ="-100"
            }
        };
        public MainPage()
        {
            InitializeComponent();
            //Chart1.Chart = new RadialGaugeChart { Entries = entries };
            Chart1.Chart = new BarChart { Entries = entries };
            //Chart1.Chart = new DonutChart { Entries = entries };
            //Chart1.Chart = new PointChart { Entries = entries };
            //Chart1.Chart = new LineChart { Entries = entries };
            //Chart1.Chart = new RadialGaugeChart { Entries = entries };
        }
    }
}
