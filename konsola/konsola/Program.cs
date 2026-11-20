using System;
using System.Collections.Generic;


namespace MainProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] tablica = new int[100];
            FillArray(tablica);
            Console.WriteLine("Tablica przed sortowaniem:");
            foreach (int element in tablica)
            {
                Console.Write(element + " ");
            }
            BubbleSort(tablica);
            Console.WriteLine("\nTablica po sortowaniu:");
            foreach (int element in tablica)
            {
                Console.Write(element + " ");
            }
        }

        public static void BubbleSort(int[] tablica)
        {
            int n =  tablica.Length;

            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if(tablica[j] > tablica[j + 1])
                    {
                         int temp = tablica[j];
                         tablica[j] = tablica[j + 1];
                         tablica[j + 1] = temp;
                    }
                }
            }
        }

        public static void FillArray(int[] tablica)
        {
            Random rand = new Random();
            for(int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.Next(1, 100);
            }
        }
    }
}