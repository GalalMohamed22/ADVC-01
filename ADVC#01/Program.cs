using System.Security.Cryptography.X509Certificates;

namespace ADVC_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  What is a generic class? Why use generics?

            // generic class is specifiy type of attrebutes or methodes when creating class
            // because type safety , code reusable , better performance and clean code

            #endregion


            #region Write a generic class Container<T> with Add and Get methods.

            //Container<int>.AddValue(0);
            //Container<int>.AddValue(5);
            //Container<int>.AddValue(6);
            //var values = Container<int>.GetValues();
            //foreach (int item in values)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region What are multiple type parameters? Write Pair<TKey,TValue >

            // Genaric class can have two parametars
            //Pair<string, int> pair = new Pair<string, int>();
            //pair.Key = "Route";
            //pair.value = 48;

            #endregion


            #region What is a generic method? Write Swap<T> method.

            // generic method that specific return type or parametar type using genaric
            //int a = 12, b = 10;
            //Swap(ref a,ref b);
            //Console.WriteLine($"a: {a} , b: {b}");

            #endregion


            #region Write a generic method FindMax<T> that finds maximum value

            //int[] arr = { 5, 0, 40, 40, 100, 2, 8 };
            //int mx = FindMax<int>(arr);
            //Console.WriteLine(mx);

            #endregion


            #region What is a generic interface? Write IRepository<T>

            // any class implement interface must specify data type


            #endregion


            #region What is the 'struct' constraint? Write an example.

            // where T => must be value type

            //int[] arr = { 5, 0, 40, 40, 100, 2, 8 };
            //int fi = ReturnFirstElemnt<int>(arr);
            //Console.WriteLine(fi);

            #endregion


            #region What is the 'class' constraint? Write an example.

            // where T => must be Reference type

            //string[] names = { "Galal", "Mohamed", "Ahmed" };
            //string fi = ReturnFirstName<string>(names);
            //Console.WriteLine(fi);

            #endregion


            #region What is the 'new()' constraint? Write an example.

            // where T => must have parametarless ctor
            //var te = TestNew<Container<int>>(new Container<int>());
            //Console.WriteLine(te.GetType());

            #endregion


            #region What is the interface constraint? Write an example.

            // creat class implement specific interface
            // public class Product<T> where T : IRepository

            #endregion


            #region What is the base class constraint? Write an example.

            // where T => must be derived from base class
            //var x = TestBaseClass<Cat>(new Cat());

            #endregion

            #region How do you apply multiple constraints? Write an example.

            // You can apply multiple constraints to a generic type parameter by putting them after where and separating them with commas
            //public class Container<T> where T : class, IComparable<T>, new()
            //{
            //    public T Value { get; set; }
            //}

            #endregion

            #region What does the 'default' keyword do in generics?

            // return default value for genaric type that specified

            #endregion


            #region Write a SafeList<T> that returns default when the index is invalid.

            //SafeList<int> safe = new SafeList<int>();
            //safe.Add(1);
            //safe.Add(2);
            //Console.WriteLine(safe.GetValue(5));

            #endregion

            #region What is covariance? Explain the 'out' keyword

            // Covariance lets you use a more derived type where a base type is expected
            // select generic will be use for return type only 

            #endregion


            #region What is contravariance? Explain the 'in' keyword.

            // it lets you use a base class type where a derived type is expected
            // select generic will be use for parametar type only 


            #endregion

            #region What is the difference between covariance and contravariance ?

            // Covariance lets you use a more derived type where a base type is expected
            // Covariance => out

            // contravariance lets you use a base class type where a derived type is expected
            // contravariance => in

            #endregion


            #region How do static members work in generic types?

            // Each closed generic type gets its own independent copy of static members
            // They are not shared across different type parameters

            #endregion



        }

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T mx = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(mx) > 0)
                {
                    mx = item;
                }
            }
            return mx;
        }
        public static T ReturnFirstElemnt<T>(T[] arr) where T : struct
        {
            T first = arr[0];
            return first;
        }
        public static T ReturnFirstName<T>(T[] arr) where T : class
        {
            T first = arr[0];
            return first;
        }
        public static T TestNew<T>(T arr) where T : new()
        {
            T ret = new T();
            return ret;
        }
        public static T TestBaseClass<T>(T arr) where T : Animal
        {
            return arr;
        }

    }
}
