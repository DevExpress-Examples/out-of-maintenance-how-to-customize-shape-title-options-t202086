using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace ShapeTitleOptions {
    public partial class Form1 : Form {
        MapDot dot;
        
        public Form1() {
            InitializeComponent();
        }

        #region #TitleOptions
        private void Form1_Load(object sender, System.EventArgs e) {
            MapItemStorage storage = new MapItemStorage();
            VectorItemsLayer layer = new VectorItemsLayer() {
                Data = storage
            };

            dot = new MapDot() { Size = 100 };
            dot.TitleOptions.TextColor = Color.Orange;
            dot.TitleOptions.TextGlowColor = Color.Black;
            dot.TitleOptions.Pattern = "{Title}";

            dot.Attributes.Add(new MapItemAttribute() { Name = "Title", Value = "Hello,\nI am Dot." });
            storage.Items.Add(dot);

            mapControl1.Layers.Add(layer);
        }
        #endregion #TitleOptions

        #region #TitleVisibility
        private void cbTitleVisibility_CheckedChanged(object sender, System.EventArgs e) {
            if (cbTitleVisibility.Checked)
                dot.TitleOptions.Visibility = VisibilityMode.Visible;
            else
                dot.TitleOptions.Visibility = VisibilityMode.Hidden;
        }
        #endregion #TitleVisibility
    }
}
