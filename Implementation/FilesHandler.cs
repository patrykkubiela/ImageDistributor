using ImageDistributor.Models;
using System.IO;

namespace ImageDistributor.Implementation
{
    public class FilesHandler
    {
        private readonly ConstantValues _constantValues;

        public FilesHandler(ConstantValues constantValues)
        {
            _constantValues = constantValues;
        }

        public FileInfo[] WithdrawFilesInfo()
        {
            var directoryInfo = new DirectoryInfo(_constantValues.SourcePath);
            return directoryInfo.GetFiles("*.jpg");
        }
    }
}
