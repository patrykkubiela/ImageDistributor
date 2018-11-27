using System;

namespace ImageDistributor
{
    public class ConstantValues
    {
        public string SourcePath { get; private set; }
        public string DestinationPath { get; private set; }

        public ConstantValues(string sourcePath, string destinationPath)
        {
            SourcePath = sourcePath;
            DestinationPath = destinationPath;
        }
    }
}