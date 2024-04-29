// Объедините две предыдущих работы (практические работы 2 и 3): поиск файла и поиск текста в файле написав утилиту которая ищет файлы определенного расширения с указанным текстом.
// Рекурсивно. Пример вызова утилиты: utility.exe txt текст.
namespace Home8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            HomeWork.FindFiles("C:\\Users\\USER\\source\\repos", "*.txt", list);

            foreach (string file in list)
            {
                if (HomeWork.FindWord(file, "text") == true)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}