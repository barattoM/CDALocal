using GestionStocks.Controllers;
using GestionStocks.Data;
using GestionStocks.Data.Dtos;
using GestionStocks.Data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        ArticlesDTOAvecLibelleCategorie Article;
        CategoriesController CategorieController;
        public FormulaireArticle(object sender, MainWindow window, ArticlesDTOAvecLibelleCategorie article, MyDbContext _context)
        {
            InitializeComponent();
            this.Article = article;
            this.Window = window;
            CategorieController = new CategoriesController(_context);

            InitPage(sender);
        }

        private void InitPage(object sender)
        {
            string nom = (string)((Button)sender).Content;
            labTitreFormulaire.Content = nom + " un article";


            cbCategorie.ItemsSource = CategorieController.GetAllCategoriesModel();
            cbCategorie.DisplayMemberPath = "LibelleCategorie"; //Valeur a afficher dans la combobox
            cbCategorie.SelectedValuePath = "IdCategorie"; // Valeur de la combobox
            int idComboboxItem;
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
                    idComboboxItem =cbCategorie.Items.IndexOf(CategorieController.GetCategorieById(Article.IdCategorie).LibelleCategorie);
                    cbCategorie.SelectedItem = cbCategorie.Items[idComboboxItem];
                    //Button valider
                    btn_Valider.Click += (s, e) => ModifierArticle();
                    break;
                case "Supprimer":
                    //Libelle
                    txbLibelle.Text = Article.LibelleArticle;
                    txbLibelle.IsEnabled = false;
                    //Quantité
                    txbQuantite.Text = Article.QuantiteStockee.ToString();
                    txbQuantite.IsEnabled = false;
                    //Categorie
                    idComboboxItem = cbCategorie.Items.IndexOf(CategorieController.GetCategorieById(Article.IdCategorie).LibelleCategorie);
                    cbCategorie.SelectedItem = cbCategorie.Items[idComboboxItem];
                    cbCategorie.IsEnabled = false;
                    //Button valider
                    btn_Valider.Click += (s, e) => SupprimerArticle();
                    break;
                default:
                    break;
            }
        }

        private void AjouterArticle()
        {
            ArticlesDTOIn article = new ArticlesDTOIn
            {
                LibelleArticle = txbLibelle.Text,
                QuantiteStockee = int.Parse(txbQuantite.Text),
                IdCategorie = (int)cbCategorie.SelectedValue
            };
            this.Window.AjouterArticle(article);
            Retour();
        }

        private void ModifierArticle()
        {
            throw new NotImplementedException();
        }

        private void SupprimerArticle()
        {
            throw new NotImplementedException();
        }

        public void Retour(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Retour()
        {
            this.Close();
        }
    }
}
