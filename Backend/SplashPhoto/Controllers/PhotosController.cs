using Microsoft.AspNetCore.Mvc;
using SplashPhoto.Data;
using SplashPhoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SplashPhoto.Controllers
{
    [Route("api/photos")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private IUserPhotoRepo _photoRepository;
        public PhotosController(IUserPhotoRepo photoRepository)
        {
            _photoRepository = photoRepository;
        }
        // GET: api/<PhotosController>
        [HttpGet]
        public ActionResult<IEnumerable<UserPhoto>> GetPhoto()
        {
            var items = _photoRepository.GetPhotos();
            return Ok(items);
        }

        // GET api/<PhotosController>/5
        [HttpGet("{id}")]
        public ActionResult<UserPhoto> GetPhotoById(string id)
        {
            var items = _photoRepository.GetPhotoById(id);
            if(items != null)
            {
                return Ok(items);
            }
            return NotFound();
        }

        //// POST api/<PhotosController>
        //[HttpPost]
        //public void PostPhoto([FromBody] UserPhoto value)
        //{
        //    _photoRepository.PostPhoto(value);
        //}

        [HttpPost]
        public void PostBulkPhoto([FromBody] List<UserPhoto> value)
        {
            _photoRepository.PostBulkPhoto(value);
        }

        // PUT api/<PhotosController>/5
        [HttpPut("{id}")]
        public void PutPhoto(string id, [FromBody] UserPhoto value)
        {
            _photoRepository.UpdatePhoto(id, value);
        }

        // DELETE api/<PhotosController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _photoRepository.DeletePhoto(id);

        }
    }
}
