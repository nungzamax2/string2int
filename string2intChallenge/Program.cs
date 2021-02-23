using System;

namespace string2intChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)//for keep program continue input
            {
                Console.WriteLine("Input your string that mixed both numerical and alphabetical character");
                string input = Console.ReadLine();
                int result = string2intChallenge(input);//ในส่วนนี้ผมไม่แน่ใจเรื่องโจทย์ เพราะในโจทย์บอกว่าต้อง return เป็น integer เท่านั้นซึ่งตามหลักการแล้ว string input ถ้าส่งมาแต่ตัวอักษรไม่มีตัวเลข จะให้เป็น 0 หรือจะให้เป็น exception เพราะถ้าจะเอา return เป็น int จะต้องมีค่าให้เสมอที่นี้จึงมีค่าเป็น 0 หรือถ้าไม่มีตัวเลขก็ให้ return exception ขึ้นอยู่กับการใช้งาน
                Console.WriteLine($"Your input have integer = \"{result}\"");
            }
        }
        static int string2intChallenge(string input)
        {
            int output = 0;
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            foreach (var _char in input)
            {
                if (_char >= 48 && _char <= 57)
                {
                    output *= 10;
                    int realNum = _char - 48;
                    output += realNum;
                }
            }
            return output;
        }
    }
}
