using DSA.LinkedListDSA;

internal class Program
{
    private static void Main(string[] args)
    {
        //LinkedListDSA list = new LinkedListDSA();
        Tail<int> list = new Tail<int>();
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);
        list.AddFirst(1);
        list.ReadAll();

    }
}