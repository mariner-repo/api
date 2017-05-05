using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mariner.CORE.Watson;
using Mariner.DOMAIN.GaiaDAL;

namespace Mariner.CORE
{
    public class ImageBusiness
    {
        public void ImageProcess(Image image)
        {
            var imageFacade = new ImageFacade();
            imageFacade.ImageInsert(image);

            WatsonClient watsonClient = new WatsonClient();
            
            var imageData = Convert.FromBase64String(image.ImageData);
            var watsonResult = watsonClient.ListarClassificadores(image.Name, imageData);
            

        }
    }
}
