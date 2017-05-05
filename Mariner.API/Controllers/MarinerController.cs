using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Gaia.DOMAIN.GaiaAPI;
using Gaia.CORE;
using Gaia.DOMAIN.GaiaDAL;
using Swashbuckle.Swagger.Annotations;

namespace Mariner.API.Controllers
{
	public class MarinerController : ApiController
	{
		// GET api/values
		[SwaggerOperation("GetAll")]
		public async Task<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		[SwaggerOperation("GetById")]
		[SwaggerResponse(HttpStatusCode.OK)]
		[SwaggerResponse(HttpStatusCode.NotFound)]
		public async Task<string> Get(int id)
		{
			return "value";
		}

		// POST api/values
		[SwaggerOperation("Create")]
		[SwaggerResponse(HttpStatusCode.Created)]
		public async Task<IHttpActionResult> Post([FromBody]GaiaRequest gaiaRequest)
		{
			//byte[] bytes = System.IO.File.ReadAllBytes("C:\\Users\\dinowilliam\\Pictures\\Abellha_020.jpg");

			//var str = System.Text.Encoding.Default.GetString(bytes);
			//var data = System.Convert.ToBase64String(bytes);

			var ImageBusiness = new ImageBusiness();

			var image = new Image();

			image.Name = gaiaRequest.NomeArquivo;
			image.ImageData = gaiaRequest.DataArquivo;

			ImageBusiness.ImageProcess(image);

			var gaiaResponse = new GaiaResponse();
			return Json(gaiaResponse);
		}

		/*
		// PUT api/values/5
		[SwaggerOperation("Update")]
		[SwaggerResponse(HttpStatusCode.OK)]
		[SwaggerResponse(HttpStatusCode.NotFound)]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		[SwaggerOperation("Delete")]
		[SwaggerResponse(HttpStatusCode.OK)]
		[SwaggerResponse(HttpStatusCode.NotFound)]
		public void Delete(int id)
		{
		}
		*/
	}
}
