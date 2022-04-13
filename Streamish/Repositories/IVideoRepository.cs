using Streamish.Controllers;
using Streamish.Models;
using System.Collections.Generic;

namespace Streamish.Repositories
{
    public interface IVideoRepository
    {
        List<Video> GetAll();
        Video GetById(int id);

        public void Update(Video video);
        public void Delete(int id);
        public void Add(Video video);
    }
}
