using System.Collections.Generic;
using Algorithms.Helpers;
using Algorithms.Helpers.LinkedLists;
using Algorithms.Models;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = new List<int>() { 1, 1, 2, 2, 3, 4 };
            //List<int> distinctValues = ArrayUtilities.GetDistinctValues(arr);

            //var unsortedArray = new List<int> { 3, 2, 6, 4, 7, 1 };
            //var sortedArray = ArrayUtilities.SortAscending(unsortedArray);

            //var decimalUnsortedArray = new List<decimal>() { 0.897M, 0.565M, 0.656M, 0.1234M, 0.665M, 0.3434M };
            //var decimalSortedArray = ArrayUtilities.BucketSort(decimalUnsortedArray);

            //var setsOfNumbers = new List<int> { 2, 4, 6, 10 };
            //var pairs = InfoUtilities.FindPairsOfNumbers(setsOfNumbers, 16);

            //var nums = new int[3] { 3, 2, 4 };
            //var indices = InfoUtilities.TwoSum(nums, 6);

            //var fib = Fibonnaci.Run(80);

            //var arr = new List<int> { 1, 3, 3, 7, 10, 11, 16, 17, 20, 21, 25, 26, 30, 32, 34, 35 };
            //var idx = BinarySearch.Search(arr, 25, 0, arr.Count -1);

            //var tree = new List<Node>
            //{
            //    new Node
            //    {
            //        Id = 1,
            //        Name = "Root",
            //        Children = new List<Node>
            //        {
            //            new Node
            //            {
            //                Id = 2,
            //                Name = "Meat",
            //                Children = new List<Node>
            //                {
            //                    new Node {Id = 3, Name = "Chicken"},
            //                    new Node {Id = 4, Name = "Beef"}
            //                }
            //            },
            //            new Node
            //            {
            //                Id = 5,
            //                Name = "Vegetables",
            //                Children = new List<Node>
            //                {
            //                    new Node
            //                    {
            //                        Id = 6,
            //                        Name = "Frozen",
            //                        Children = new List<Node>
            //                        {
            //                            new Node {Id = 7, Name = "Peas"},
            //                            new Node {Id = 8, Name = "Beans"},
            //                            new Node {Id = 9, Name = "Spinach"}
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //};

            //foreach (var node in tree)
            //{
            //    DepthFirstSearch.Preorder(node);
            //    DepthFirstSearch.PostOrder(node);
            //}

            //// Reverse Numbers
            //var reversedNumber = ReverseInteger.Reverse(-123);

            //// Palindrome
            //var isPalindrome = Palindrome.IsPalindrome(123321);

            // Create Linked List
            var arrNumbers = new int[] { 1, 2, 3, 4, 5 };
            var node = CreateLinkedList.Create(arrNumbers);
            // Remove nth element in a linked list
            var nodeToRemove = RemoveNthFromEnd.Remove(node, 2);
        }
    }
}
