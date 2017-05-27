using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty.Interfaces
{
    public interface IEntityManager<T> where T : IEntity
    {
        Task<ObservableCollection<T>> GetItemsAsync();
        Task SaveAsync(T item);
    }
}
