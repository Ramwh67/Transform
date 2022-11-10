using System;

namespace HomeTasks_KisEA
{
    class Program
    {
        static void Main (string[] args)
        {   
            int findCount(string[] strArray)
            {
                int count=0;
                for (int i=0; i<strArray.Length; i++)
                {
                    if (strArray[i].Length<=3) count++;
                }
                return count;
            }

            string[] createNewArray(string[] strArray)
            {
                int count = findCount(strArray);
                string[] newStrArray = new string[count];
                count = 0;
                for (int i=0; i<strArray.Length; i++)
                {
                    if (strArray[i].Length<=3)
                    {
                        newStrArray[count] = strArray[i];
                        count++;
                    }
                }
                return newStrArray;
            }

            void printArray(string[] someStrArray)          //Метод печатает строковый массив
            {
                for(int i = 0; i < someStrArray.Length; i++)
                {
                    Console.Write($"{someStrArray[i]}  ");
                }
            }


            string[] strArray = {"Hello", "2", "world", ":-)"};
            //string[] strArray = {"1234", "1567", "-2", "computer science"};
            //string[] strArray = {"Russia", "Denmark", "Kazan"};
            string[] newStrArray = createNewArray(strArray);
            printArray(newStrArray);

        }
    }
}