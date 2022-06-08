using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace WolvenKit.Common.Model.Packaging
{
    public class WKPackage
    {
        #region Fields

        public string RootFolder;
        private readonly XDocument Assembly;
        private readonly string Icon;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Collects the info and the files from an already created WolveKit package.
        /// </summary>
        /// <param name="Path"></param>
        public WKPackage(string Path)
        {
            //TODO: Finish this once we crate the installer or whatever.
        }

        /// <summary>
        /// Creates a WolveKit package.
        /// </summary>
        /// <param name="assmebly">The details of the mod. Generate this with CreateModAssembly();</param>
        /// <param name="icon">The icon of the mod.</param>
        /// <param name="RootFolder">The root folder of the mod.</param>
        public WKPackage(XDocument assmebly, string icon, string rootfolder)
        {
            Assembly = assmebly;
            Icon = icon;
            RootFolder = rootfolder;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Compresses a file into a zipstream.
        /// </summary>
        /// <param name="filename">Path to the file.</param>
        /// <param name="zipStream">The zipstream to output to.</param>
        /// <param name="nameOverride">Rename the file to a costum name.</param>
        public static void CompressFile(string filename, ZipOutputStream zipStream, string nameOverride = "")
        {
            var fi = new FileInfo(filename);

            var entryName = Path.GetFileName(filename);
            if (nameOverride != "")
            {
                entryName = nameOverride;
            }

            entryName = ZipEntry.CleanName(entryName);
            var newEntry = new ZipEntry(entryName) { DateTime = fi.LastWriteTime, Size = fi.Length };
            zipStream.PutNextEntry(newEntry);
            var buffer = new byte[4096];
            using (var streamReader = File.OpenRead(filename))
            {
                StreamUtils.Copy(streamReader, zipStream, buffer);
            }
            zipStream.CloseEntry();
        }

        /// <summary>
        /// Compresses a folder of files into a zipstream.
        /// </summary>
        /// <param name="path">The path of the folder.</param>
        /// <param name="zipStream">The output zipstream.</param>
        /// <param name="folderOffset">The folderoffset.</param>
        public static void CompressFolder(string path, ZipOutputStream zipStream, int folderOffset)
        {
            var files = Directory.GetFiles(path);

            foreach (var filename in files)
            {
                var fi = new FileInfo(filename);
                var entryName = filename.Substring(folderOffset);
                entryName = ZipEntry.CleanName(entryName);
                var newEntry = new ZipEntry(entryName) { DateTime = fi.LastWriteTime, Size = fi.Length };
                zipStream.PutNextEntry(newEntry);
                var buffer = new byte[4096];
                using (var streamReader = File.OpenRead(filename))
                {
                    StreamUtils.Copy(streamReader, zipStream, buffer);
                }
                zipStream.CloseEntry();
            }
            var folders = Directory.GetDirectories(path);
            foreach (var folder in folders)
            {
                CompressFolder(folder, zipStream, folderOffset);
            }
        }

        /// <summary>
        /// Compresses a byte array to a zipstream.
        /// </summary>
        /// <param name="file">The byte array to compress.</param>
        /// <param name="filename">The entry name.</param>
        /// <param name="zipStream">The zipstream which we want to output this file to.</param>
        public static void CompressStream(byte[] file, string filename, ZipOutputStream zipStream)
        {
            filename = ZipEntry.CleanName(filename);
            var newEntry = new ZipEntry(filename) { DateTime = DateTime.Now, Size = file.Length };
            zipStream.PutNextEntry(newEntry);
            var buffer = new byte[4096];
            StreamUtils.Copy(new MemoryStream(file), zipStream, buffer);
            zipStream.CloseEntry();
        }

        public record AuthorInfo(string Name, string NexusmodsProfile, string Web, string Facebook, string Twitter, string Youtube);

        /// <summary>
        /// This creates the modassembly xml. Values which are optional are marked in their description as such. If a value is not given pass the method NULL for that value.
        /// </summary>
        /// <param name="version">The Version of the mod. [REQUIRED]</param>
        /// <param name="name">The name of the mod. [REQUIRED]</param>
        /// <param name="author">Author info [Name,NexusmodsProfile,Web,Facebook,Twitter,Youtube] Note: Only Name is required!</param>
        /// <param name="description">The description of the mod. [OPTIONAL]</param>
        /// <param name="largedescription">Aditional description of the mod. [OPTIONAL]</param>
        /// <param name="license">The License of the mod. [OPTIONAL]</param>
        /// <param name="colors">Header background color, If true the header text will be black otherwise white, Icon bacground color. [REQUIRED]</param>
        /// /// <param name="contents">The commands to run on the games files. eg.: adding new lines to xmls and such. [OPTIONAL]</param>
        /// <returns></returns>
        public static XDocument CreateModAssembly(
            string version,
            string name,
            AuthorInfo author,
            string description,
            string largedescription,
            string license,
            Tuple<Color, bool, Color> colors,
            List<XElement> contents)
        {
            if (version == null || name == null || author.Name == null || colors == null)
            {
                throw new ArgumentException("Invalid parameters when trying to generate assembly.xml.");
            }
            var rootnode = new XElement("package", new XAttribute("version", version), new XAttribute("name", name));
            var authorelement = new XElement("author", new XElement("displayName", author.Name));
            var metadataelement = new XElement("metadata");
            if (!string.IsNullOrEmpty(author.NexusmodsProfile))
            {
                authorelement.Add(new XElement("actionLink", author.NexusmodsProfile));
            }

            if (!string.IsNullOrEmpty(author.Web))
            {
                authorelement.Add(new XElement("web", author.Web));
            }

            if (!string.IsNullOrEmpty(author.Facebook))
            {
                authorelement.Add(new XElement("facebook", author.Facebook));
            }

            if (!string.IsNullOrEmpty(author.Twitter))
            {
                authorelement.Add(new XElement("twitter", author.Twitter));
            }

            if (!string.IsNullOrEmpty(author.Youtube))
            {
                authorelement.Add(new XElement("youtube", author.Youtube));
            }

            metadataelement.Add(authorelement);
            if (description?.Length > 0)
            {
                metadataelement.Add(new XElement("description", description));
            }

            if (largedescription?.Length > 0)
            {
                metadataelement.Add(new XElement("largeDescription", largedescription));
            }

            if (license?.Length > 0)
            {
                metadataelement.Add(new XElement("license", license));
            }

            rootnode.Add(metadataelement);
            rootnode.Add(new XElement("colors", new XElement("headerBackground", ColorTranslator.ToHtml(colors.Item1), new XAttribute("useBlackTextColor", colors.Item2)), new XElement("iconBackground", ColorTranslator.ToHtml(colors.Item3))));
            rootnode.Add(new XElement("content", contents));
            return new XDocument(new XDeclaration("1.0", "UTF-8", "True"), rootnode);
        }

        /// <summary>
        /// Converts an XDocuments to a byte array.
        /// </summary>
        /// <param name="xdoc">The xdocument which we want to convert.</param>
        /// <returns>The byte contents of the array.</returns>
        public static byte[] XDocToByteArray(XDocument xdoc)
        {
            var ms = new MemoryStream();
            var xws = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Indent = true
            };

            using (var xw = XmlWriter.Create(ms, xws))
            {
                xdoc.WriteTo(xw);
            }
            return ms.ToArray();
        }

        /// <summary>
        /// Saves the package to the specified output path.
        /// </summary>
        /// <param name="OutputPath">The path to save the file to.</param>
        public void Save(string OutputPath)
        {
            if (Icon != null && Assembly != null)
            {
                var fsOut = File.Create(OutputPath);
                var zipStream = new ZipOutputStream(fsOut);
                var folderOffset = RootFolder.Length + (RootFolder.EndsWith("\\") ? 0 : 1);
                CompressFolder(RootFolder, zipStream, folderOffset);
                CompressFile(Icon, zipStream, "Icon" + Path.GetExtension(Icon));
                CompressStream(XDocToByteArray(Assembly), "Assembly.xml", zipStream);
                zipStream.Close();
            }
            else
            {
                throw new Exception("Missing parameters.");
            }
        }

        #endregion Methods
    }
}
