using GestionStocks.Controllers;
using GestionStocks.Data;
using GestionStocks.Data.Dtos;
using GestionStocks.Data.Models;
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
using System.Windows.Shapes;

namespace GestionStocks
{
    /// <summary>
    /// Logique d'interaction pour FormulaireArticle.xaml
    /// </summary>

    public partial class FormulaireArticle : Window
    {
        MainWindow Window;
        Article Article;
        CategoriesController Categorie;
        public FormulaireArticle(object sender, MainWindow window, Article article, MyDbContext _context)
        {
            InitializeComponent();
            this.Article = article;
            this.Window = window;
            Categorie = new CategoriesController(_context);
            InitPage(sender);
        }

        private void InitPage(object sender)
        {
            string nom = (string)((Button)sender).Content;
            labTitreFormulaire.Content = nom + " un article";
            cbCategorie.ItemsSource = Categorie.GetAllCategoriesName();
            switch (nom)
            {
                case "Ajouter":
                    //Button valider
                    btn_Valider.Click += (s, e) => AjouterArticle();
                    break;
                case "Modifier":
                    //Libelle
                    txbLibelle.Text = Article.LibelleArticle;
                    //Quantité
                    txbQuantite.Text = Article.QuantiteStockee.ToString();
                    //Categorie
                    
                    cbCategorie.SelectedIndex = Article.IdCategorie;
                    //Button valider
                    btn_Valider.Click += (s, e) => ModifierArticle();
                    break;
                case "Supprimer":
                    //Libelle
                    txbLibelle.Text = Article.LibelleArticle;
                    //Quantité
                    txbQuantite.Text = Article.QuantiteStockee.ToString();
                    //Categorie
                    cbCategorie.SelectedItem = Article.LibelleArticle;
                    //Button valider
                    btn_Valider.Click += (s, e) => SupprimerArticle();
                    break;
                default:
                    break;
            }
        }

        private void AjouterArticle()
        {
            throw new NotImplementedException();
        }

        private void ModifierArticle()
        {
            throw new NotImplementedException();
        }

        private void SupprimerArticle()
        {
            throw new NotImplementedException();
        }
    }
}
