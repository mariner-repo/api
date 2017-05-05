using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mariner.DOMAIN.GaiaDAL;
using MongoDB.Bson;

namespace Mariner.DAL
{
    public class ImageService
    {        
        static ImageService(){
          

        }

        public void ImageInsert(Image image)
        {
           var gaiaContext = new MarinerContext();           
           gaiaContext.Images.InsertOne(image);
        }

        //public void ImageUpdate(Image image)
        //{
        //    _gaiaContext.Images.UpdateOne(image);
        //}

        //public void ImageRemove(Image image)
        //{
        //    _gaiaContext.Images.DeleteOne(image);
        //}


    }
}
