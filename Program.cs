﻿namespace Exercises_25._02._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise34();
            Exercise5();
        }
        public static void Exercise5()
        {
            Console.WriteLine("--------------EXERCISE 5--------------");
            List<Student> students = new List<Student>();
            students.Add(new Student("Petar", 10));
            students.Add(new Student("Kennen", 25));
            students.Add(new Student("Darius", 20));
            students.Add(new Student("Kalista", 50));
            students.Add(new Student("Azir", 80));
            students.Add(new Student("Xerath", 67));
            students.Add(new Student("Nunu", 38));

            students = students.OrderByDescending(s => s.Score).ToList();
            Console.WriteLine(String.Join("\n", students.Select(s => $"{s.Name} : {s.Score}")));

            University uni = new University(students);
            Console.Write("Student: ");
            Console.Write(uni.FindStudentByScore(80));

        }
        public static void Exercise34()
        {
            Console.WriteLine("--------------EXERCISE 3 AND 4--------------");
            int[] array = CreateArray(10, false);
            Console.WriteLine("Enter key: \n");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("-----ARRAY IS-----\n" + String.Join(",", array));
            Console.WriteLine("---------------------\n");
            Console.WriteLine(String.Join(",", Transposed(array, k)));
            Console.WriteLine("---------------------\n");
            Console.WriteLine(String.Join(",", Moving(array, k)));
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
        public static int[] Transposed(int[] array, int key)
        {
            Console.WriteLine("-----TRANSPOSING-----");
            for (int i =0; i < array.Length;i++)
            {
                if(array[i] == key)
                {
                    (array[i], array[i-1]) = (array[i-1], array[i]);
                    return array;
                }
            }
            return array;
        }
        public static int[] Moving(int[] array, int key)
        {
            Console.WriteLine("-----MOVING-----");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    (array[0], array[i]) = (array[i], array[0]);
                    return array;
                }
            }
            return array;
        }
    }
}
