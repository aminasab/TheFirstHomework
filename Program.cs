namespace TheFirstProgram
    {
    internal class Program
        {
        static void Main( string[] args )
            {
            string? line;
            int result = 0;

            do //проверка введенных данных
                {
                Console. WriteLine ("Введите размерность таблицы (число в диапазоне от 1 до 6)");
                string? check = Console. ReadLine ();
                try
                    {
                    result=int. Parse (check);
                    }
                catch (FormatException)
                    {
                    Console. WriteLine ("Введена "+check);
                    }

                if (1<=result&result<=6)
                    {
                    Console. WriteLine ("Данные введены верно");
                    }
                else Console. WriteLine ("Попробуйте ввести еще раз, число должно быть в диапазоне от 1 до 6");
                } while (result>6|result<1);

            do
                {
                int limit = 40-( result*2-2 );
                Console. WriteLine ($"Введите строку, состоящую из не более {limit} символов");
                line=Console. ReadLine (). Trim ();
                } while (line. Length==0);

            Console. WriteLine ("Данные введены успешно");
            Console. Clear ();
            int horizontalLine = result*2+line. Length; // нахождение длины горизонтальной линии
            int verticalLine = ( line. Length+1 )*4+3; // нахождение длины вертикальной линии

            for (int score = 0 ; score<=( verticalLine ) ; score++)
                {
                for (int lineCout = 0 ; lineCout<=3 ; lineCout++)
                    {
                    switch (lineCout)
                        {
                        case 0:
                            Functions. constructionOfTheHorizontLines (horizontalLine , ref score , verticalLine , line);
                            break;
                        case 1:
                            Functions. constructionOfTheFirstLine (result , horizontalLine , line , ref score);
                            break;
                        case 2:
                            Functions. constructionOfTheSecondLine (horizontalLine , line , ref score);
                            break;
                        case 3:
                            Functions. constructionOfTheThirdLine (horizontalLine , ref score , verticalLine , line);
                            break;
                        }
                    }
                }
            }
        }
    }



