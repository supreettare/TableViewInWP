using Microsoft.Phone.Controls;
using System.Windows.Media;
using TableViewinWP.CustomControls;
using TableViewinWP.WinPhone;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessEntryRenderer))]

namespace TableViewinWP.WinPhone
{
    class BorderlessEntryRenderer : EntryRenderer
    {
        /// <summary>
        /// The on element changed.
        /// </summary>
        /// <param name="e">
        /// The e.
        /// </param>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var nativePhoneTextBox = (PhoneTextBox)Control.Children[0];
                nativePhoneTextBox.Style = (System.Windows.Style)App.Current.Resources["BorderlessTextBlockStyle"];
                nativePhoneTextBox.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
                nativePhoneTextBox.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Right;
                nativePhoneTextBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }
    }
}
