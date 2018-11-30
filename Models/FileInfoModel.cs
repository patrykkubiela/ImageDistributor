using System;

namespace ImageDistributor.Models
{
    public class FileInfoModel
    {
        public string FullPath { get; set; }
        public string FileName { get; set; }
        public DateTime CreatedUtcDate { get; set; }
    }
}