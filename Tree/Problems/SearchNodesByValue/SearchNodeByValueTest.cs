﻿using Datastructure.Common;
using Datastructure.Tree.Model;
using Datastructure.Tree.Problems.Test.Data;
using NUnit.Framework;

namespace Datastructure.Tree.Problems.SearchNodesByValue
{
    [TestFixture]
    public class SearchNodeByValueTest
    {
        [Test]
        public void ShouldReturnNodeIfValueExistUsingRecursion()
        {

            var rootNode = TreeTestData.GetSimpleTreeRootNode();

            // finding node which is available in left side of the tree
            IAlgorithm<TreeDSNode, TreeDSNode> searchNodeByValue = new SearchNodesByValue(4);
            var actual = searchNodeByValue.UsingRecursion(rootNode);
            Assert.AreEqual(actual.Value, 4);

            // finding node which is available in right side of the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 6;
            var actualNodeFor6 = searchNodeByValue.UsingRecursion(rootNode);
            Assert.AreEqual(actualNodeFor6.Value, 6);

            // finding node which is available in root of the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 1;
            var actualRootNode = searchNodeByValue.UsingRecursion(rootNode);
            Assert.AreEqual(actualRootNode.Value, 1);

            // finding node which is not available in the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 99;
            var nullValueForNotFound = searchNodeByValue.UsingRecursion(rootNode);
            Assert.AreEqual(nullValueForNotFound, null);

        }

        [Test]
        public void ShouldReturnNodeIfValueExistUsingNonRecursion()
        {

            var rootNode = TreeTestData.GetSimpleTreeRootNode();

            // finding node which is available in left side of the tree
            IAlgorithm<TreeDSNode, TreeDSNode> searchNodeByValue = new SearchNodesByValue(4);
            var actual = searchNodeByValue.UsingNonRecursion(rootNode);
            Assert.AreEqual(actual.Value, 4);

            // finding node which is available in right side of the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 6;
            var actualNodeFor6 = searchNodeByValue.UsingNonRecursion(rootNode);
            Assert.AreEqual(actualNodeFor6.Value, 6);

            // finding node which is available in root of the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 1;
            var actualRootNode = searchNodeByValue.UsingNonRecursion(rootNode);
            Assert.AreEqual(actualRootNode.Value, 1);

            // finding node which is not available in the tree
            ((SearchNodesByValue)searchNodeByValue).valueToFind = 99;
            var nullValueForNotFound = searchNodeByValue.UsingNonRecursion(rootNode);
            Assert.AreEqual(nullValueForNotFound, null);

        }


    }
}
