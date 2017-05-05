using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mariner.DAL;
using Mariner.DOMAIN.GaiaDAL;

namespace Gaia.CORE
{
    public class ImageFacade
    {

        public void ImageInsert(Image image)
        {
            var imageService = new ImageService();
            imageService.ImageInsert(image);
        }
    }
}
