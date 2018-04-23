using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace XtraMap_ShapefileDataAdapter {
    public partial class Form1 : Form {
        const string filename = "../../Data/Countries.shp";
        
        public Form1() {
            InitializeComponent();
            InitializeMap();
        }
                
        private void InitializeMap() {
            // Create a map and add it to the form.
            MapControl map = new MapControl() {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(map);

            // Create an adapter to load data from shapefile.
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);
            ShapefileDataAdapter adapter = new ShapefileDataAdapter() {
                FileUri = new Uri(baseUri, filename)
            };

            // Create a vector items layer and it to the map.
            VectorItemsLayer vectorLayer = new VectorItemsLayer() {
                Data = adapter
            };
            map.Layers.Add(vectorLayer);
        }
    }

}
