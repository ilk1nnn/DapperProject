using DapperProject.Data_Access.Entities;
using DapperProject.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DapperProject.Domain.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
		private OrderDetails order;

		public OrderDetails Order
		{
			get { return order; }
			set { order = value;OnPropertyChanged(); }
		}

		public RelayCommand SubmitCommand { get; set; }

		public OrderViewModel(Product product)
		{
			Order = new OrderDetails();

			//SubmitCommand = new RelayCommand(s =>
			//{
			//	App.DB.OrderDetailsRepository.Add(order);
			//});


        }
	}
}
