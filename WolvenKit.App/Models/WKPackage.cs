using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Zip;

namespace WolvenKit.Models
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
        //public WKPackage(string Path)
        //{
        //    //TODO: Finish this once we crate the installer or whatever.
        //}

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
        /// This creates the modassembly xml. Values which are optional are marked in their description as such. If a value is not given pass the method NULL for that value.
        /// </summary>
        /// <param name="version">The Version of the mod. [REQUIRED]</param>
        /// <param name="name">The name of the mod. [REQUIRED]</param>
        /// <param name="Author">Author info [Name,NexusmodsProfile,Web,Facebook,Twitter,Youtube] Note: Only Name is required!</param>
        /// <param name="description">The description of the mod. [OPTIONAL]</param>
        /// <param name="Largedescription">Aditional description of the mod. [OPTIONAL]</param>
        /// <param name="license">The License of the mod. [OPTIONAL]</param>
        /// <param name="Colors">Header background color, If true the header text will be black otherwise white, Icon bacground color. [REQUIRED]</param>
        /// /// <param name="Contents">The commands to run on the games files. eg.: adding new lines to xmls and such. [OPTIONAL]</param>
        /// <returns></returns>
        public static XDocument CreateModAssembly(
            string version,
            string name,
            Tuple<string, string, string, string, string, string> Author,
            string description,
            string Largedescription,
            string license,
            Tuple<Color, bool,
            Color> Colors,
            List<XElement> Contents)
        {
            if (version == null || name == null || Author.Item1 == null || Colors == null)
            {
                throw new ArgumentException("Invalid parameters when trying to generate the assembly.xml!");
            }
            var rootnode = new XElement("package", new XAttribute("version", version), new XAttribute("name", name));
            var authorelement = new XElement("author", new XElement("displayName", Author.Item1));
            var metadataelement = new XElement("metadata");
            if (!string.IsNullOrEmpty(Author.Item2))
            {
                authorelement.Add(new XElement("actionLink", Author.Item2));
            }

            if (!string.IsNullOrEmpty(Author.Item3))
            {
                authorelement.Add(new XElement("web", Author.Item3));
            }

            if (!string.IsNullOrEmpty(Author.Item4))
            {
                authorelement.Add(new XElement("facebook", Author.Item4));
            }

            if (!string.IsNullOrEmpty(Author.Item5))
            {
                authorelement.Add(new XElement("twitter", Author.Item5));
            }

            if (!string.IsNullOrEmpty(Author.Item6))
            {
                authorelement.Add(new XElement("youtube", Author.Item6));
            }

            metadataelement.Add(authorelement);
            if (description?.Length > 0)
            {
                metadataelement.Add(new XElement("description", description));
            }

            if (Largedescription?.Length > 0)
            {
                metadataelement.Add(new XElement("largeDescription", Largedescription));
            }

            if (license?.Length > 0)
            {
                metadataelement.Add(new XElement("license", license));
            }

            rootnode.Add(metadataelement);
            rootnode.Add(new XElement("colors", new XElement("headerBackground", ColorTranslator.ToHtml(Colors.Item1), new XAttribute("useBlackTextColor", Colors.Item2)), new XElement("iconBackground", ColorTranslator.ToHtml(Colors.Item3))));
            rootnode.Add(new XElement("content", Contents));
            return new XDocument(new XDeclaration("1.0", "UTF-8", "True"), rootnode);
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
                Commonfunctions.CompressFolder(RootFolder, zipStream, folderOffset);
                Commonfunctions.CompressFile(Icon, zipStream, "Icon" + Path.GetExtension(Icon));
                Commonfunctions.CompressStream(Commonfunctions.XDocToByteArray(Assembly), "Assembly.xml", zipStream);
                zipStream.IsStreamOwner = true;
                zipStream.Close();
            }
            else
            {
                throw new Exception("Missing parameters!");
            }
        }

        #endregion Methods
    }
}
