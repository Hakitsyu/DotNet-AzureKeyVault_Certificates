using Azure.Identity;
using Azure.Security.KeyVault.Certificates;
using DotNet_AzureKeyVault_Certificates;

var clientUrl = ConsoleReader.GetUrl();
var client = new CertificateClient(clientUrl, new DefaultAzureCredential());

Console.WriteLine("Listing certificates...");
var certificates = client.GetPropertiesOfCertificates();
if (!certificates.Any())
{
    Console.WriteLine("This Vault don't have certificates");
    return;
}

foreach (var certificate in certificates)
{
    Console.WriteLine($"Name {certificate.Name}, Id {certificate.Id}");
}