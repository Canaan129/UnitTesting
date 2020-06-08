using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using System.Text.Json;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_ID_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Id = "testId" };
           
            // Assert
            Assert.AreEqual(result.Id, "testId");
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Maker = "testMaker"};

            // Assert
            Assert.AreEqual(result.Maker, "testMaker");
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Image = "testImage.png" };

            // Assert
            Assert.AreEqual(result.Image, "testImage.png");
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Url = "testUrl.com" };

            // Assert
            Assert.AreEqual(result.Url, "testUrl.com");
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Title = "testTitle" };

            // Assert
            Assert.AreEqual(result.Title, "testTitle");
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Description = "testDescription" };

            // Assert
            Assert.AreEqual(result.Description, "testDescription");
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Email = "testEmail" };

            // Assert
            Assert.AreEqual(result.Email, "testEmail");
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Logistics = "testLogistics" };

            // Assert
            Assert.AreEqual(result.Logistics, "testLogistics");
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Method_ToString_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(result.ToString(), JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void ProductModel_Method_ToString_Is_Not_Null_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result.ToString());
        }

        [TestMethod]
        public void ProductModel_Method_AverageRating_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Method_AverageRating_Is_Null_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Ratings = null };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Method_AverageRating_Total_Is_Zero_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Ratings = new int[] { 0 } };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Method_AverageRating_Count_Is_Zero_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Ratings = new int[] { } };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Method_AverageRating_Average_Return_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel() { Ratings = new int[] { 3, 4, 5 } };

            // Assert
            Assert.AreEqual(4, result.AverageRating());
        }
    }
}
