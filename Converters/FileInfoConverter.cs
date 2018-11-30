using System.IO;
using System.Linq;
using ImageDistributor.Models;

namespace ImageDistributor.Converters
{
    public static class FileInfoConverter
    {
         private static FileInfoModel ConvertToModel(this FileInfo fileInfo)
        {
            return new FileInfoModel()
            {
                CreatedUtcDate = fileInfo.CreationTimeUtc,
                FileName = fileInfo.Name,
                FullPath = fileInfo.DirectoryName
            };
        }

        public static FileInfoModel[] ConvertToModels(this FileInfo[] fileInfos)
        {
            return fileInfos?.Select(f => f.ConvertToModel()).ToArray();
        }
    }
}