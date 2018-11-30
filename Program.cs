using System;
using ImageDistributor.Converters;
using ImageDistributor.Implementation;
using ImageDistributor.Models;

namespace ImageDistributor
{
    public class Program
    {
        private static ConstantValues _constantValues;

        static void Main(string[] args)
        {
            Console.WriteLine("##################A####################");
            Console.WriteLine("## Enter source path: ");
            var sourcePath = Console.ReadLine();
            Console.WriteLine("##################A####################");
            Console.WriteLine("## Enter destination path (has to be empty): ");
            var destinationPath = Console.ReadLine();
            Console.WriteLine("##################A####################");
            
            var filesHandler = new FilesHandler(new ConstantValues(sourcePath, destinationPath));
            var filesInfo = filesHandler.WithdrawFilesInfo();
            var filesInfoModels = filesInfo.ConvertToModels();

            Console.WriteLine("Push ENTER key to leave");
            Console.ReadLine();
        }
    }
}
