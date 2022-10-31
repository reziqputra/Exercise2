namespace Exercise
{
    class program
    {
        int[] reziq = new int[66];

        int n;

        int i;

        int RP;

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
            for(RP = 0; RP < n; RP++)
            {
                Console.Write('<' + (i + 1) + '>');
                string s1 = Console.ReadLine();
                reziq[i] = Int32.Parse(s1);
            }
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                if(reziq[RP])
            }
        }
    }
}