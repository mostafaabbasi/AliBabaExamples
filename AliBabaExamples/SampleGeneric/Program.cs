namespace SampleGeneric
{
    public interface IGenericArray
    {
        string Title { get; set; }
    }
    public class Person : IGenericArray
    {
        public string Title { get; set; }
    }

    public class MyGenericArray<T> where T : IGenericArray, new()
    {

        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, string value)
        {
            T a = new T();
            a.Title = value;
            array[index] = a;
        }
        public string GetName(int index)
        {
            var x = array[index];
            return x.Title;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            MyGenericArray<Person> intArray = new MyGenericArray<Person>(5);



            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, string.Format("Ali {0}", c));
            }


            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.GetName(c) + " ");
            }

            //Console.WriteLine();


            //MyGenericArray<char> charArray = new MyGenericArray<char>(5);


            //for (int c = 0; c < 5; c++)
            //{
            //    charArray.setItem(c, (char)(c + 97));
            //}


            //for (int c = 0; c < 5; c++)
            //{
            //    Console.Write(charArray.getItem(c) + " ");
            //}
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}