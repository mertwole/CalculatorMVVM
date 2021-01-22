using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Calculator.NeumorphismControls
{
    public partial class NeumorphismPanelOuterShadow : UserControl
    {
    // Corners.
        CornerRadius cornerRadius = new CornerRadius(50.0);
        public CornerRadius CornerRadius { get => cornerRadius; set => cornerRadius = value; }
    // Light shadow.
        Color lightShadowColor = Color.FromRgb(0xFF, 0xFF, 0xFF);
        public Color LightShadowColor { get => lightShadowColor; set => lightShadowColor = value; }
        double lightShadowOpacity = 0.5;
        public double LightShadowOpacity { get => lightShadowOpacity; set => lightShadowOpacity = value; }
    // Dark shadow.
        Color darkShadowColor = Color.FromRgb(0x00, 0x00, 0x00);
        public Color DarkShadowColor { get => darkShadowColor; set => darkShadowColor = value; }
        double darkShadowOpacity = 0.2;
        public double DarkShadowOpacity { get => darkShadowOpacity; set => darkShadowOpacity = value; }
    // Shadow direction.
        double darkShadowDirection = 315.0;
        double lightShadowDirection = 135.0;
        public double ShadowDirection { set { darkShadowDirection = value; lightShadowDirection = value - 180.0; } }
        public double LightShadowDirection { get => lightShadowDirection; }
        public double DarkShadowDirection { get => darkShadowDirection; }
    // Shadow depth.
        public static readonly DependencyProperty ShadowDepthProperty =
        DependencyProperty.Register(
        "ShadowDepth", typeof(double),
        typeof(NeumorphismPanelOuterShadow),
        new UIPropertyMetadata(10.0)
        );
        public double ShadowDepth
        {
            get { return (double)GetValue(ShadowDepthProperty); }
            set { SetValue(ShadowDepthProperty, value); }
        }
    // Shadow blur.
        public static readonly DependencyProperty ShadowBlurProperty =
        DependencyProperty.Register(
        "ShadowBlur", typeof(double),
        typeof(NeumorphismPanelOuterShadow),
        new UIPropertyMetadata(20.0)
        );
        public double ShadowBlur
        {
            get { return (double)GetValue(ShadowBlurProperty); }
            set { SetValue(ShadowBlurProperty, value); }
        }
    // Color.
        Color color = Color.FromRgb(0xEA, 0xE9, 0xFF);
        public Color Color { get => color; set => color = value; }

        public NeumorphismPanelOuterShadow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
