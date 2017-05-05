using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mariner.DAL;
using Mariner.DOMAIN.GaiaDAL;
using MongoDB.Bson;

namespace Mariner.TEST
{
    [TestClass]
    public class DALUnitTestProject
    {
        [TestMethod]
        public void TestContextGeneration()
        {
            var gaiaContext = new GaiaContext();

            Assert.IsNotNull(gaiaContext.Database);
        }

        [TestMethod]
        public void TestImageInsertion()
        {
            var imageService = new ImageService();

            Image image = new Image();
                   
            image.Name = "Image002.jpg";
            image.ImageData = "D9987989987987987987878787897897897897987987987987897979879798787879879798797897897987";
            imageService.ImageInsert(image);

            //Assert.IsNotNull(gaiaContext.Database);
        }
    }
}
