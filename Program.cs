namespace DataStructures
{
    internal sealed class Program
    {
        static void Main()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();

            list.AddLast("Denis");
            list.AddLast("Vlad");
            list.RemoveFirst();
        }
    }
}