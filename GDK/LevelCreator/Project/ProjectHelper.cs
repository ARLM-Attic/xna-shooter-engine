using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Packager.Project.FileSystem;
using System.Xml;
using System.Reflection;

namespace Packager.Project
{
    public class ProjectHelper
    {
        public event EventHandler ProjectCreated;

        public event EventHandler ProjectCreationProgressChanged;

        /// <summary>
        /// Creates a new project with the specified parameters.
        /// </summary>
        /// <param name="ProjectName">The name of the new package project.</param>
        /// <param name="ProjectLocation">The location in which to create the new package project.</param>
        /// <param name="ProjectType">The type of package project to create.</param>
        public void CreateNewProject(string ProjectName, string ProjectLocation, PackageType ProjectType)
        {
            PackageProject project = new PackageProject();
            string projectRoot = ProjectLocation + "\\" + ProjectName;

            // Set the basic project properties
            project.ProjectName = ProjectName;
            project.RootDirectory = projectRoot;

            // Create the project directory structure
            Directory.CreateDirectory(projectRoot); // Create the project root folder
            Directory.CreateDirectory(projectRoot + "\\Builds"); // Create the builds folder

            ProjectFolder fileSystemRoot = new ProjectFolder(); // Create the folder that represents the root of the project file system
            fileSystemRoot.Name = "{FSROOT}"; // Set the FSROOT tag. Not meant for end-user display
            fileSystemRoot.Path = projectRoot;
            fileSystemRoot.ChildFolders.Add(CreateDefaultContentFolder(projectRoot));

            project.FileSystem = fileSystemRoot;

            // Create the project file itself
            XmlDocument projectFile = GenerateProjectFile(project);
            projectFile.Save(projectRoot + "\\" + project.ProjectName + ".pkgprj");

            OnProjectCreated(new EventArgs());
        }

        public void OnProjectCreated(EventArgs e)
        {
            if (ProjectCreated != null)
                ProjectCreated(this, e);
        }

        /// <summary>
        /// Generates the XmlDocument representation of the project file.
        /// </summary>
        public System.Xml.XmlDocument GenerateProjectFile(PackageProject packageProject)
        {
            XmlDocument doc = new XmlDocument();
           
            XmlElement root = doc.CreateElement("PackageProject");
            XmlAttribute rootGenVers = doc.CreateAttribute("GeneratorVersion");

            XmlElement project = doc.CreateElement("Project");
            XmlElement projectName = doc.CreateElement("Name");
            XmlElement projectType = doc.CreateElement("Type");

            XmlElement fileSystem = doc.CreateElement("FileSystem");

            rootGenVers.Value = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // <Project> child nodes
            projectName.InnerText = packageProject.ProjectName;

            switch (packageProject.PackageType)
            {
                case PackageType.Compiled:
                    projectType.InnerText = "CompiledPackage";
                    break;
                case PackageType.FreeStanding:
                    projectType.InnerText = "FreeStandingPackage";
                    break;
            }

            project.AppendChild(projectName);
            project.AppendChild(projectType);

            // <FileSystem> child nodes
            foreach (ProjectFolder folder in packageProject.FileSystem.ChildFolders)
            {
                fileSystem.AppendChild(GetProjectFolderXmlElement(doc, folder));
            }

            // <PackageProject> child nodes
            root.AppendChild(project);
            root.AppendChild(fileSystem);
            root.Attributes.Append(rootGenVers);

            // Add everything to the document
            doc.AppendChild(root);

            return doc;
        }

        public XmlElement GetProjectFolderXmlElement(XmlDocument projectDoc, ProjectFolder folder)
        {
            XmlElement folderElement = projectDoc.CreateElement("Folder");
            XmlAttribute folderName = projectDoc.CreateAttribute("Name");
            XmlAttribute folderType = projectDoc.CreateAttribute("Type");

            folderName.Value = folder.Name;

            switch (folder.Type)
            {
                case ProjectFolderType.Content:
                    folderType.Value = "ProjectFolder.Content";
                    break;
                case ProjectFolderType.Folder:
                    folderType.Value = "ProjectFolder.Folder";
                    break;
                case ProjectFolderType.Meshes:
                    folderType.Value = "ProjectFolder.Meshes";
                    break;
                case ProjectFolderType.Scenery:
                    folderType.Value = "ProjectFolder.Scenery";
                    break;
                case ProjectFolderType.Shaders:
                    folderType.Value = "ProjectFolder.Shaders";
                    break;
                case ProjectFolderType.Textures:
                    folderType.Value = "ProjectFolder.Textures";
                    break;
            }

            folderElement.Attributes.Append(folderName);
            folderElement.Attributes.Append(folderType);

            foreach (ProjectFile file in folder.ChildFiles)
            {
                XmlElement fileElement = projectDoc.CreateElement("File");
                XmlAttribute fileName = projectDoc.CreateAttribute("Name");
                XmlAttribute fileType = projectDoc.CreateAttribute("Type");

                fileName.Value = file.Name;
                fileType.Value = file.Type.ToString();

                fileElement.Attributes.Append(fileName);
                fileElement.Attributes.Append(fileType);

                folderElement.AppendChild(fileElement);
            }

            foreach (ProjectFolder childFolder in folder.ChildFolders)
            {
                folderElement.AppendChild(GetProjectFolderXmlElement(projectDoc, childFolder));
            }

            return folderElement;
        }

        public ProjectFolder CreateDefaultContentFolder(string ProjectRootDirectory)
        {
            string contentRoot = ProjectRootDirectory + "\\Content";

            // Create the directory structure
            Directory.CreateDirectory(contentRoot);
            Directory.CreateDirectory(contentRoot + "\\Shaders");
            Directory.CreateDirectory(contentRoot + "\\Scenery");
            Directory.CreateDirectory(contentRoot + "\\Meshes");
            Directory.CreateDirectory(contentRoot + "\\Textures");

            #region ProjectFolder Generation

            // Create the Content folder object
            ProjectFolder contentFolder = new ProjectFolder()
            {
                Name = "Content",
                Path = contentRoot,
                Type = ProjectFolderType.Content
            };

            // Create the Shader folder object
            ProjectFolder shaderFolder = new ProjectFolder()
            {
                Name = "Shaders",
                Path = contentRoot + "\\Shaders",
                Type = ProjectFolderType.Shaders
            };

            // Create the Scenery folder object
            ProjectFolder sceneryFolder = new ProjectFolder()
            {
                Name = "Scenery",
                Path = contentRoot + "\\Scenery",
                Type = ProjectFolderType.Scenery
            };

            // Create the Meshes folder object
            ProjectFolder meshesFolder = new ProjectFolder()
            {
                Name = "Meshes",
                Path = contentRoot + "\\Meshes",
                Type = ProjectFolderType.Meshes
            };

            // Create the Shader folder object
            ProjectFolder textureFolder = new ProjectFolder()
            {
                Name = "Textures",
                Path = contentRoot + "\\Textures",
                Type = ProjectFolderType.Textures
            };

            #endregion

            contentFolder.ChildFolders.Add(shaderFolder);
            contentFolder.ChildFolders.Add(sceneryFolder);
            contentFolder.ChildFolders.Add(meshesFolder);
            contentFolder.ChildFolders.Add(textureFolder);

            return contentFolder;
        }
    }
}
