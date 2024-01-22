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
        public void Add(T param)
        {

        }
    }
}