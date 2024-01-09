namespace vector5
{
    class program
    {
        public static void Main(String[] args)
        {
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];

            Console.WriteLine("DATOS VECTOR 1");
            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("DATOS VECTOR 2");
            for (int i = 0; i < vector2.Length; i++)
            {
                vector2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("DATOS VECTOR 3");
            for (int i = 0; i < vector3.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
                Console.WriteLine(vector3[i]);
            }


        }
    }
}
