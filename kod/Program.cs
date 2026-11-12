using System;

namespace kod
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==========================================
            // ЗАДАНИЕ 1: Счётчик от 1 до 20
            // ==========================================
            int i1 = 1;
            while (i1 <= 20)
            {
                Console.Write(i1 + " ");
                i1 = i1 + 1;
            }
            Console.WriteLine();

            for (int j1 = 1; j1 <= 20; j1++)
            {
                Console.Write(j1 + " ");
            }
            Console.WriteLine("\n");

            // ==========================================
            // ЗАДАНИЕ 2: Обратный отсчёт
            // ==========================================
            for (int k = 15; k >= 0; k--)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine("\nСтарт!\n");

            // ==========================================
            // ЗАДАНИЕ 3: Чётные числа
            // ==========================================
            for (int n = 2; n <= 50; n = n + 2)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n");

            // ==========================================
            // ЗАДАНИЕ 4: Сумма первых N чисел
            // ==========================================
            Console.Write("Введите число N: ");
            string textN = Console.ReadLine();
            int nInput = Convert.ToInt32(textN);

            if (nInput < 1)
            {
                Console.WriteLine("Ошибка: N должно быть больше или равно 1.");
            }
            else
            {
                int sum4 = 0;
                int count4 = 1;
                while (count4 <= nInput)
                {
                    sum4 = sum4 + count4;
                    count4++;
                }
                Console.WriteLine("Сумма чисел от 1 до " + nInput + " = " + sum4);
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 5: Таблица умножения
            // ==========================================
            Console.Write("Введите число: ");
            string textMult = Console.ReadLine();
            int multNum = Convert.ToInt32(textMult);

            for (int m = 1; m <= 10; m++)
            {
                Console.WriteLine(multNum + " x " + m + " = " + (multNum * m));
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 6: Количество цифр
            // ==========================================
            Console.Write("Введите положительное целое число: ");
            string textNum = Console.ReadLine();
            int number6 = Convert.ToInt32(textNum);

            if (number6 > 0)
            {
                int digitsCount = 0;
                int tempNumber = number6;
                while (tempNumber > 0)
                {
                    tempNumber = tempNumber / 10;
                    digitsCount++;
                }
                Console.WriteLine("В числе " + number6 + " количество цифр: " + digitsCount);
            }
            else
            {
                Console.WriteLine("Ошибка: число должно быть положительным.");
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 7: Первые массивы
            // ==========================================
            int[] array7 = { 5, 10, 15, 20, 25, 30, 35, 40 };
            Console.WriteLine("Длина массива: " + array7.Length);
            for (int i = 0; i < array7.Length; i++)
            {
                Console.WriteLine("Индекс: " + i + ", Значение: " + array7[i]);
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 8: Изменение элемента
            // ==========================================
            int[] grades8 = { 3, 4, 2, 5, 4 };
            grades8[2] = 5;
            for (int i = 0; i < grades8.Length; i++)
            {
                Console.Write(grades8[i] + " ");
            }
            Console.WriteLine("\n");

            // ==========================================
            // ЗАДАНИЕ 9: Сумма и среднее
            // ==========================================
            int[] array9 = { 10, 20, 30, 40, 50 };
            int sum9 = 0;
            for (int i = 0; i < array9.Length; i++)
            {
                sum9 = sum9 + array9[i];
            }
            double average9 = (double)sum9 / array9.Length;
            Console.WriteLine("Сумма элементов: " + sum9);
            Console.WriteLine("Среднее арифметическое: " + average9);
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 10: Максимум и минимум
            // ==========================================
            int[] array10 = { 15, 3, 88, 42, 7, 21 };
            if (array10.Length == 0)
            {
                Console.WriteLine("Массив пуст!");
            }
            else
            {
                int max10 = array10[0];
                int min10 = array10[0];
                for (int i = 1; i < array10.Length; i++)
                {
                    if (array10[i] > max10) max10 = array10[i];
                    if (array10[i] < min10) min10 = array10[i];
                }
                Console.WriteLine("Максимальный элемент: " + max10);
                Console.WriteLine("Минимальный элемент: " + min10);
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 11: Количество положительных
            // ==========================================
            int[] array11 = { 5, -3, 0, 12, -8, 4, 0, 9 };
            int pos11 = 0;
            int neg11 = 0;
            int zero11 = 0;
            for (int i = 0; i < array11.Length; i++)
            {
                if (array11[i] > 0) pos11++;
                else if (array11[i] < 0) neg11++;
                else zero11++;
            }
            Console.WriteLine("Положительных: " + pos11);
            Console.WriteLine("Отрицательных: " + neg11);
            Console.WriteLine("Нулевых: " + zero11);
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 12: Первый индекс
            // ==========================================
            int[] array12 = { 10, 20, 30, 40, 30, 50 };
            int target12 = 30;
            int foundIndex12 = -1;
            for (int i = 0; i < array12.Length; i++)
            {
                if (array12[i] == target12)
                {
                    foundIndex12 = i;
                    break;
                }
            }
            if (foundIndex12 != -1)
                Console.WriteLine("Число " + target12 + " найдено под индексом: " + foundIndex12);
            else
                Console.WriteLine("-1 (число не найдено)");
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 13: Последний индекс
            // ==========================================
            int[] array13 = { 5, 10, 15, 10, 20, 10 };
            int target13 = 10;
            int lastIndex13 = -1;
            for (int i = array13.Length - 1; i >= 0; i--)
            {
                if (array13[i] == target13)
                {
                    lastIndex13 = i;
                    break;
                }
            }
            Console.WriteLine("Индекс последнего вхождения числа " + target13 + ": " + lastIndex13);
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 14: Переворот массива
            // ==========================================
            int[] array14 = { 1, 2, 3, 4, 5 };
            Console.Write("Обратный порядок: ");
            for (int i = array14.Length - 1; i >= 0; i--)
            {
                Console.Write(array14[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array14.Length / 2; i++)
            {
                int temp14 = array14[i];
                array14[i] = array14[array14.Length - 1 - i];
                array14[array14.Length - 1 - i] = temp14;
            }
            Console.Write("Измененный массив: ");
            for (int i = 0; i < array14.Length; i++)
            {
                Console.Write(array14[i] + " ");
            }
            Console.WriteLine("\n");

            // ==========================================
            // ЗАДАНИЕ 15: Проверка сортировки
            // ==========================================
            int[] array15 = { 1, 3, 5, 7, 9 };
            bool isSorted15 = true;
            for (int i = 0; i < array15.Length - 1; i++)
            {
                if (array15[i] > array15[i + 1])
                {
                    isSorted15 = false;
                    break;
                }
            }
            if (isSorted15) Console.WriteLine("Массив отсортирован по неубыванию.");
            else Console.WriteLine("Массив НЕ отсортирован.");
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 16: Вторая по величине
            // ==========================================
            int[] array16 = { 10, 50, 30, 50, 20, 40 };
            int max1_16 = int.MinValue;
            int max2_16 = int.MinValue;
            for (int i = 0; i < array16.Length; i++)
            {
                if (array16[i] > max1_16)
                {
                    max2_16 = max1_16;
                    max1_16 = array16[i];
                }
                else if (array16[i] > max2_16 && array16[i] < max1_16)
                {
                    max2_16 = array16[i];
                }
            }
            if (max2_16 == int.MinValue) Console.WriteLine("В массиве нет двух различных чисел.");
            else Console.WriteLine("Второе по величине число: " + max2_16);
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 17: Вложенный прямоугольник
            // ==========================================
            Console.Write("Введите количество строк (R): ");
            int r17 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов (C): ");
            int c17 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < r17; i++)
            {
                for (int j = 0; j < c17; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 18: Треугольник
            // ==========================================
            int n18 = 5;
            for (int i = 1; i <= n18; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 19: Сдвиг вправо
            // ==========================================
            int[] array19 = { 1, 2, 3, 4, 5 };
            int lastElement19 = array19[array19.Length - 1];
            for (int i = array19.Length - 1; i > 0; i--)
            {
                array19[i] = array19[i - 1];
            }
            array19[0] = lastElement19;
            Console.Write("Массив после сдвига: ");
            for (int i = 0; i < array19.Length; i++)
            {
                Console.Write(array19[i] + " ");
            }
            Console.WriteLine("\n");

            // ==========================================
            // ЗАДАНИЕ 20: Удаление дублей (вывод)
            // ==========================================
            int[] array20 = { 5, 3, 5, 2, 3, 8, 2, 5 };
            Console.Write("Уникальные числа: ");
            for (int i = 0; i < array20.Length; i++)
            {
                bool isDuplicate20 = false;
                for (int j = 0; j < i; j++)
                {
                    if (array20[i] == array20[j])
                    {
                        isDuplicate20 = true;
                        break;
                    }
                }
                if (isDuplicate20 == false)
                {
                    Console.Write(array20[i] + " ");
                }
            }
            Console.WriteLine("\n");

            // ==========================================
            // ЗАДАНИЕ 21: Поиск пары
            // ==========================================
            int[] array21 = { 2, 7, 11, 15, 4, 8 };
            int targetSum21 = 19;
            bool pairFound21 = false;
            for (int i = 0; i < array21.Length; i++)
            {
                for (int j = i + 1; j < array21.Length; j++)
                {
                    if (array21[i] + array21[j] == targetSum21)
                    {
                        Console.WriteLine("Найдена пара! Индексы: " + i + " и " + j);
                        pairFound21 = true;
                        break;
                    }
                }
                if (pairFound21) break;
            }
            if (!pairFound21) Console.WriteLine("Нет пары");
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 22: Прямоугольная матрица
            // ==========================================
            int[,] matrix22 = new int[3, 4];
            int counter22 = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix22[i, j] = counter22;
                    counter22++;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int rowSum22 = 0;
                for (int j = 0; j < 4; j++)
                {
                    rowSum22 = rowSum22 + matrix22[i, j];
                }
                Console.WriteLine("Сумма элементов строки " + i + ": " + rowSum22);
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 23: Пузырьковая сортировка
            // ==========================================
            int[] array23 = { 5, 1, 4, 2, 8 };
            Console.WriteLine("Исходный массив: 5 1 4 2 8");
            for (int i = 0; i < array23.Length - 1; i++)
            {
                bool swapped23 = false;
                for (int j = 0; j < array23.Length - 1 - i; j++)
                {
                    if (array23[j] > array23[j + 1])
                    {
                        int temp23 = array23[j];
                        array23[j] = array23[j + 1];
                        array23[j + 1] = temp23;
                        swapped23 = true;
                    }
                }
                Console.Write("Проход " + (i + 1) + ": ");
                for (int k = 0; k < array23.Length; k++)
                {
                    Console.Write(array23[k] + " ");
                }
                Console.WriteLine();
                if (swapped23 == false) break;
            }
            Console.WriteLine();

            // ==========================================
            // ЗАДАНИЕ 24: Итог: склад экспедиции
            // ==========================================
            int[] storage24 = { 12, 0, 45, 8, 0, 15, 22, 3, 9, 0 };
            int totalSum24 = 0;
            int maxVal24 = storage24[0];
            int minVal24 = storage24[0];
            for (int i = 0; i < storage24.Length; i++)
            {
                totalSum24 = totalSum24 + storage24[i];
                if (storage24[i] > maxVal24) maxVal24 = storage24[i];
                if (storage24[i] < minVal24) minVal24 = storage24[i];
            }
            Console.WriteLine("Сумма всех значений: " + totalSum24);
            Console.WriteLine("Максимум: " + maxVal24);
            Console.WriteLine("Минимум: " + minVal24);

            int emptyCount24 = 0;
            Console.Write("Индексы пустых складов: ");
            for (int i = 0; i < storage24.Length; i++)
            {
                if (storage24[i] == 0)
                {
                    Console.Write(i + " ");
                    emptyCount24++;
                }
            }
            Console.WriteLine("\nВсего пустых: " + emptyCount24);

            Console.Write("Введите число для поиска на складе: ");
            int searchTarget24 = Convert.ToInt32(Console.ReadLine());
            int foundIndex24 = -1;
            for (int i = 0; i < storage24.Length; i++)
            {
                if (storage24[i] == searchTarget24)
                {
                    foundIndex24 = i;
                    break;
                }
            }
            if (foundIndex24 != -1)
                Console.WriteLine("Первое вхождение числа " + searchTarget24 + " под индексом: " + foundIndex24);
            else
                Console.WriteLine("Число " + searchTarget24 + " не найдено.");

            Console.ReadLine();
        }
    }
}