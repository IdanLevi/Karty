using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using KartyService.DataObjects;
using KartyService.Models;

namespace OsloAppService.Controllers
{
    public class KartController : TableController<Kart>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            KartyContext context = new KartyContext();
            DomainManager = new EntityDomainManager<Kart>(context, Request, true);
        }

        // GET tables/Kart
        public IQueryable<Kart> GetAllKarts()
        {
            return Query();
        }

        // GET tables/Kart/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Kart> GetKart(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Kart/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Kart> PatchKart(string id, Delta<Kart> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Kart
        public async Task<IHttpActionResult> PostKart(Kart kart)
        {
            Kart current = await InsertAsync(kart);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Kart/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteKart(string id)
        {
            return DeleteAsync(id);
        }
    }
}
