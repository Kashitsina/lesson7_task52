void Zadacha52()
        {
            //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
             //элементов в каждом столбце.
            Random random = new Random();
            int rows = random.Next(1, 4);
            int columns = random.Next(1, 5);

            int[,] array = new int[rows, columns];
            FillArray(array);
            PrintArray(array);
            
            Console.WriteLine("Cреднее арифметическое элементов в каждом столбце");
            for (int j = 0; j < columns; j++)
            {
                double sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += array[i, j];
                }
                double average = sum / rows;
                Console.Write(sum/ rows + "\t");
            }


            void FillArray(int[,] array)
            {
                Random random = new Random();
                int rows = array.GetLength(0);
                int сolumns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = random.Next(0,10) ;
                    }
                }

            }

            void PrintArray(int[,] array)
            {
                Console.WriteLine();
                Console.WriteLine("Вывод массива");
                int rows = array.GetLength(0);
                int сolumns = array.GetLength(1);
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }

        Zadacha52();
        