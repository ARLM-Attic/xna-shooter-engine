using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packager.Project.FileSystem
{
    public class ProjectFolder
    {
        private List<ProjectFolder> childFolders;
        private List<ProjectFile> childFiles;

        public ProjectFolder()
        {
            childFolders = new List<ProjectFolder>();
            childFiles = new List<ProjectFile>();
        }

        /// <summary>
        /// Gets or sets the name of the project folder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of project folder.
        /// </summary>
        public ProjectFolderType Type { get; set; }

        /// <summary>
        /// Gets or sets the child ProjectFolders within this ProjectFolder.
        /// </summary>
        public List<ProjectFolder> ChildFolders
        {
            get { return childFolders; }
            set { childFolders = value; }
        }

        /// <summary>
        /// Gets or sets the ProjectFiles contained within this ProjectFolder.
        /// </summary>
        public List<ProjectFile> ChildFiles
        {
            get { return childFiles; }
            set { childFiles = value; }
        }

        /// <summary>
        /// Gets or sets the path of the folder on disk.
        /// </summary>
        public string Path { get; set; }

        /// <param name="DeleteFromDisk">Specifies whether or not to delete the folder from disk after removing it from the project.</param>
        public void RemoveChild(bool DeleteFromDisk)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Adds a ProjectFile object as a child of this ProjectFolder.
        /// </summary>
        /// <param name="File">The ProjectFile to add to the ChildFiles collection.</param>
        public void AddChild(ProjectFile File)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Adds a ProjectFolder object as a child of this ProjectFolder.
        /// </summary>
        /// <param name="Folder">The ProjectFolder to add to the ChildFolders collection.</param>
        public void AddChild(ProjectFolder Folder)
        {
            throw new System.NotImplementedException();
        }
    }
}
