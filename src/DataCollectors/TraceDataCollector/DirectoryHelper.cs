﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TraceCollector
{
    using System.IO;
    using Interfaces;

    /// <inheritdoc />
    internal class DirectoryHelper : IDirectoryHelper
    {
        /// <inheritdoc />
        public void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }

        /// <inheritdoc />
        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        /// <inheritdoc />
        public bool Exists(string path)
        {
            return Directory.Exists(path);
        }
    }
}