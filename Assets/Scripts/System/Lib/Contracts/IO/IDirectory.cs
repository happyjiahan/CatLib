﻿using System;
using System.IO;

namespace CatLib.Contracts.IO
{

    public interface IDirectory
    {

        string Path{ get; }

        string Name { get; }

        void Delete();

        void Create();

        IDirectory Refresh();

        IDirectory Duplicate(string copyDirectroy);








        void CopyTo(string path, string targetPath);

        void Create(string path, bool isOverride = false);

        bool Exists(string path);

        FileInfo[] Walk(string path);

        void Walk(string path, Action<FileInfo> callBack);

    }

}