using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Passato_BocciatoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            float compito1, compito2, compito3, compito4, somma, media, min, max;
            lblPromosso_Bocciato.Content = "";
            if (txtCompito1.Text != "" && txtCompito2.Text != "" && txtCompito3.Text != "" && txtCompito4.Text != "")
            {
                try
                {
                    compito1 = float.Parse(txtCompito1.Text);
                    compito2 = float.Parse(txtCompito2.Text);
                    compito3 = float.Parse(txtCompito3.Text);
                    compito4 = float.Parse(txtCompito4.Text);
                    if (compito1 >= 2 && compito1 <= 10)
                    {
                        if (compito2 >= 2 && compito2 <= 10)
                        {
                            if (compito3 >= 2 && compito3 <= 10)
                            {
                                if (compito4 >= 2 && compito4 <= 10)
                                {
                                    somma = compito1 + compito2 + compito3 + compito4;
                                    media = somma / 4;
                                    lblMedia.Content = media;
                                    min = Math.Min(compito1, Math.Min(compito2, Math.Min(compito3, compito4)));
                                    max = Math.Max(compito1, Math.Max(compito2, Math.Max(compito3, compito4)));
                                    lblMin.Content = min;
                                    lblMax.Content = max;

                                    if (media >= 6)
                                        lblPromosso_Bocciato.Content = "Promosso";
                                    else
                                        lblPromosso_Bocciato.Content = "Bocciato";

                                    lblIncidenzaC1.Content = Math.Round((compito1 / somma) * 100, 0);
                                    lblIncidenzaC2.Content = Math.Round((compito2 / somma) * 100, 0);
                                    lblIncidenzaC3.Content = Math.Round((compito3 / somma) * 100, 0);
                                    lblIncidenzaC4.Content = Math.Round((compito4 / somma) * 100, 0);
                                }
                                else
                                    lblMedia.Content = "Voto non valido.";
                            }
                            else
                                lblMedia.Content = "Voto non valido.";
                        }
                        else
                            lblMedia.Content = "Voto non valido.";
                    }
                    else
                        lblMedia.Content = "Voto non valido.";

                }
                catch (Exception)
                {
                    MessageBox.Show("Valore/i non valido/i", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Inserire dei valori.", "Attention", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
