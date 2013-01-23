using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;

namespace Playground.Domain.Tests
{
    [TestClass]
    public class TwitterClientTests
    {
        // Happy Path

        [TestMethod]
        [TestCategory("Integration Test")]
        public void WhenSearchingForAWord()
        {
            // Arrange
            var twitterClient = new TwitterClient();

            // Act
            var results = twitterClient.Search("America");

            // Assert
            Assert.IsNotNull(results);
        }

        [TestMethod]
        [TestCategory("Integration Test")]
        public void WhenSearchingForAWordWithSpaces()
        {
            // Arrange
            var twitterClient = new TwitterClient();

            // Act
            var results = twitterClient.Search("United States of America");

            // Assert
            Assert.IsNotNull(results);
        }

        // Unhappy Path

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void WhenSearchingForAnEmptyString()
        {
            // Arrange
            var twitterClient = new TwitterClient();

            // Act & Assert
            twitterClient.Search(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenSearchingForNull()
        {
            // Arrange
            var twitterClient = new TwitterClient();

            // Act & Assert
            twitterClient.Search(null);
        }
    }
}
