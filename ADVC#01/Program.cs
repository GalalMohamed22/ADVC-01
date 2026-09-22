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
