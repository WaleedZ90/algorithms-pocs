﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Models
{
    public class Node
    {
        public Node()
        {
            Children = new List<Node>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Node> Children { get; set; }
    }
}
