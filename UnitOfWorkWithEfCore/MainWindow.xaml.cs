
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
using UnitOfWorkWithEfCore.Models;
using UnitOfWorkWithEfCore.DataAccess.Context;
using EfCoreWithUnitOfWork.Unit_Of_Work.Concrete;
using Microsoft.EntityFrameworkCore;

namespace UnitOfWorkWithEfCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UnitOfWork unitOfWork = new UnitOfWork(new MyDbContext());
        public MainWindow()
        {
            InitializeComponent(); 
            //Add data---------------------------------------------------------------
            //Book b1 = new Book() { Name = "The Grass is Always Greener", Price = 200, Quantity = 4 };
            //Book b2 = new Book() { Name = " A boy at seven", Price = 120, Quantity = 7 };
            //Book b3 = new Book() { Name = "The Higgler", Price = 345, Quantity = 2 };
            //Book b4 = new Book() { Name = "The Open Boat", Price = 80, Quantity = 8 };
            //Category c1 = new Category() { Name = "Crime", };
            //Category c2 = new Category() { Name = "Modern Times", };
            //Category c3 = new Category() { Name = "First Edition", };
            //c1.Books.Add(b1);
            //c1.Books.Add(b2);
            //c2.Books.Add(b3);
            //c3.Books.Add(b4);
            //unitOfWork.CategoryRepo.Add(c1);
            //unitOfWork.CategoryRepo.Add(c2);
            //unitOfWork.CategoryRepo.Add(c3);
            //unitOfWork.Complete();
            //---------------------------------------------------------------------------------
            datagrid_category.ItemsSource = unitOfWork.CategoryRepo.GetAll().Include(b => b.Books).ToList();

            
        }

        private void showData_Click(object sender, RoutedEventArgs e)
        {
            var category = datagrid_category.SelectedItem as Category;
            var result = unitOfWork.BookRepo.Query(p => p.CategoryId == category.Id).ToList();
            datagrid_book.ItemsSource = result;
        }

        private void btn_addCategory_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.grid_category.Visibility = Visibility.Visible;
            addWindow.ShowDialog();
            datagrid_category.ItemsSource = unitOfWork.CategoryRepo.GetAll().Include(b => b.Books).ToList();
        }

        private void btn_removeCategory_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid_category.SelectedIndex != -1)
            {
                unitOfWork.CategoryRepo.Remove(datagrid_category.SelectedItem as Category);
                unitOfWork.Complete();
                datagrid_category.ItemsSource = unitOfWork.CategoryRepo.GetAll().Include(b => b.Books).ToList();
                datagrid_book.ItemsSource = null;
            }
            else MessageBox.Show("Please Select category!!");
        }

        private void btn_addproduct_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.grid_product.Visibility = Visibility.Visible;
            addWindow.ShowDialog();
        }

        private void btn_removeproduct_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid_book.SelectedIndex != -1)
            {
                unitOfWork.BookRepo.Remove(datagrid_book.SelectedItem as Book);
                unitOfWork.Complete();
                datagrid_book.ItemsSource = null;
                MessageBox.Show("Book removerd successfully!");
            }
            else
                MessageBox.Show("Select Book!");
        }

        private void btn_editCategory_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid_category.SelectedIndex != -1)
            {
                AddWindow addWindow = new AddWindow();
                addWindow.grid_category.Visibility = Visibility.Visible;
                var category = datagrid_category.SelectedItem as Category;
                addWindow.txb_nameCategory.Text = category.Name;
                addWindow.Category = category;
                addWindow._Update = true;
                addWindow.ShowDialog();
                datagrid_category.ItemsSource = unitOfWork.CategoryRepo.GetAll().Include(b => b.Books).ToList();
            }
            else MessageBox.Show("Select Category!");
        }

        private void btn_editproduct_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid_book.SelectedIndex != -1)
            {
                AddWindow addWindow = new AddWindow();
                addWindow.grid_product.Visibility = Visibility.Visible;
                var book = datagrid_book.SelectedItem as Book;
                addWindow.txb_nameP.Text = book.Name;
                addWindow.txb_price.Text = book.Price.ToString();
                addWindow.txb_quantity.Text = book.Quantity.ToString();
                addWindow.txb_categoryId.Text = book.CategoryId.ToString();
                addWindow.Book = book;
                addWindow._Update = true;
                addWindow.ShowDialog();
            }
            else MessageBox.Show("Select Book!");
        }
    }
}
