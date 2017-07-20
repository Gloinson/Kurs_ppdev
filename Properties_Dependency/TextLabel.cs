using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Properties_Dependency
{
    public class TextLabel : FrameworkElement
    {
        public static readonly DependencyProperty TextProperty;
        public static readonly DependencyProperty FontSizeProperty;
        private const double padding = 5;

        static TextLabel()
        {
            TextProperty = DependencyProperty.Register(
                "Text",
                typeof(string),
                typeof(TextLabel),
                new FrameworkPropertyMetadata(
                    defaultValue: string.Empty,
                    flags: FrameworkPropertyMetadataOptions.AffectsMeasure |
                           FrameworkPropertyMetadataOptions.AffectsRender));
            FontSizeProperty = DependencyProperty.Register(
                "FontSize",
                typeof(double),
                typeof(TextLabel),
                new FrameworkPropertyMetadata(
                    defaultValue: 11.0,
                    flags: FrameworkPropertyMetadataOptions.AffectsMeasure),
                validateValueCallback: (v => (double)v > 0));
        }

        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }

        public double FontSize
        {
            get
            {
                return (double)GetValue(FontSizeProperty);
            }
            set
            {
                SetValue(FontSizeProperty, value);
            }
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            var text = GetFormattedText();
            return new Size(text.Width + padding, text.Height + padding);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            drawingContext.DrawRectangle(
                Brushes.LightGray,
                null,
                new Rect(RenderSize)); // <- RenderSize is calculated based on MeasureOverride
            drawingContext.DrawText(
                GetFormattedText(),
                new Point(padding / 2, padding / 2));
        }

        private FormattedText GetFormattedText()
        {
            return new FormattedText(
              Text,
              CultureInfo.InvariantCulture,
              FlowDirection.LeftToRight,
              new Typeface("Calibre"),
              FontSize,
              Brushes.Black);
        }
    }
}
