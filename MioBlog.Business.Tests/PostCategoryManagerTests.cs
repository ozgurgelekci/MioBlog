using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MioBlog.Business.Concretes.Managers;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;
using Moq;

namespace MioBlog.Business.Tests
{
    [TestClass]
    public class PostCategoryManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void postCategory_validation_check()
        {
            Mock<IPostCategoryDal> mock = new Mock<IPostCategoryDal>();
            PostCategoryManager postCategoryManager = new PostCategoryManager(mock.Object);

            postCategoryManager.Add(new PostCategory());
        }
    }
}
