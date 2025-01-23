namespace CSharpFund.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(">> ");
                var input = Console.ReadLine().Trim();

                if (input == "exit")
                    break;
                
                var whiteSpaceIndex = input.IndexOf(' ');
                var command = input.Substring(0, whiteSpaceIndex);
                var path = input.Substring(whiteSpaceIndex + 1);
               
                if (command == "list")
                {
                    foreach (var entry in Directory.GetDirectories(path))
                    {
                        Console.WriteLine($"- [Dir]: {entry}");
                    }

                    foreach (var entry in Directory.GetFiles(path))
                    {
                        Console.WriteLine($"- [File]: {entry}");
                    }
                } 
                else if (command == "info")
                {
                    if (File.Exists(path))
                    {
                        var infoFile = new FileInfo(path);
                        Console.WriteLine($"- Name: {infoFile.Name}");
                        Console.WriteLine($"- Last Write Time: {infoFile.LastAccessTime}");
                        Console.WriteLine($"- Length File: {infoFile.Length} Bytes");
                    }

                    if (Directory.Exists(path))
                    {
                        var infoDir = new DirectoryInfo(path);
                        Console.WriteLine($"- Name: {infoDir.Name}");
                        Console.WriteLine($"- Creation Time: {infoDir.CreationTime}");
                    }
                }
                else if (command == "mkdir")
                {
                    var dir = Directory.CreateDirectory(path);
                    Console.WriteLine($"Done created new dir {dir.Name}");                    
                }
                else if (command == "remove")
                {
                    if (Directory.Exists(path))
                        Directory.Delete(path, true);

                    if (File.Exists(path))
                        File.Delete(path);
                }
                else if (command == "print")
                {
                    if (File.Exists(path))
                        Console.WriteLine(File.ReadAllText(path));
                }
                else
                {
                    Console.WriteLine("Try again");
                    break;
                }
            }
        }
    }
}
