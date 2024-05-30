using System;

namespace StringManipulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // (6) Yêu cầu người dùng nhập một chuỗi và lưu vào biến "userInput".
            Console.Write("Nhập vào một chuỗi: ");
            string userInput = Console.ReadLine();

            // (7) Gọi phương thức "ReverseString" với "userInput" làm tham số và in ra chuỗi đã đảo ngược.
            string reversedString = ReverseString(userInput);
            Console.WriteLine($"Chuỗi đảo ngược: {reversedString}");

            // (8) Yêu cầu người dùng nhập một chuỗi tìm kiếm và lưu vào biến "searchString".
            Console.Write("Nhập vào chuỗi tìm kiếm: ");
            string searchString = Console.ReadLine();

            // (9) Gọi phương thức "CountOccurrences" với "userInput" và "searchString" làm tham số và in ra số lần xuất hiện.
            int occurrences = CountOccurrences(userInput, searchString);
            Console.WriteLine($"Số lần xuất hiện của '{searchString}': {occurrences}");

            // (10) Yêu cầu người dùng nhập một chuỗi cũ và một chuỗi mới, và lưu chúng vào các biến "oldSubstring" và "newSubstring".
            Console.Write("Nhập vào chuỗi cũ để thay thế: ");
            string oldSubstring = Console.ReadLine();
            Console.Write("Nhập vào chuỗi mới: ");
            string newSubstring = Console.ReadLine();

            // (11) Gọi phương thức "ReplaceSubstring" với "userInput", "oldSubstring", và "newSubstring" làm tham số và in ra chuỗi đã sửa đổi.
            string modifiedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine($"Chuỗi đã sửa đổi: {modifiedString}");

            // (12) Gọi phương thức "RemoveWhitespace" với "userInput" làm tham số và in ra chuỗi không có khoảng trắng.
            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine($"Chuỗi không có khoảng trắng (từ chuỗi ban đầu): {stringWithoutWhitespace}");
        }

        // (2) Phương thức "ReverseString" đảo ngược chuỗi đầu vào.
        static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // (3) Phương thức "CountOccurrences" đếm số lần xuất hiện của chuỗi tìm kiếm trong chuỗi đầu vào.
        static int CountOccurrences(string inputString, string searchString)
        {
            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(searchString, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += searchString.Length;
            }

            return count;
        }

        // (4) Phương thức "ReplaceSubstring" thay thế tất cả các chuỗi cũ bằng chuỗi mới trong chuỗi đầu vào.
        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        // (5) Phương thức "RemoveWhitespace" loại bỏ tất cả các khoảng trắng trong chuỗi đầu vào.
        static string RemoveWhitespace(string inputString)
        {
            return string.Join("", inputString.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
