using KartyService.Models;
using KartyService.DataObjects;
using Microsoft.Azure.Mobile.Server;
using System.Linq;
using System.Web.Http.Controllers;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web.Http.OData;

namespace ItemyService.Controllers
{
    public class ItemController : TableController<Item>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            KartyContext context = new KartyContext();
            DomainManager = new EntityDomainManager<Item>(context, Request, true);
        }

        // GET tables/Item
        public IQueryable<Item> GetAllItems()
        {
            return Query();
        }

        // GET tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Item> GetItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Item> PatchItem(string id, Delta<Item> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Item
        public async Task<IHttpActionResult> PostItem(Item Item)
        {
            Item current = await InsertAsync(Item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}