using Karty.Interfaces;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty.Services
{
    public class EntityManager<T> : IEntityManager<T> where T : IEntity
    {
        IMobileServiceClient _client;
        protected IMobileServiceTable<T> Table;

        protected EntityManager(IMobileServiceClient client)
        {
            _client = client;
            Table = client.GetTable<T>();
        }

        public virtual async Task<ObservableCollection<T>> GetItemsAsync()
        {
            var items = await WhereClause();
            return new ObservableCollection<T>(items);
        }

        protected virtual async Task<IEnumerable<T>> WhereClause()
        {
            return await Table.ToEnumerableAsync();
        }

        public async Task SaveAsync(T item)
        {
            if (item.Id == null)
            {
                await Table.InsertAsync(item);
            }
            else
            {
                await Table.UpdateAsync(item);
            }
        }
    }
}
