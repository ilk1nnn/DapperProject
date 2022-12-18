using DapperProject.Data_Access.Entities;
using DapperProject.Domain.Commands;
using DapperProject.Domain.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperProject.Domain.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
		private ObservableCollection<Product> allproducts;

		public ObservableCollection<Product> AllProducts
		{
			get { return allproducts; }
			set { allproducts = value; OnPropertyChanged(); }
		}


		private Product selectedProduct;

		public Product SelectedProduct
        {
			get { return selectedProduct; }
			set { selectedProduct = value; OnPropertyChanged(); }
		}


		public RelayCommand SelectedCommand { get; set; }

		public HomeViewModel()
		{
			var productFromDb = App.DB.ProductRepository.GetAll();
			AllProducts = new ObservableCollection<Product>(productFromDb);

			SelectedProduct = new Product();

			SelectedCommand = new RelayCommand(s =>
			{
				ProductInfoViewModel vm = new ProductInfoViewModel(SelectedProduct);
				vm.Product = SelectedProduct;
				ProductInfo view = new ProductInfo();
				view.DataContext = vm;
				view.Show();
			});

		}

	}
}
