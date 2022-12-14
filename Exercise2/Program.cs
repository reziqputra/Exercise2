namespace Exercise
{
    class program
    {
        int[] reziq = new int[66];

        int n;

        int i;

        private int cmp_count = 0;
        private int mov_count = 0;
        public void input()
        {
            while(true)
            {
                Console.Write("Enter the number of element in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 66))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 66 elements. \n");
            }
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("---------------------");
            for(i = 0; i < n; i++)
            {
                Console.Write('<' + (i + 1) + '>');
                string s1 = Console.ReadLine();
                reziq[i] = Int32.Parse(s1);
            }
        }

        public void swap(int x, int y)
        {
            int temp;
            temp = reziq[x];
            reziq[x] = reziq[y];
            reziq[y] = temp;
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int RP = 1; RP < n; RP++)
                {
                    int temp;
                    temp = reziq[RP];
                    reziq[RP] = reziq[RP + 1];
                    reziq[RP + 1] = temp;
                }
            }
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, RP;
            if (low > high)
                return;

            i = low + 1;
            RP = high;

            pivot = reziq[low];

            while(i <= RP)
            {
                while((reziq[i]) <= pivot && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                while ((reziq[RP]) > pivot && (RP >= low))
                {
                    RP--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < RP)
                {
                    swap(i,RP);
                    mov_count++;
                }
            }

            if(low < RP)
            {
                swap(low, RP);
                mov_count++;
            }

            q_sort(low, RP - 1);

            q_sort(RP + 1, high);
        }

        static void Main(string[] args)
        {
            program myList = new program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("================");
                Console.WriteLine("1. Bublesort");
                Console.WriteLine("2. Quicksort");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choise (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch(pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("...................");
                        Console.WriteLine("Bublesort");
                        Console.WriteLine("...................");
                        myList.input();
                        myList.BubbleSortArray();
                        break;

                    case 2:

                        Console.WriteLine("Exit. ");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("\n\nPress Return to Exit. ");
                Console.ReadLine();
            } while(pilihanmenu != 2);
        }
    }
}