using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_node1
{
    public class NaryNode<T>
    {        
        public NaryNode(T value) 
        { 
            Value = value;
            Children = new List<NaryNode<T>>();
        }

        public T Value { get; set; }

        public List<NaryNode<T>> Children { get; set; }

        public void AddChild(NaryNode<T> node)
        {
            Children.Add(node);
        }

        public override string ToString()
        {
            return Value?.ToString() + ": " + string.Join(" ", Children.Select(x => x.Value));
        }
    }
}
