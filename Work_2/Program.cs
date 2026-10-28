// 26.10.2026 - 26 октября 2026 года

//============================================================================================================================================================================================================================================================================================================================

// Классная работа

//============================================================================================================================================================================================================================================================================================================================

// Задача "Восемь ферзей"

//============================================================================================================================================================================================================================================================================================================================

//var timeStart  = DateTime.Now;
//int count = 0;
//var p = new byte[9];

//for (byte j1 = 1; j1 <= 8; j1++)
//{
//    p[1] = j1;
//    for (byte j2 = 1; j2 <= 8; j2++)
//    {
//        p[2] = j2;
//        for (byte j3 = 1; j3 <= 8; j3++)
//        {
//            p[3] = j3;
//            for (byte j4 = 1; j4 <= 8; j4++)
//            {
//                p[4] = j4;
//                for (byte j5 = 1; j5 <= 8; j5++)
//                {
//                    p[5] = j5;
//                    for (byte j6 = 1; j6 <= 8; j6++)
//                    {
//                        p[6] = j6;
//                        for (byte j7 = 1; j7 <= 8; j7++)
//                        {
//                            p[7] = j7;
//                            for (byte j8 = 1; j8 <= 8; j8++)
//                            {
//                                p[8] = j8;

//                                int safePairs = 0;
//                                for (byte a = 1; a < 8; a++)
//                                {
//                                    for (byte b = (byte)(a + 1); b <= 8; b++)
//                                    {
//                                        bool sameRow = p[a] == p[b];
//                                        bool diag45 = (p[b] - p[a]) == (b - a);
//                                        bool diag135 = (p[a] + a) == (p[b] + b);

//                                        if (!sameRow && !diag45 && !diag135)
//                                        {
//                                            safePairs++;
//                                        }
//                                    }
//                                }

//                                if (safePairs == 28)
//                                {
//                                    bool onMainDiag = false;
//                                    for (int i = 1; i <= 8; i++)
//                                    {
//                                        if (i == p[i] || (i + p[i]) == 9)
//                                        {
//                                            onMainDiag = true;
//                                            break;
//                                        }
//                                    }

//                                    if (!onMainDiag)
//                                    {
//                                        count++;
//                                        Console.Write($"{count}):");
//                                        for (int i = 1; i <= 8; i++) Console.Write($"{p[i]} ");
//                                        Console.WriteLine();
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//        }
//    }
//}

//Console.WriteLine($"Всего допустимых расстановок: {count}");

//var timeFinish = DateTime.Now;
//var dt = timeFinish - timeStart;

//if (dt.TotalSeconds < 60)
//    Console.WriteLine($"Время поиска: {dt.Seconds} секунд");
//else if (dt.TotalMinutes < 60)
//    Console.WriteLine($"Время поиска: {dt.Minutes} мин. {dt.Seconds} сек.");
//else
//    Console.WriteLine($"Время поиска: {dt.Hours} ч. {dt.Minutes} мин. {dt.Seconds} сек.");

//============================================================================================================================================================================================================================================================================================================================

// Задача «Простые числа»

//============================================================================================================================================================================================================================================================================================================================

//Console.Write("Введите нижнюю границу простых чисел: ");
//long n_min = long.Parse(Console.ReadLine() ?? "0");
//Console.Write("Введите верхнюю границу простых чисел: ");
//long n_max = long.Parse(Console.ReadLine() ?? "0");

//if (n_min < 2) n_min = 2;
//if (n_max < n_min)
//{
//    Console.WriteLine("Ошибка: верхняя граница должна быть не меньше нижней.");
//    return;
//}

//var tstart = DateTime.Now;

//long limit = (long)Math.Sqrt(n_max) + 1;
//var basePrimes = new List<long>();
//bool[] isComposite = new bool[limit + 1];

//for (long i = 2; i <= limit; i++)
//{
//    if (!isComposite[i])
//    {
//        basePrimes.Add(i);
//        for (long j = i * i; j <= limit; j += i)
//            isComposite[j] = true;
//    }
//}

//int segmentSize = (int)(n_max - n_min + 1);
//bool[] segmentIsPrime = new bool[segmentSize];

//for (int i = 0; i < segmentSize; i++) segmentIsPrime[i] = true;

//foreach (var p in basePrimes)
//{
//    long start = ((n_min + p - 1) / p) * p;

//    if (start == p) start += p;

//    for (long j = start; j <= n_max; j += p)
//    {
//        segmentIsPrime[j - n_min] = false;
//    }
//}

//if (n_min == 1) segmentIsPrime[0] = false;

//var result = new List<long>();
//for (int i = 0; i < segmentSize; i++)
//{
//    if (segmentIsPrime[i])
//        result.Add(n_min + i);
//}

//var tfinish = DateTime.Now;
//var dt = tfinish - tstart;

//if (dt.TotalSeconds < 60)
//    Console.WriteLine($"Время поиска: {dt.Seconds} сек.");
//else if (dt.TotalMinutes < 60)
//    Console.WriteLine($"Время поиска: {dt.Minutes} мин. {dt.Seconds} сек.");
//else
//    Console.WriteLine($"Время поиска: {dt.Hours} ч. {dt.Minutes} мин. {dt.Seconds} сек.");

//int count = 0;
//foreach (var num in result)
//{
//    Console.Write(num + "\t");
//    count++;
//    if (count % 10 == 0) Console.WriteLine();
//}

//Console.WriteLine($"\nВсего найдено простых в диапазоне [{n_min}, {n_max}]: {result.Count}");
//Console.ReadKey();

//============================================================================================================================================================================================================================================================================================================================