namespace Exercises_25._02._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int[] CreateArray(int size, bool sorted)
        {
            Random random = new Random(Environment.TickCount);
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, size);
            }
            if (sorted)
            {
                Array.Sort(array);
            }
            return array;
        }
        public static Array Transposed(int[] array, int key)
        {
            for(int i =0; i < array.Length;i++)
            {
                if(array[i] == key)
                {
                    (array[i], array[i-1]) = (array[i-1], array[i]);
                }
            }
            return array;
        }
        public static Array Moving(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    (array[0], array[i]) = (array[i], array[0]);
                }
            }
            return array;
        }
    }
}
