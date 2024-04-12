using Avalonia.Controls;
using Avalonia.Interactivity;
using Tmds.DBus.Protocol;

namespace UI_Testin1
{
    public partial class MainWindow : Window
    {
        Solver Calsolver;
        public MainWindow()
        {
            InitializeComponent();
            TextBox1.Text = "\n-------------------------\n";
            Calsolver = new Solver();
        }
        public void Button1ClickHandler(object sender,RoutedEventArgs args)
        {
            TextBox1.Text = "1" + TextBox1.Text;
            Calsolver.Accumulate("1");
        }

        public void Button2ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "2" + TextBox1.Text;
            Calsolver.Accumulate("2");
        }

        public void Button3ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "3" + TextBox1.Text;
            Calsolver.Accumulate("3");
        }

        public void ButtonPlusClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "+" + TextBox1.Text;
            Calsolver.Accumulate("+");
        }

        public void Button4ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "4" + TextBox1.Text;
            Calsolver.Accumulate("4");
        }

        public void Button5ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "5" + TextBox1.Text;
            Calsolver.Accumulate("5");
        }

        public void Button6ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "6" + TextBox1.Text;
            Calsolver.Accumulate("6");
        }

        public void ButtonMinusClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "-" + TextBox1.Text;
            Calsolver.Accumulate("-");
        }

        public void Button7ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "7" + TextBox1.Text;
            Calsolver.Accumulate("7");
        }

        public void Button8ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "8" + TextBox1.Text;
            Calsolver.Accumulate("8");
        }

        public void Button9ClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "9" + TextBox1.Text;
            Calsolver.Accumulate("9");
        }

        public void ButtonTimesClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "*" + TextBox1.Text;
            Calsolver.Accumulate("*");
        }

        public void ButtonZeroClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "0" + TextBox1.Text;
            Calsolver.Accumulate("0");
        }

        public void ButtonDotClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "." + TextBox1.Text;
            Calsolver.Accumulate(".");
        }

        public void ButtonEqualsClickHandler(object sender, RoutedEventArgs args)
        {
            //TextBox1.Text += "=";
            double answer = Calsolver.solve();
            TextBox1.Text +=  answer.ToString();
        }
        public void ACClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "\n-------------------------\n";
            Calsolver.Clear();
        }

        public void ButtonPLMClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "-" + TextBox1.Text;
            Calsolver.Accumulate("-"); ;
        }

        public void ButtonModClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "%" + TextBox1.Text;
            Calsolver.Accumulate("%");
        }

        public void ButtonDivClickHandler(object sender, RoutedEventArgs args)
        {
            TextBox1.Text = "/" + TextBox1.Text;
            Calsolver.Accumulate("/");
        }
    }
}