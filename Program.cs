namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
