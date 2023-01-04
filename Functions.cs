using System;
using System. Collections. Generic;
using System. Linq;
using System. Text;
using System. Threading. Tasks;
using static System. Formats. Asn1. AsnWriter;

namespace TheFirstProgram
    {
    public class Functions
        {
        /// <summary>
        /// Метод, который строит горизонтальные строки
        /// </summary>

        public static void constructionOfTheHorizontLines( int horizontalLine , ref int score , int verticalLine , string line )
            {
            if (score==0||score==( line. Length+2 )||score==( verticalLine )||score==( ( line. Length+2 )*2 ))
                {
                string horizontalLines =  new String('+' , horizontalLine); //построение горизонтальных строк
                Console. WriteLine (horizontalLines);
                }
            }


        /// <summary>
        /// Метод, который строит 1 строку
        /// </summary>

        public static void constructionOfTheFirstLine( int result , int horizontalLine , string line , ref int score )
            {
            if (score==0)
                {
                score++;
                }

            if (( line. Length/2 )>score||score<( line. Length+2 )) //построение 1 строки
                {
                string emptyString = new String(' ' , horizontalLine-2);
                string thefirst = '+'+emptyString+'+';
                Console. WriteLine (thefirst);

                if (score==( line. Length/2 ))
                    {
                    score++;
                    int distanceForPadLeft = ( result-1 )+line. Length; // формула нахождения расстояния для PadLeft
                    string concatStringAndSpace = '+'+line. PadLeft (distanceForPadLeft)+"+". PadLeft (horizontalLine-distanceForPadLeft-1); //конкатенация символа и слова с пробелами для 1 строки
                    Console. WriteLine (concatStringAndSpace);
                    }
                }
            }

        /// <summary>
        /// Метод, который строит 2 строку
        /// </summary>

        public static void constructionOfTheSecondLine( int horizontalLine , string line , ref int score )
            {
            if (score>( line. Length+2 )&&score<( ( line. Length+2 )*2 )) //построение 2 строк
                {
                string secondLine = string. Concat (Enumerable. Repeat ("+ " , ( ( horizontalLine-2 )/2 ))); //построение 2 строки
                string thesecond = secondLine+'+'+'+';
                Console. WriteLine (thesecond);

                if (score!=( line. Length+2 )*2-1)
                    {
                    score++;
                    }

                if (score<( line. Length+2 )*2&&score!=( line. Length+2 )*2-1)
                    {
                    string thethird = '+'+secondLine+'+';
                    Console. WriteLine (thethird);
                    }
                }
            }

        /// <summary>
        /// Метод, который строит 3 строку
        /// </summary>

        public static void constructionOfTheThirdLine( int horizontalLine , ref int score , int verticalLine , string line )
            {
            if (score==(((line.Length+2)*2)+1)&&score<verticalLine)
                {
                int lenghtTheThirdLine = horizontalLine-2;
                for (int i = 1 ; i<=lenghtTheThirdLine ; i++)
                    {
                    for (int j = 1 ; j<=horizontalLine ; j++)
                        {
                        if (( i+1 )==j||j==1||j==( horizontalLine-i ))
                            {
                            Console. Write ('+');
                            }
                        else if (j==horizontalLine)
                            {
                            Console. WriteLine ('+');
                            }
                        else
                            {
                            Console. Write (' ');
                            }
                        }
                    if (score!=verticalLine-1)
                        {
                        score++;
                        }
                    }
                }
            }
        }
    }


