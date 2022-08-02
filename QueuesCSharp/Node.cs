namespace QueuesCSharp
{
    public class Node
    {
        public int Element { get; set; }
        public Node? Next { get; set; }

        public Node(int element)
        {
            this.Element = element;
            this.Next = null;
        }
    }
}
