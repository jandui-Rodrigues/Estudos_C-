namespace TypesAdvanceds
{
    public class Generic
    {
        public static void GenericMethod<T>(T param)
        {
            Console.WriteLine(param);
        }

    }

    public class GenericList<T>
    {
        public class Node
        {
            public T Value;
            public Node? Next;

            public Node(T t)
            {
                Value = t;
                Next = null;
            }
        }

        private Node Head;

        public GenericList()
        {
            Head = null;
        }
        public void Add(T param)
        {
            if(Head == null)
            {
                Head = new Node(param);
                Console.WriteLine($"Head: {Head.Value}");
            }
            else{
                Node lastNode = Head;
                while(lastNode.Next != null) lastNode = lastNode.Next;
                lastNode.Next = new Node(param);
            }
        }
    }
}