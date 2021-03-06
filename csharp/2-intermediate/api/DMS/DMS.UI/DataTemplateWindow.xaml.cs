using DMS.Library.Domain;
using System;
using System.Collections.Generic;
using System.Windows;

namespace DMS.UI
{
    /// <summary>
    /// Lógica de interacción para DataTemplateWindow.xaml
    /// </summary>
    /// 
    // https://geeks.ms/oalvarez/2009/07/27/datatemplates-en-wpf/
    public partial class DataTemplateWindow : Window
    {
        public DataTemplateWindow()
        {
            InitializeComponent();
            LoadDispatchs();
        }

        private void LoadDispatchs()
        {
            List<Dispatch> data = new List<Dispatch>();

            var dispatch01 = new Dispatch()
            {
                DeliveryAddress = "Delivery Address 01", 
                CustomerFullname = "Customer Fullname 01",
                CustomerEmail = "customer01@dms.com",
                DispatchCode = "Dispatch code 01",
                CreatedAt = DateTime.Now
            };

            var dispatch02 = new Dispatch()
            {
                DeliveryAddress = "Delivery Address 02",
                CustomerFullname = "Customer Fullname 02",
                CustomerEmail = "customer02@dms.com",
                DispatchCode = "Dispatch code 02",
                CreatedAt = DateTime.Now
            };

            var dispatch03 = new Dispatch()
            {
                DeliveryAddress = "Delivery Address 03",
                CustomerFullname = "Customer Fullname 03",
                CustomerEmail = "customer03@dms.com",
                DispatchCode = "Dispatch code 03",
                CreatedAt = DateTime.Now
            };

            data.Add(dispatch01);
            data.Add(dispatch02);
            data.Add(dispatch03);

            dgDispatchs.ItemsSource = data;
        }
    }
}
