using System.Text;

namespace QueuesCSharp
{
    public class MyQueue
    {
        public Node? First { get; private set; }
        public Node? Last { get; private set; }
        public int Length { get; private set; }

        public MyQueue()
        {
            First = null;
            Last = null;
            Length = 0;
        }

        // Inserts an element at the end of the queue
        public void Enqueue(int element)
        {
            var newNode = new Node(element);

            if (Last != null)
            {
                Last.Next = newNode;
            }

            Last = newNode;

            if (First == null)
            {
                First = newNode;
            }

            Length++;
        }

        // Removes the element at the start of the queue
        public int Dequeue()
        {
            if (First == null)
            {
                throw new Exception("There are no elements to be dequeued from the queue.");
            }

            var firstElement = First.Element;
            if (First == Last)
            {
                Last = Last.Next;
            }
            First = First.Next;            
            Length--;

            return firstElement;
        }

        // Returns the element at the start of the queue without removing it
        public int Peek()
        {
            if (First == null)
            {
                throw new Exception("There are no elements in the queue.");
            }
            return First.Element;
        }

        public override string ToString()
        {
            var pointer = First;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Start of Queue");
            while (pointer != null)
            {
                sb.Append($"{pointer.Element.ToString()}->");
                pointer = pointer.Next;
            }
            sb.AppendLine("");
            sb.AppendLine("End of Queue");
            sb.AppendLine("--");

            return sb.ToString();
        }
    }
}
