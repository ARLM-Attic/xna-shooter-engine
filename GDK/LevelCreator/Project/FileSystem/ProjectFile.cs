using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packager.Project.FileSystem
{
    public class ProjectFile
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the path of the file on disk.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the type of file this ProjectFile represents.
        /// </summary>
        public ProjectFileType Type { get; set; }
    }
}
