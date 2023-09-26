using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_AzureKeyVault_Certificates
{
    public static class ConsoleReader
    {
        public static Uri GetUrl()
        {
            Console.WriteLine("Insert the Key Vault url..");
            var url = ForceReadLine("Enter a valid url...");
            return new Uri(url);
        }

        private static string ForceReadLine(string? retryMessage = null)
        {
            string? content = null;

            do
            {
                content = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(retryMessage) && string.IsNullOrWhiteSpace(content))
                {
                    Console.WriteLine(retryMessage);
                }

            } while (string.IsNullOrWhiteSpace(content));

            return content;
        }
    }
}
