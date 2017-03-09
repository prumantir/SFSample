using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using SFSample.Models;
using Syncfusion.JavaScript.Web; 
using Syncfusion.JavaScript.Shared.Serializer;
using System.ComponentModel;
using Syncfusion.JavaScript.DataVisualization.HeatMapEnums;
namespace SFSample
{
    public partial class HeatMapController: Controller
    {
                public ActionResult HeatMapFeatures()
        {
            HeatMapProperties Heatmap = new HeatMapProperties();
            List<HeatMapColorMapping> colorCollection = new List<HeatMapColorMapping>();
            colorCollection.Add(new HeatMapColorMapping() { Color = "#0080FF", Label = new HeatMapLabel() { Text = "0" }, Value = 0 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#8181F7", Label = new HeatMapLabel() { Text = "10" }, Value = 10 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#81DAF5", Label = new HeatMapLabel() { Text = "20" }, Value = 20 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#81F7BE", Label = new HeatMapLabel() { Text = "30" }, Value = 30 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#81F781", Label = new HeatMapLabel() { Text = "40" }, Value = 40 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#BEF781", Label = new HeatMapLabel() { Text = "50" }, Value = 50 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#F3F781", Label = new HeatMapLabel() { Text = "60" }, Value = 60 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#F7BE81", Label = new HeatMapLabel() { Text = "70" }, Value = 70 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#F78181", Label = new HeatMapLabel() { Text = "80" }, Value = 80 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#FE642E", Label = new HeatMapLabel() { Text = "90" }, Value = 90 });
            colorCollection.Add(new HeatMapColorMapping() { Color = "#2EFE2E", Label = new HeatMapLabel() { Text = "100" }, Value = 100 });
            Heatmap.ColorMappingCollection = colorCollection;
            Heatmap.IsResponsive = false;
            Heatmap.LegendCollection.Add("heatmapLegend");
            Heatmap.HeatMapCell.ShowColor = true;
            Heatmap.HeatMapCell.ShowContent = HeatMapCellVisibility.Visible;
            Heatmap.Width = "auto";
            Heatmap.Height = "auto";
            CellMapping CellMapping = new CellMapping();
            CellMapping.Column = new PropertyMapping() { PropertyName = "ProductName", DisplayName = "Product Name" };
            CellMapping.Row = new PropertyMapping() { PropertyName = "Year", DisplayName = "Year" };
            CellMapping.Value = new PropertyMapping() { PropertyName = "Value" };
            Collection columnMapping = new Collection();
            columnMapping.Add(new HeaderMapping() { PropertyName = "Vegie-spread", DisplayName = "Vegie-spread", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Left, Width = 200 } });
            columnMapping.Add(new HeaderMapping() { PropertyName = "Tofuaa", DisplayName = "Vegie-spread", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Left, Width = 200 } });
            columnMapping.Add(new HeaderMapping() { PropertyName = "Alice Mutton", DisplayName = "Vegie-spread", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Left, Width = 200 } });
            columnMapping.Add(new HeaderMapping() { PropertyName = "Konbu", DisplayName = "Vegie-spread", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Left, Width = 200 } });
            columnMapping.Add(new HeaderMapping() { PropertyName = "Fløtemysost", DisplayName = "Vegie-spread", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Left, Width = 200 } });
            columnMapping.Add(new HeaderMapping() { PropertyName = "Perth Pasties", DisplayName = "Vegie-spread", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Left, Width = 200 } });
            CellMapping.ColumnMapping = columnMapping;
            HeaderMapping headerMapping = new HeaderMapping() { PropertyName = "Year", DisplayName = "Year", ColumnStyle = new ColumnStyle() { TextAlign = HeatMapTextAlign.Left, Width = 200 } };
            CellMapping.HeaderMapping = headerMapping;
            Heatmap.ItemsSource = GetRowSource();
            Heatmap.ItemsMapping = CellMapping;
            ViewData["heatmapModel"] = Heatmap;
            HeatMapLegendProperties legend = new HeatMapLegendProperties();
            legend.ColorMappingCollection = colorCollection;
            legend.Orientation = HeatMapLegendOrientation.Horizontal;
            legend.LegendMode = Syncfusion.JavaScript.DataVisualization.HeatMapEnums.HeatMapLegendMode.Gradient;
            legend.Height = "50px";
            legend.Width = "100%";
            ViewData["heatmapLegendModel"] = legend;
            return View();
        }
        public Collection GetRowSource()
        {
            Collection collection = new Collection();
            string[] name = { "Vegie-spread", "Tofuaa", "Alice Mutton", "Konbu", "Fløtemysost", "Perth Pasties" };
            Random random = new Random();
            Random random1 = new Random();
            foreach (string item in name)
            {
                for (int i = 0; i < 10; i++)
                {
                    double value = random.Next(0, random1.Next(0, 100));
                    collection.Add(new SampleCellData() { ProductName = item, Year = 2011 + i, Value = value });
                }
            }
            return collection;
        }
    }
    [Serializable]
    public class SampleCellData
    {
        private string productName;
        [JsonProperty("ProductName")]
        [DefaultValue("")]
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private Double year;
        [JsonProperty("Year")]
        [DefaultValue("")]
        public Double Year
        {
            get { return year; }
            set { year = value; }
        }
        private Double valuex;
        [JsonProperty("Value")]
        [DefaultValue("")]
        public Double Value
        {
            get { return valuex; }
            set { valuex = value; }
        }
    }
}
