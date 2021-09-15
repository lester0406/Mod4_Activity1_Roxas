using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mod4_Activity1_Roxas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var data = e.Data.Properties["Text"].ToString();
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = new Label
            {
                Text = data
            };
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            var label = (sender as Element)?.Parent as Label;
            e.Data.Properties.Add("Text", label.Text);
        }
    }
}
