namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        List<string> Cytatka = new List<string>
        {
            "Dzien Dobry",
            "Good Morning",
            "Buenos Dias"
        };

        int currentIndex = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void SliderBar_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)Math.Round(e.NewValue);
            Rozmiar.Text = $"Rozmiar: {value}";

            Cytat.FontSize = value; 
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % Cytatka.Count;
            Cytat.Text = Cytatka[currentIndex];
        }
    }
}
