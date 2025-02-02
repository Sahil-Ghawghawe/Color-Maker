﻿namespace Color_Maker
{
    public partial class MainPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red = sldRed.Value;
            var green = sldGreen.Value;
            var blue = sldBlue.Value;

            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
        }

        private void SetColor(Color color)
        {

            btnRandom.BackgroundColor = color;
            Container.BackgroundColor = color;
            lblHex.Text = color.ToHex();
        }
        private void btnRandom_Clicked(object sender, EventArgs e)
        {
            var random = new Random();
            var color = Color.FromRgb(
                random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));

            SetColor(color);

            sldRed.Value = color.Red;
            sldGreen.Value = color.Green;
            sldBlue.Value = color.Blue;
        }
    }
}