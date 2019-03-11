using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Tests
{
    public class AlbumControllerTests
    {
        AlbumController underTest;
        private IAlbumRepository repo;

        public AlbumControllerTests()
        {
            repo = Substitute.For<IAlbumRepository>();

            underTest = new AlbumController(repo);
        }

        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {
            var expectedModel = new List<Album>();
            repo.GetAll().Returns(expectedModel);
            var actualModel = underTest.Index().Model;


            Assert.Equal(expectedModel, actualModel);

        }

        [Fact]
        public void Details_Sets_Model_To_Correct_Album()
        {
            var expectedId = 2;
            var expectedModel = new Album();
            repo.GetById(expectedId).Returns(expectedModel);
            var actualModel = underTest.Details(expectedId).Model;

            Assert.Equal(expectedModel, actualModel);
        }
    }
}
