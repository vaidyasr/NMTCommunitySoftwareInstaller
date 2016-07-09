﻿using TransmissionApplicationUploader;

namespace com.nmtinstaller.csi.RemoteFileInfo
{
    public class RepositoryCustomMenuInfo : RepositoryFileInfoBase
    {
        public RepositoryCustomMenuInfo(string Name, string Author, string Maintainer, string Version, string Homepage, string Forum, string Description, string Changelog, string UsageInstructions, string DownloadURL, string[] Screenshots)
            : base(Name, Author, Maintainer, Version, Homepage, Forum, Description, Changelog, UsageInstructions, DownloadURL, Screenshots)
        {
        }
    }
}