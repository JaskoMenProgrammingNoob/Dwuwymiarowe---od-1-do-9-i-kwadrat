using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int l = 0;
        int potega = 0;
        int[,] macierz = new int[n, n];
        int sumak1 = 0;
        int sumak2 = 0;
        for (int i = 0; i < n; i++)
        {

            /* Console.WriteLine(i); */
            for (int j = 0; j < n; j++)
            {
                
                if (j == 0)
                {

                    macierz[i, j] = i;
                    
                    
                }
                else if (j > 1)
                {
                    macierz[i, j] = 0;
                    

                }
                if(j == 1)
                {
                    macierz[i, j] = i * i;
                }
                
            }
        }
        for (int i = 0; i < n; i++)
        {

            /* Console.WriteLine(i); */
            for (int j = 0; j < n; j++)
            {
                
                Console.Write($"{macierz[i,j],4}");
                

            }
            Console.WriteLine();


        }
        for (int i = 0; i < n; i++)
        {
            
           
            sumak1 += macierz[i, 0];
                sumak2 += macierz[i, 1];
            
           
            
        }
        Console.Write($"suma 1: {sumak1} suma 2: {sumak2}");
        

    }
}
