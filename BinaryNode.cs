
namespace binary_node1
{
    public class BinaryNode<T>
    {
        public BinaryNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
        
        public T Value { get; set; }

        public BinaryNode<T>? LeftChild { get; set; }
        public BinaryNode<T>? RightChild { get; set; }

        public void AddLeft(BinaryNode<T> node)
        {
            LeftChild = node;
        }
        public void AddRight(BinaryNode<T> node)
        {
            RightChild = node;
        }
        public override string ToString()
        {
            return Value?.ToString() + ": " + (LeftChild?.Value?.ToString() ?? "null") + " " + (RightChild?.Value?.ToString() ?? "null");
        }
    }
}
