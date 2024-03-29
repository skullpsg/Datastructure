﻿using Datastructure.Common;
using Datastructure.Tree.Model;
using System.Collections.Generic;

namespace Datastructure.Tree.Problems.TreeSize
{
    class TreeSize : IAlgorithm<TreeDSNode, int>
    {
        public int UsingNonRecursion(TreeDSNode root)
        {
            var currentNode = root;
            int size = 0;
            var queue = new Queue<TreeDSNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                currentNode = queue.Dequeue();
                if (currentNode != null)
                {
                    size++;
                }
                if (currentNode.isLeftNodeAvailable())
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.isRightNodeAvailable())
                {
                    queue.Enqueue(currentNode.Right);
                }
            }
            return size;
        }

        public int UsingRecursion(TreeDSNode root)
        {
            if (root == null)
                return 0;

            return UsingRecursion(root.Left) + UsingRecursion(root.Right) + 1;
        }
    }
}
