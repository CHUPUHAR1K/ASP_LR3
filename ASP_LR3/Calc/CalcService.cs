﻿namespace ASP_LR3.Calc
{
            public class CalcService : ICalcService
            {
                public T Addition<T>(params T[] numbers) where T : IConvertible
                {
                    if (numbers.Length == 0)
                    {
                        throw new ArgumentException("Вказати мінімум одне число");
                    }
                    dynamic res = numbers[0];
                    for (int i = 1; i < numbers.Length; i++) { res += numbers[i]; }
                    return res;
                }

                public T Subtraction<T>(params T[] numbers) where T : IConvertible
                {
                    if (numbers.Length == 0)
                    {
                        throw new ArgumentException("Вказати мінімум одне число");
                    }
                    dynamic res = numbers[0];
                    for (int i = 1; i < numbers.Length; i++) { res -= numbers[i]; }
                    return res;
                }

                public T Multiplication<T>(params T[] numbers) where T : IConvertible
                {
                    if (numbers.Length == 0)
                    {
                        throw new ArgumentException("Вказати мінімум одне число");
                    }
                    dynamic res = numbers[0];
                    for (int i = 1; i < numbers.Length; i++) { res *= numbers[i]; }
                    return res;
                }

                public T Division<T>(params T[] numbers) where T : IConvertible
                {
                    if (numbers.Length == 0)
                    {
                        throw new ArgumentException("Вказати мінімум одне число");
                    }
                    dynamic res = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i].ToDouble(null) == 0)
                        {
                            throw new DivideByZeroException("На 0 не ділиться");
                        }
                        res /= numbers[i].ToDouble(null);
                    }
                    return res;
                }
            }

}
