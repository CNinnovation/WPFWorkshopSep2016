using System.Collections.Generic;
using System.Linq;

namespace TreeViewSample
{
    public class NodeFactory
    {
        public IEnumerable<ANode> GetNodes()
        {
            return Enumerable.Range(0, 10).Select(x => new ANode($"{x}")).ToList();
        }
    }
}
