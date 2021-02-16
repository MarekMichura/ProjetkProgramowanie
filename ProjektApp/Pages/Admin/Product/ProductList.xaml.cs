﻿using DBconnectShop.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using ProductDB = DBconnectShop.Table.Product;

namespace ProjektApp.Pages.Admin.Product {
    /// <summary>
    /// Interaction logic for ProductList.xaml
    /// </summary>
    public partial class ProductList : UserControl {
        static MainWindow Window =>
            Application.Current.MainWindow as MainWindow;
        AdminProducts admin = new AdminProducts(Window.login);

        List<Element> Values { get; set; } = new List<Element>();
        List<string> Categories { get; set; } = new List<string>();
        List<string> Producers { get; set; } = new List<string>();

        public ProductList() {
            InitializeComponent();

            Window.Loading.IsOpen = true;
            Thread thread = new Thread(InitItems) {
                IsBackground = true
            };
            thread.Start();
        }

        private void InitItems() {
            Categories = admin.GetCategories().Select(a => a.TrueName).ToList();
            Producers = admin.GetProducers().Select(a => a.TrueName).ToList();
            Dispatcher.Invoke(() => {
                Categoriee.ItemsSource = Categories;
                Producer.ItemsSource = Producers;
            });

            foreach(var product in admin.GetProducts()) {
                Dispatcher.Invoke(() => {
                    Values.Add(new Element(product));
                });
            }

            Dispatcher.Invoke(() => {
                Window.Loading.IsOpen = false;
                GridData.ItemsSource = Values;
            });
        }

        private void ShowImages(object o, EventArgs e) {
            if((Button)o).CommandParameter is null)
                    return;
            var id = (int)((Button)o).CommandParameter;
            Window.Content.Content = new ProductImages(id);
        }

        class Element {
            static MainWindow Window =>
                Application.Current.MainWindow as MainWindow;
            AdminProducts admin = new AdminProducts(Window.login);

            public int ID =>
                Product.ID;
            public string Name {
                get => Product.TrueName;
                set => admin.ChangeName(Product, value);
            }
            public string Category {
                get => Product.Product_Categori.TrueName;
                set => admin.ChangeCategory(Product, value);
            }
            public string Producer {
                get => Product.Product_Producer.TrueName;
                set => admin.ChangeProducer(Product, value);
            }
            public bool Aviable {
                get => Product.Product_aviable;
                set => admin.ChangeAviable(Product, value);
            }

            ProductDB Product;

            public Element(ProductDB product) {
                Product = product;
            }

            public Element() {
                Product = admin.NewProduct();
            }
        }
    }
}