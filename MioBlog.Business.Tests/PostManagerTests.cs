using FluentValidation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MioBlog.Business.Concretes.Managers;
using MioBlog.DataAccess.Abstracts;
using MioBlog.Entities.Concretes;
using Moq;

namespace MioBlog.Business.Tests
{
    [TestClass]
    public class PostManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void post_validation_check()
        {
            Mock<IPostDal> mock = new Mock<IPostDal>();
            PostManager postManager = new PostManager(mock.Object);

            postManager.Add(new Post());
        }
    }
}
