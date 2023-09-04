using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW37_1
{
    internal class Customer
    {
        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var addItem = e.NewItems[0] as Item;
                    Console.WriteLine($"Добавлен: {addItem.Name} с ID: {addItem.ID}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    var remItem = e.OldItems[0] as Item;
                    Console.WriteLine($"Удален: {remItem.Name} с ID: {remItem.ID}");
                    break;
            }
        }
    }
}
