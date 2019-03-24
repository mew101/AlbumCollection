﻿using AlbumCollection.Controllers;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlbumCollection.Tests
{
    public class SongControllerTests
    {
        SongController underTest;
        private ISongRepository repo;

        public SongControllerTests()
        {
            repo = Substitute.For<ISongRepository>();

            underTest = new SongController(repo);
        }

        [Fact]
        public void Create_Has_View()
        {
            var id = 1;
            var result = underTest.Create(id);

            Assert.IsType<ViewResult>(result);
        }

    }
}
