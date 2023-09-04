using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW37_1
{
    internal class Shop
    {
        ObservableCollection<Item> _items;
        List<Customer> _customers;
        public Shop()
        {
            _items = new ObservableCollection<Item>();
            _customers = new List<Customer>();
        }
        public void Add(Item item)
        {
            if (_items.Contains(item))
                Console.WriteLine($"Товар с ID:{item.ID} уже есть");
            else _items.Add(item);
        }
        public void Remove(int id)
        {
            var item = _items.FirstOrDefault(x => x.ID == id, null);
            if (item != null)
                _items.Remove(item);
            else Console.WriteLine($"Товара с ID:{id} нет");
        }
        public void AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                _customers.Add(customer);
                _items.CollectionChanged += customer.OnItemChanged;
            }
        }
    }
}
