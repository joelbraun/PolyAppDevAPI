using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using polyappService.DataObjects;
using polyappService.Models;

namespace polyappService.Controllers
{
    public class ChatItemController : TableController<ChatItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            polyappContext context = new polyappContext();
            DomainManager = new EntityDomainManager<ChatItem>(context, Request);
        }

        // GET tables/ChatItem
        public IQueryable<ChatItem> GetAllChatItem()
        {
            return Query(); 
        }

        // GET tables/ChatItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<ChatItem> GetChatItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/ChatItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<ChatItem> PatchChatItem(string id, Delta<ChatItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/ChatItem
        public async Task<IHttpActionResult> PostChatItem(ChatItem item)
        {
            ChatItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/ChatItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteChatItem(string id)
        {
             return DeleteAsync(id);
        }
    }
}
