using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Properties_Dependency
{
    class TextLabel : FrameworkElement
    {
        public static readonly DependencyProperty TextProperty;
        public static readonly DependencyProperty FontSizeProperty;

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
                "Fontsize",
                typeof(double),
                typeof(TextLabel),
                new FrameworkPropertyMetadata(
                    defaultValue: string.Empty,
                    flags: FrameworkPropertyMetadataOptions.AffectsMeasure |
                           FrameworkPropertyMetadataOptions.AffectsRender));
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
    }
}
