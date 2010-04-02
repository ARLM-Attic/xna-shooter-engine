using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Packager.Project.FileSystem;

namespace Packager.Project
{
    public class PackageProject
    {
        public event EventHandler Saved;

        public event EventHandler Loaded;

        /// <summary>
        /// Gets or sets the type of package project.
        /// </summary>
        public PackageType PackageType { get; set; }

        /// <summary>
        /// Gets or sets the name of the package project.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the path of the directory that contains the project files.
        /// </summary>
        public string RootDirectory { get; set; }

        /// <summary>
        /// Gets or sets the references used by the package project.
        /// </summary>
        public object References { get; set; }

        /// <summary>
        /// Gets or sets the file system of the package project.
        /// </summary>
        public ProjectFolder FileSystem { get; set; }

        /// <summary>
        /// Gets or sets the path of the builds directory.
        /// </summary>
        public string BuildFolder { get; set; }

        /// <summary>
        /// Loads a project from disk.
        /// </summary>
        public void Load()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Saves the project to disk.
        /// </summary>
        public void Save()
        {
            throw new System.NotImplementedException();
        }
    }
}
