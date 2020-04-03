using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using static RichXml.Helpers.ColorHelper;

namespace RichXml
{
    public partial class MainWindow : Window
    {
        public void SetForeground(RichTextBox rtb, int start, int end, Brush brush)
        {
            var doc = rtb.Document;
            TextPointer _start = doc.ContentStart.GetPositionAtOffset(start + 2);
            TextPointer _end = doc.ContentStart.GetPositionAtOffset(end + 2);

            TextRange tRange = new TextRange(_start, _end);
            tRange.ApplyPropertyValue(TextElement.ForegroundProperty, brush);
        }

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += (s, e) => {
                var doc = this.docBox.Document;
                TextRange tRange = new TextRange(doc.ContentStart, doc.ContentEnd);
                tRange.Text = "1234567890";

                var brush = new SolidColorBrush(FromHex("#FF0000"));
                SetForeground(this.docBox, 3, 8, brush);
            };
        }
    }
}
