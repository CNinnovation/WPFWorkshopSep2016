using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeViewSample
{
    public class ANode
    {
        public ANode(string text)
        {
            Text = text;
        }
        public string Text { get; set; }

        public override string ToString() => Text;

        public Lazy<IEnumerable<ANode>> ChildNodes => 
            new Lazy<IEnumerable<ANode>>(() =>
                new List<ANode>(
                    Enumerable.Range(0, 10).Select(x => new ANode($"{Text}.{x}")).ToList()));
    }
}
