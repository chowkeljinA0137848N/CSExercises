using System;

namespace CSExercises
{
    public class Ex43
    {

        public static string Hex(int i)
        {
            string h = "";

            switch (i % 16)
            {
                case 1:
                    h = "A"; break;

                case 2:
                    h = "B"; break;

                case 3:
                    h = "C"; break;

                case 4:
                    h = "D"; break;
                    
                case 5:
                    h = "E"; break;

                case 6:
                    h = "F"; break;

                default:
                    h = Convert.ToString(i); break;


            }

            return h;
        }
    }
}
