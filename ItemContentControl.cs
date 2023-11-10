using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.Foundation;

namespace WinUIPlayground
{
    internal class ItemContentControl : ContentControl
    {
        private bool _didSetContent = false;

        public static readonly DependencyProperty FormsContainerProperty = DependencyProperty.Register(
            nameof(FormsContainer), typeof(string), typeof(ItemContentControl),
            new PropertyMetadata(default(string), FormsContainerChanged));

        static void FormsContainerChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var formsContentControl = (ItemContentControl)d;
            formsContentControl.Realize();
        }

        public string FormsContainer
        {
            get => (string)GetValue(FormsContainerProperty);
            set => SetValue(FormsContainerProperty, value);
        }

        internal void Realize()
        {
            if (_didSetContent)
                return;

            _didSetContent = true;
            Content = new TextBlock() { Text = "Hello World" };
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            if (_didSetContent == false)
            {
                return base.MeasureOverride(availableSize);
            }

            var measuredSize = base.MeasureOverride(availableSize);
            var frameworkElement = Content as FrameworkElement;
            frameworkElement.Measure(measuredSize);
            return measuredSize;
        }
    }
}