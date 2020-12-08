using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace CP77Tools
{
    class Program
    {
        [STAThread]
        public static async Task Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                while (true)
                {
                    string line = System.Console.ReadLine();
                    var parsed = ParseText(line, ' ', '"');
                    Parse(parsed.ToArray());
                }

            }
            else
            {
                Parse(args);
            }
        }

        internal static int Parse(string[] _args)
        {
            var result = Parser.Default.ParseArguments<
                    ArchiveOptions,
                    Cr2wOptions
                >(_args)
                        .MapResult(
                          (ArchiveOptions opts) => ConsoleFunctions.ArchiveTask(opts),
                          (Cr2wOptions opts) => ConsoleFunctions.Cr2wTask(opts),
                          
                          //errs => 1,
                          _ => /*Task.FromResult(1)*/1);
            return 1;
        }

        public static IEnumerable<String> ParseText(String line, Char delimiter, Char textQualifier)
        {

            if (line == null)
                yield break;

            else
            {
                Char prevChar = '\0';
                Char nextChar = '\0';
                Char currentChar = '\0';

                Boolean inString = false;

                StringBuilder token = new StringBuilder();

                for (int i = 0; i < line.Length; i++)
                {
                    currentChar = line[i];

                    if (i > 0)
                        prevChar = line[i - 1];
                    else
                        prevChar = '\0';

                    if (i + 1 < line.Length)
                        nextChar = line[i + 1];
                    else
                        nextChar = '\0';

                    if (currentChar == textQualifier && prevChar != 0x5c && !inString)
                    {
                        inString = true;
                        continue;
                    }

                    if (currentChar == textQualifier && inString)
                    {
                        inString = false;
                        continue;
                    }

                    if (currentChar == delimiter && !inString)
                    {
                        yield return token.ToString();
                        token = token.Remove(0, token.Length);
                        continue;
                    }

                    token = token.Append(currentChar);

                }

                yield return token.ToString();

            }
        }
    }
}
