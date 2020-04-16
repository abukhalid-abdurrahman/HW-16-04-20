using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_13
{
    public static class ArrayHelper<T>
    {
        ///<summary>
        ///Удаляет последний элемент массива и возвращает этот удалённый элемент.
        ///</summary>
        public static T Pop(ref T[] array)
        {
            if(array != null)
            {
                int endElement = array.Length - 1;
                T results = array[endElement];
                List<T> list = new List<T>();
                list.AddRange(array);
                list.RemoveAt(endElement);
                array = list.ToArray();
                return results;
            }
            else
                return default(T);
        }

        ///<summary>
        ///Добавляет элемент с конца массива и возвращает обновленную длину массива
        ///</summary>
        public static int Push(ref T[] array, T element)
        {
            if(array != null)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = element;
            }
            return array.Length;
        }

        ///<summary>
        ///Удаляет первый элемент и возвращает этот удалённый элемент используя.
        ///</summary>
        public static T Shift(ref T[] array)
        {
            T results = default(T);
            if(array != null)
            {
                results = array[0];
                array = array.Skip(1).ToArray();
            }
            return results;
        }

        ///<summary>
        ///Добавляет элемент в начало массива и возвращает обновленную длину массива
        ///</summary>
        public static int UnShift(ref T[] array, T element)
        {
            if(array != null)
            {
                T[] edited = array.Prepend(element).ToArray();
                array = edited;
            }
            return array.Length;
        }

        ///<summary>
        ///Возвращает новый массив, содержащий копию части исходного массива.
        ///</summary>
        public static T[] Slice(T[] array, int beginIndex = 0, int endIndex = 0)
        {
            List<T> newArray = new List<T>();
            int arrSize = array.Length;
            if(endIndex == 0)
                endIndex = array.Length;
            if(beginIndex > array.Length - 1)
                return newArray.ToArray();
            else
            {
                if(beginIndex >= 0)
                {
                    if(endIndex > 0)
                    {
                        for(int i = beginIndex; i < endIndex; i++)
                        {
                            newArray.Add(array[i]);
                        }
                    }
                    else if (endIndex < 0)
                    {
                        for(int i = beginIndex; i < (arrSize + endIndex); i++)
                        {
                            newArray.Add(array[i]);
                        }
                    }
                }
                else if(beginIndex < 0)
                {
                        for(int i = 0; i < (arrSize + beginIndex); i++)
                        {
                            newArray.Add(array[i]);
                        }
                }
                return newArray.ToArray();
            }
        }

        public static void Output(T[] arr)
        {
            Array.ForEach(arr, it => {
                Console.Write(it + ", ");
            });
        }
    }
}