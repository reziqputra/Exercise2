﻿namespace Exercise
{
    class program
    {
        int[] reziq = new int[66];

        int n;

        int i;

        public void input()
        {
            while(true)
            {
                Console.Write('Enter the number of element in the array: ');
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 66))
                    break;
                else
                    Console.WriteLine('\nArray should have minimum 1 and maximum 66 elements. \n');
            }
            Console.WriteLine('');
            Console.WriteLine('---------------------');
            Console.WriteLine(' Enter array elements');
            Console.WriteLine('---------------------');
            for(i = 0; i < n; i++)
            {
                Console.Write('<' + (i + 1) + '>');
                string s1 = Console.ReadLine();
                reziq[i] = Int32.Parse(s1);
            }
        }
    }
}