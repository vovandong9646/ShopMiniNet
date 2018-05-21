using ShopMini.Model.Models;
using ShopMini.Service;
using ShopMini.Web.Infrastructure.Core;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopMini.Web.Api
{
    [RoutePrefix("api/post")]
    public class PostController : ApiControllerBase
    {
        private IPostService _postService;

        public PostController(IErrorService errorService, IPostService postService) : base(errorService)
        {
            this._postService = postService;
        }

        // CRUD
        [Route("getall")]
        public HttpResponseMessage GET(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listPosts = _postService.GetAll();
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listPosts);

                return response;
            });
        }

        public HttpResponseMessage POST(HttpRequestMessage request, Post post)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    return request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var addPost = _postService.Add(post);
                    _postService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.Created, addPost);
                }
                return response;
            });
        }

        public HttpResponseMessage PUT(HttpRequestMessage request, Post post)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    return request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postService.Update(post);
                    _postService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }

        public HttpResponseMessage DELETE(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    return request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postService.Delete(id);
                    _postService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}