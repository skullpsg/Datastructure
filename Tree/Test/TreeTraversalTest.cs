﻿using Datastructure.Common;
using Datastructure.Tree.Model;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Datastructure.Tree.Test
{

    [TestFixture]
    public class TreeTraversalTest
    {

        [Test]
        public void ShouldPrintTreeInPreOrder()
        {
            var expectedOutputs = new List<int>() { 1, 2, 4, 5, 3, 6 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.PreOrderTraversal();
        }

        [Test]
        public void ShouldPrintTreeInInOrder()
        {
            var expectedOutputs = new List<int>() { 4, 5, 2, 6, 3, 1 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.InOrderTraversal();
        }

        [Test]
        public void ShouldReturnNodeByValue()
        {
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();

            // finding node which is available in left side of the tree
            TreeTraversal tree = new TreeTraversal(rootNode);
            var actual = tree.GetNodeUsingRecursion(rootNode, 4);
            Assert.AreEqual(actual.Value, 4);

            // finding node which is available in right side of the tree
            var actualNodeFor6 = tree.GetNodeUsingRecursion(rootNode, 6);
            Assert.AreEqual(actualNodeFor6.Value, 6);

            // finding node which is available in root of the tree
            var actualRootNode = tree.GetNodeUsingRecursion(rootNode, 1);
            Assert.AreEqual(actualRootNode.Value, 1);

            // finding node which is not available in the tree
            var nullValueForNotFound = tree.GetNodeUsingRecursion(rootNode, 99);
            Assert.AreEqual(nullValueForNotFound, null);

        }

        [Test]
        public void ShouldPrintTreeInPostOrder()
        {
            var expectedOutputs = new List<int>() { 4, 5, 2, 6, 3, 1 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.PostOrderTraversal();
        }

        [Test]
        public void ShouldPrintTreeInLevelOrder()
        {
            var expectedOutputs = new List<int>() {1,2,3,4,5,6 };
            IConsoleWriter writerMock = MockWriter.GetInstance(expectedOutputs);
            TreeDSNode rootNode = TreeTestData.GetSimpleTreeRootNode();
            TreeTraversal tree = new TreeTraversal(rootNode, writerMock);
            tree.LevelOrderTraversal();
        }


    }
}
