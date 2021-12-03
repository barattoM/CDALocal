
using GestionStocks.Controllers;
using GestionStocks.Data;
using GestionStocks.Data.Dtos;
using GestionStocks.Data.Models;
using GestionStocks.Data.Profiles;
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

namespace GestionStocks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyDbContext _context;
        ArticlesController _articlesController;
        public MainWindow()
        {
            InitializeComponent();
            _context = new MyDbContext();
            _articlesController = new ArticlesController(_context);
            ListeArticles.ItemsSource = _articlesController.GetAllArticlesAvecLibelleCateg();

        }

        private void btnActions_Click(object sender, RoutedEventArgs e)
        {
            ArticlesDTOAvecLibelleCategorie article = (ArticlesDTOAvecLibelleCategorie)ListeArticles.SelectedItem;
            string nom = (string)((Button)sender).Content;
            if (article == null && (nom == "Modifier" || nom == "Supprimer"))
            {
                MessageBox.Show("Pas de sélection");
            }
            else
            {
                
                FormulaireArticle actions = new FormulaireArticle(sender, this, article,_context);
                this.Opacity = 0.7;
                actions.ShowDialog();
                this.Opacity = 1;
            }
        }

        public void AjouterArticle(ArticlesDTOIn article)
        {
            _articlesController.CreateArticle(article);
            ActualiserTableau();
        }

        private void ActualiserTableau()
        {
            ListeArticles.Items.Refresh();
        }
    }
}
