using System;

namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            if (s1.Contains(s2))
                return s1.IndexOf(s2);

            else
                return -1;
        }
    }
}
