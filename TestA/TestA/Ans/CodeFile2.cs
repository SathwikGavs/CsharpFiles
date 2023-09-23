/*using System.Text;

namespace codefile1
{
    public class a2
    {

        int x = 0;

        public static void QuestionTwo()

        {

            // Local Variable

            int y = 100;

            //Console.WriteLine($"Global Variable x={x}");

            Console.WriteLine($"Local Variable y={y}");

        }



        // Write a function that can count the words in a string 

        public static void QuestionThreeA()

        {

            String strFriends = "Tom and Jerry are good friends"; string[] words = strFriends.Split(" ");

            int wordCount = words.Length;

            Console.WriteLine($"Word Count {wordCount}");

        }



        //  Write a function that can reverse the string

        public static void QuestionThreeB()

        {

            String strFriends = "Tom and Jerry are good friends";

            Console.WriteLine(strFriends);

            // first Method

            char[] charData = strFriends.ToCharArray();

            int len = charData.Length;

            StringBuilder sb = new StringBuilder(len + 10);

            for (int i = len - 1; i >= 0; i--)

            {

                sb.Append(charData[i]);

            }

            Console.WriteLine(sb.ToString());

            // Second Method

            var strReverse = strFriends.Reverse();

            foreach (var item in strReverse)

            {

                Console.Write(item);

            }

        }
    }
}
*/