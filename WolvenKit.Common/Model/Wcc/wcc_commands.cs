using System;
using System.ComponentModel;

namespace WolvenKit.Common.Wcc
{
    /// <summary>
    /// All wcc_lite commands.
    /// </summary>
    public static class Wcc_lite
    {
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]

        #region Common Commands

        [Serializable]
        [DescriptionAttribute("Build data cache from cooked assets.\n Usage:  buildcache -db -out [optional params]")]
        public class buildcache : WCC_Command
        {
            #region Constructors

            public buildcache()
            {
                Name = "buildcache";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Uncooked base directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("basedir")]
            public string basedir { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [REDTags(new string[] { "Keyword" })]
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Available cache builders: physics, shaders, texture.")]
            [Editor(typeof(EnumConverter), typeof(EnumConverter))]
            [REDName("builder")]
            public cachebuilder builder { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to cook.db.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string DataBase { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("n - Process every nth file")]
            [REDName("modulo")]
            public string Modulo { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("x - Initial offset for processing (use only with -modulo)")]
            [REDName("offset")]
            public string Offset { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to output cache file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            [CategoryAttribute("Is Required"),
                                                DescriptionAttribute("Select target platform (pc, ps4...)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Cook file lists, generate cooked data and bundle files for packing.\n Usage: cook")]
        public class cook : WCC_Command
        {
            #region Constructors

            public cook()
            {
                Name = "cook";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Cook database to check for trimmed files in.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("additionalDB")]
            public string AdditionalDB { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("basedir")]
            public string basedir { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Exclude a directory from cooking.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("excludedir")]
            public string excludedir { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Manual depot file for cooking.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Ignore files with given extension.")]
            [REDName("ignore")]
            public bool ignore { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("mod")]
            public string mod { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Allow asserts.")]
            [REDName("noasserts")]
            public bool noasserts { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Allow cooking errors.")]
            [REDName("noerrors")]
            public bool noerrors { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Specify output directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string outdir { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Select target platform (pc, ps4...)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Input seed file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("seed")]
            public string seed { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("No output.")]
            [REDName("silent")]
            public bool silent { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Capture and save all cooked string IDs.")]
            [REDName("stringids")]
            public bool stringids { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Capture and save all cooked string keys.")]
            [REDName("stringkeys")]
            public bool stringkeys { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Cook resources from a singular directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags(/*"Path",*/ "In")]
            [REDName("trimdir")]
            public string trimdir { get; set; }

            [CategoryAttribute("Optional"),
                                                            DescriptionAttribute("List of trimmed files from cook.db.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path")]
            [REDName("trimmedfiles")]
            public string trimedfiles { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Cooks materials.\n Usage: cookmaterials -platform (-material=) (-fur=)")]
        public class cookmaterials : WCC_Command
        {
            #region Constructors

            public cookmaterials()
            {
                Name = "cookmaterials";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("")]
            [REDName("allmaterials")]
            public bool allmaterials { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("")]
            [REDName("fastfx")]
            public bool fastfx { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("")]
            [REDName("fur")]
            public string fur { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("")]
            [REDName("material")]
            public string material { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("")]
            [REDName("resaveCRC")]
            public bool resaveCRC { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("")]
            [REDName("static")]
            public bool Static { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Dumps info from bundled files.\n Usage: dumpbundleinfo -indir= -outpath=")]
        public class dumpbundleinfo : WCC_Command
        {
            #region Constructors

            public dumpbundleinfo()
            {
                Name = "dumpbundleinfo";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Directory with the bundles (recursive).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string Indir { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Absolute path to input bundle (multiple can be specified).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("infile")]
            public string Infile { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Absolute path to output text file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outfile")]
            public string Outfile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Output path.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outpath")]
            public string Outpath { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Dump file contents (objects).\n Usage: dumpfile -file= -dir= -out=")]
        public class dumpfile : WCC_Command
        {
            #region Constructors

            public dumpfile()
            {
                Name = "dumpfile";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Dump full directory (recursive).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("dir")]
            public string Dir { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("exclude given file extensions")]
            [REDName("exclude")]
            public string Exclude { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Depot path to file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path to output file.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Exports single assets. \n Usage: export -depot= -file= -out=")]
        public class export : WCC_Command
        {
            #region Constructors

            public export()
            {
                Name = "export";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("local - Use local depot(r4data)\n absolutepath - Use depot at given directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("depot")]
            public string Depot { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Optional) Specify FBX version to output to (2016/2013/2011/2010/2009).")]
            //[TypeConverter(typeof(EnumConverter))]
            [REDName("fbx")]
            public string Fbx { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Local (depot) path for the file to export.")]
            [REDTags("In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path for the output directory.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            #endregion Properties

            /*
               xbm(2D Texture) exportable into 5 file format(s):
                   dds: DirectDraw Surface
                   bmp: Windows Bitmap
                   jpg: Joint Photographics Experts Group
                   tga: Truevision Targa
                   png: Portable Network Graphics*/
        }

        [Serializable]
        [DescriptionAttribute("Import assets into the engine. \n Usage: import -depot= -file= -out=")]
        public class import : WCC_Command
        {
            #region Constructors

            public import()
            {
                Name = "import";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Use local depot(r4data). /n Use depot at given directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("depot")]
            public string Depot { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path to file to be imported.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Relative path to output file.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("(Optional) Texture group to import texture as.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("texturegroup")]
            public ETextureGroup texturegroup { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Generates a metadata.store file for the specified directory.\n Usage: metadatastore -path=")]
        public class metadatastore : WCC_Command
        {
            #region Constructors

            public metadatastore()
            {
                Name = "metadatastore";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to bundles directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("path")]
            public string Directory { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Packs file from given directory into a bundle.\n Usage: pack -dir= -outdir= [-compression=]")]
        public class pack : WCC_Command
        {
            #region Constructors

            public pack()
            {
                Name = "pack";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Compression type to use (default: LZ4HC).")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("compression")]
            public compression compression { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Input directory to pack.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("dir")]
            public string Directory { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Output directory with bundles (bundles larger than 4GB are split).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string Outdir { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Unbundle files.\n Usage: unbundle -dir= -outdir=")]
        public class unbundle : WCC_Command
        {
            #region Constructors

            public unbundle()
            {
                Name = "unbundle";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Bundle directory (recursive).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("dir")]
            public string InputDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("(Optional) Dump bundles.json (for repacking)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("json")]
            public string Json { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Absolute path to output directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Uncooks resources from a given bundle set.\n Usage:  uncook -indir= -outdir = [options]")]
        public class uncook : WCC_Command
        {
            #region Constructors

            public uncook()
            {
                Name = "uncook";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Dump redswf files.")]
            [REDName("dumpswf")]
            public bool Dumpswf { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Image format for XBM files to uncook to (tga, bmp, png or jpg.), TGA by default.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("imgfmt")]
            public imageformat Imgfmt { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required")]
            [DescriptionAttribute("Path to the bundled directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string InputDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Path to the input strings file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("infile")]
            public string InputFile { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to the unbundled directory.")]
            ////[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }

            //enum
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Upon failure, skips to the next file.")]
            [REDName("skiperrors")]
            public bool Skiperrors { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Relative inner path to be extracted.")]
            ////[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("In")]
            [REDName("targetdir")]
            public string TargetDirectory { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Unbundles data without uncooking it.")]
            [REDName("unbundleonly")]
            public bool Unbundleonly { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Comma delineated list of file extensions to uncook. If not specified, all extensions will be utilised.")]
            [REDName("uncookext")]
            public string UncookExtensions { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Target language for recursive dump.")]
            [REDName("uncookonly")]
            public bool Uncookonly { get; set; }

            #endregion Properties
        }

        #endregion Common Commands

        #region Uncommon Commands

        [Serializable]
        [DescriptionAttribute("Analyze game and engine data and output cook lists.\n Usage: analyze -out [optional params]")]
        public class analyze : WCC_Command
        {
            #region Constructors

            public analyze()
            {
                Name = "analyze";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [REDTags(new string[] { "Keyword" })]
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Choose object to analyze.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("analyzer")]
            public analyzers Analyzer { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Choose file to analyze.")]
            [REDName("Object")]
            public string Object { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Absolute path to output.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            ///

            [CategoryAttribute("Optional"),
            DescriptionAttribute(".reddlc relative path to use with analyze r4dlc.")]
            [REDName("-dlc")]
            public string reddlc { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Calculate required memory for runtime occlusion data for the level.\n Usage: calculateRuntimeOcclusionMemory [-density=] -world=")]
        public class calculateRuntimeOcclusionMemory : WCC_Command
        {
            #region Constructors

            public calculateRuntimeOcclusionMemory()
            {
                Name = "calculateRuntimeOcclusionMemory";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("NO INFO")]
            [REDName("density")]
            public string Density { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("pathToWorldFile")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Generate occlusion for given worlds.\n Usage: cookocclusion -world= [-smallesOccluder=][-smallestHole=][-tileSize=][-xMin=][-xMax=][-yMin=][-yMax=]")]
        public class cookocclusion : WCC_Command
        {
            #region Constructors

            public cookocclusion()
            {
                Name = "cookocclusion";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("NO INFO")]
            [REDName("smallesOccluder")]
            public string smallesOccluder { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("NO INFO")]
            [REDName("smallestHole")]
            public string smallestHole { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("NO INFO")]
            [REDName("tileSize")]
            public string tileSize { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("pathToWorldFile")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("NO INFO")]
            [REDName("xMax")]
            public string xMax { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("NO INFO")]
            [REDName("xMin")]
            public string xMin { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("NO INFO")]
            [REDName("yMax")]
            public string yMax { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("NO INFO")]
            [REDName("yMin")]
            public string yMin { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("No operation.\n Usage: wcc cooksounds output_dir sound_resource_dir platforms")]
        public class cooksounds : WCC_Command
        {
            #region Constructors

            public cooksounds()
            {
                Name = "cooksounds";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("output_dir")]
            public string OutpuDirectory { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("NO INFO")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platforms")]
            public platform Platforms { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("sound_resource_dir")]
            public string SoundResourceDirectory { get; set; }

            #endregion Properties

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [DescriptionAttribute(" Cooks strings and speech database, given a list of languages and platforms.\n Usage: pcookstrings -out_dir= -source_dir= -db_string_view= -languages= -platforms=")]
        public class cookstrings : WCC_Command
        {
            #region Constructors

            public cookstrings()
            {
                Name = "cookstrings";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("SQL query.")]
            [REDName("db_string_view")]
            public string db_string_view { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            ///
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to the base directory where speech data resides.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("source_dir")]
            public string InputDirectory { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("List of languages to cook.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("languages")]
            public language Languages { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to the directory where the caches will be stored.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out_dir")]
            public string OutputDirectory { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("List of platforms to cook for.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platforms")]
            public platform Platforms { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Cooks only strings.")]
            [REDName("skipspeech")]
            public bool Skipspeech { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Don't ask.\n Usage: cooksubs font subtitles")]
        public class cooksubs : WCC_Command
        {
            #region Constructors

            public cooksubs()
            {
                Name = "cooksubs";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("NO INFO")]
            [REDName("font")]
            public string Font { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Subtitle path needs to be UCS-2 LE. The engine dictates the output file is UTF-8...")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("subtitles")]
            public string Subtitles { get; set; }

            #endregion Properties

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [DescriptionAttribute("Build dependency cache file.\n Usage: dependencies -out= -report= [-db=]")]
        public class dependencies : WCC_Command
        {
            #region Constructors

            public dependencies()
            {
                Name = "dependencies";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Use dependencies in cook.db file instead of full depot.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Save dependency cache to file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Generate dependency report in given directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("report")]
            public string report { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Dumps the charset used in a given strings file (for .w3strings).\n Usage: dumpcharset -instringsfile= -outcharsetfile= [options]")]
        public class dumpcharset : WCC_Command
        {
            #region Constructors

            public dumpcharset()
            {
                Name = "dumpcharset";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Path to base directory for recursive dump. Used with targetlanguage.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("directory")]
            public string Directory { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to the input strings file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("instringsfile")]
            public string Instringsfile { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Target language for recursive dump.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("language")]
            public language Language { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to the out charset file (if not specified, default will be used).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outcharsetfile")]
            public string Outcharsetfile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Dumps all string entries into file path. Only in single file mode.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outentriesfile")]
            public string Outentriesfile { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Dump data from compiled scripts. \n Usage: dumpscripts -file= -out=")]
        public class dumpscripts : WCC_Command
        {
            #region Constructors

            public dumpscripts()
            {
                Name = "dumpscripts";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Input compiled script binary (.redscripts file).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Output report file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outpath")]
            public string Outpath { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Build final bundle lists.\n Usage: exportbundles -db= -seed= -spatial= -out=")]
        public class exportbundles : WCC_Command
        {
            #region Constructors

            public exportbundles()
            {
                Name = "exportbundles";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Use dependencies in cook.db file instead of full depot.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Use fast compression for bundles (faster turnaround, larger output bundles).")]
            [REDName("extrafast")]
            public bool extrafast { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path to final output file (JSON bundle list)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            [CategoryAttribute("Is Required"),
                                    DescriptionAttribute("Initial list of seedfiles.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("seed")]
            public string Seed { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Additional list of seedfiles that represent spatial configuration (overrides existing bundles).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("spatial")]
            public string SpatialSeeds { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Split bundles into chunks using given split file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("split")]
            public string split { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Check file versions.\n Usage: filever -ext= -file -min -verbose -histogram")]
        public class filever : WCC_Command
        {
            #region Constructors

            public filever()
            {
                Name = "filever";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Check only files with given extensions")]
            [REDName("ext")]
            public string ext { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Check only given files.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Print version histogram.")]
            [REDName("histogram")]
            public bool histogram { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Treat any file with version lower than given number as error.")]
            [REDName("min")]
            public bool min { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Print all invalid files.")]
            [REDName("verbose")]
            public bool verbose { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Find duplicate geometry for the level.\n Usage: findDuplicates -world= [-output=]")]
        public class findDuplicates : WCC_Command
        {
            #region Constructors

            public findDuplicates()
            {
                Name = "findDuplicates";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("output")]
            public string output { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("pathToWorldFile")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Save dialog lines.\n Usage: get_txts -db= -outdir= [-lang=]")]
        public class get_txts : WCC_Command
        {
            #region Constructors

            public get_txts()
            {
                Name = "get_txts";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Cook database.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("NO INFO")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("lang")]
            public language lang { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Optimize (resort) collision cache.\n Usage: optimizecollisioncache -file= -out=")]
        public class optimizecollisioncache : WCC_Command
        {
            #region Constructors

            public optimizecollisioncache()
            {
                Name = "optimizecollisioncache";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Depot path to file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path to output file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Packs world directories into a single dzip (oh god, TW2) for faster loading and deployment on consoles.\n  Creates streaming installer data for use by the game. Supported cooking platforms: PS4.\n  Usage: package app [options]")]
        public class package : WCC_Command
        {
            #region Constructors

            public package()
            {
                Name = "package";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path to final deliverable, e.g. Z:\\Build_109641Change_652889\\PS4")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("i")]
            public string InDirectory { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path to language definitions.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("l")]
            public string Language { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Absolute path to generate gp4, pkg and iso in.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("o")]
            public string OutDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Temp. directory.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path")]
            [REDName("t")]
            public string TempDirectory { get; set; }

            #endregion Properties

            /* ps4 app options:
                -t= | --tempdir= --
                -i= | --indir = --
                -o= | --outdir = --
                -l= | --langdir = --.E.g., z:\dev\PublisherSpecific\R4\InternalDevelopment\PS4\language |
                --langs=[language list] > --comma separated list of game languages to support.E.g., en, pl |
                --dftlang=[language]-- default game langauge. Must also be listed in the languages option.E.g., en
        */
        }

        [Serializable]
        [DescriptionAttribute("Generalized commandlet for creating differential patches for specified type of content.\n ote: you can use -mod OR -current params\n Usage: patch -base= -current= -mod= [-name= ] -outdir=")]
        public class patch : WCC_Command
        {
            #region Constructors

            public patch()
            {
                Name = "patch";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to base build (gold master).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("base")]
            public string Base { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("(pro) Path to current build (latest cook).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("current")]
            public string Current { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Output using custom directory name.")]
            [REDName("name")]
            public string DirectoryName { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to cooked mod directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("mod")]
            public string ModDirectory { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Output directory to dump patched content to.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("path")]
            public string OutputDirectory { get; set; }

            #endregion Properties

            /* Content types:
                "bundles" MODS + PATCH
                "shaders" PATCH ONLY
                "staticshaders" PATCH ONLY
                "furshaders" PATCH ONLY
                "speeches" PATCH ONLY
                "strings" PATCH ONLY
                "physics" PATCH ONLY
                "sounds" PATCH ONLY
                "specialcases" PATCH ONLY
                "textures" MODS + PATCH*/
        }

        [Serializable]
        [DescriptionAttribute("Generate navigation data for given world.\n Usage: pathlib -rootSearchDir= -filePattern=")]
        public class pathlib : WCC_Command
        {
            #region Constructors

            public pathlib()
            {
                Name = "pathlib";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("NO INFO")]
            [REDName("FilePattern")]
            public string FilePattern { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("rootSearchDir")]
            public string RootSearchDir { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Saves quest layout for use in external QuestDebugger.\n Usage: questlayoutdump -quest -out")]
        public class questlayoutdump : WCC_Command
        {
            #region Constructors

            public questlayoutdump()
            {
                Name = "questlayoutdump";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("dump_path")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("quest_path")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("quest")]
            public string quest { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Extracts a list of character templates from cook.db.\n Usage: r4characters -db= -out=")]
        public class r4characters : WCC_Command
        {
            #region Constructors

            public r4characters()
            {
                Name = "r4characters";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Cook database.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Output file.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Extracts a list of character templates from cook.db.\n Usage: r4characters -db= -out=")]
        public class r4charactersdlc : WCC_Command
        {
            #region Constructors

            public r4charactersdlc()
            {
                Name = "r4charactersdlc";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Cook database")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Output file.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Reports file usage and chunk distribution of a given cook database.\n Usage: reportchunks -db= -out=")]
        public class reportchunks : WCC_Command
        {
            #region Constructors

            public reportchunks()
            {
                Name = "reportchunks";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to the cook.db file to use as reference.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string Database { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Output path.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Output { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Outputs exhaustive report (default).")]
            [REDName("showall")]
            public bool Showall { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Outputs the list of files in each chunk (slow).")]
            [REDName("showchunkfiles")]
            public bool showchunkfiles { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Outputs extension/chunk statistics.")]
            [REDName("showextensions")]
            public bool showextensions { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Outputs file/chunk statistics (slow).")]
            [REDName("showfilechunks")]
            public bool showfilechunks { get; set; }

            [CategoryAttribute("Optional"),
                                                DescriptionAttribute("Outputs global statistics.")]
            [REDName("showsumary")]
            public bool Showsumary { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Re-saves resources and optionally submits the changes into P4.\n Usage:  resave -tmpdir= [options]")]
        public class resave : WCC_Command
        {
            #region Constructors

            public resave()
            {
                Name = "resave";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Add re-saved files into given changelist (when enabled).")]
            [REDName("cl")]
            public bool cl { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Re-saves only given list of files.")]
            [REDName("customresave")]
            public bool customresave { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Discards files for which data has not changed(disabled by default, potentially slow).")]
            [REDName("discardunchangeddata")]
            public bool discardunchangeddata { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Comma-separated list of extensions to scan for (full resave if not specified).")]
            [REDName("ext")]
            public string ext { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Force reset and setup of streaming in world and layers (dangerous).")]
            [REDName("forcestreamingsetup")]
            public bool forcestreamingsetup { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Re-save even if files are latest version.")]
            [REDName("ignorefileversion")]
            public bool ignorefileversion { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Disables version control (local resave).")]
            [REDName("nosourcecontrol")]
            public bool nosourcecontrol { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("client -- client(workspace) for Perforce")]
            [REDName("p4client")]
            public bool p4client { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("host -- hostname for Perforce")]
            [REDName("p4host")]
            public bool p4host { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("password -- password for Perforce")]
            [REDName("p4password")]
            public bool p4password { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("port -- port for Perforce")]
            [REDName("p4port")]
            public bool p4port { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("username -- username for Perforce")]
            [REDName("p4user")]
            public bool p4user { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Base directory path to scan (full depot resave if not specified).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("path")]
            public string Path { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Enables CL submit when finished (disabled by default).")]
            [REDName("submitwhenfinished")]
            public bool submitwhenfinished { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Absolute path to temp. folder.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path")]
            [REDName("tmpdir")]
            public string TempDirectory { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Export spatial resource usage information from a given world.\n Usage:  resourceusage -world= -out= [options]")]
        public class resourceusage : WCC_Command
        {
            #region Constructors

            public resourceusage()
            {
                Name = "resourceusage";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Allow asserts.")]
            [REDName("noasserts")]
            public bool noasserts { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Allow cooking errors.")]
            [REDName("noerrors")]
            public bool noerrors { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to output file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("No output.")]
            [REDName("silent")]
            public bool silent { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to world file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string world { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Split the files into content buckets.\n Usage: split -db= [-seed=] -out=")]
        public class split : WCC_Command
        {
            #region Constructors

            public split()
            {
                Name = "split";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to cook database.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Specify custom fallback chunk for unassigned resources.")]
            [REDName("fallback")]
            public string fallback { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Output file name.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Path to seed file(s)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("seed")]
            public string seed { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Split cache into multiple files.\n Usage: splitcache -file= -db=<cook.db> -outdir= Options:")]
        public class splitcache : WCC_Command
        {
            #region Constructors

            public splitcache()
            {
                Name = "splitcache";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required")]
            [DescriptionAttribute("Path to the cook.db file to use as reference.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string Database { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Use custom fallback chunk name.")]
            [REDName("fallback")]
            public string Fallback { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Input cache file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Cache output path.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }

            [CategoryAttribute("Optional"),
            DescriptionAttribute("Remove data from non-cooked files.")]
            [REDName("strip")]
            public bool Strip { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Splits strings and speech files for a given language based on JSON descriptor.\n Usage:splitstrings[-dlc] -splitfile= -idsfile= -keysfile= -indir= -outdir=")]
        public class splitstrings : WCC_Command
        {
            #region Constructors

            public splitstrings()
            {
                Name = "splitstrings";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Merges all chunks into content0 (debug option).")]
            [REDName("allincontent0")]
            public bool Allincontent0 { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Outputs all files in the same folder (debug option).")]
            [REDName("allinsamefolder")]
            public bool allinsamefolder { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Run in DLC mode (no per-chunk splitting)")]
            [REDName("dlc")]
            public bool Dlc { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Split speech only (everything is done by default).")]
            [REDName("dospeech")]
            public bool Dospeech { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Split strings only (everything is done by default).")]
            [REDName("idsfile")]
            public bool Dostrings { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to the .ids file (mapping resources to string ID's).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("idsfile")]
            public string Idsfile { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to the language files' directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string Indir { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to the .keys file [optional] (mapping resources to string keys).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("keysfile")]
            public string Keysfile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Add language to splitting plan ('en' by default).")]
            [REDName("language")]
            public language Language { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Path to the directory where the split files will reside.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string outdir { get; set; }

            [CategoryAttribute("Optional"),
                        DescriptionAttribute("Add platform to splitting plan ('pc' by default).")]
            [REDName("platform")]
            public platform Platform { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to the .split file (mapping resources to chunks, not required in DLC mode).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("splitfile")]
            public string Splitfile { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Dumps SWF resources.\n Usage: swfdump[out]")]
        public class swfdump : WCC_Command
        {
            #region Constructors

            public swfdump()
            {
                Name = "swfdump";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Output directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            #endregion Properties

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [DescriptionAttribute(" Bulk import resources preserving directory structure.\n Usage: import [option1 value1 [option2 value2 [...]]]")]
        public class swfimport : WCC_Command
        {
            #region Constructors

            public swfimport()
            {
                Name = "swfimport";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Depot path to import to.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("toDepotPath")]
            public string DepotPath { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Absolute path to scan inside")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("fromAbsPath")]
            public string InputDirectory { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Test asynchronous collision cache access.\n Usage: testcollisioncache -file=")]
        public class testcollisioncache : WCC_Command
        {
            #region Constructors

            public testcollisioncache()
            {
                Name = "testcollisioncache";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("File Cache.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute(" Test memory framework, streaming, GC and resource management stability.\n Usage: testmem[params]")]
        public class testmem : WCC_Command
        {
            #region Constructors

            public testmem()
            {
                Name = "testmem";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Extents (around origin) to test.")]
            [REDName("extents")]
            public string Extents { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Number of test iterations.")]
            [REDName("numiter")]
            public string TestIterations { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Number of test points.")]
            [REDName("numpoints")]
            public string TestPoints { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Path to the w2w file to load.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            #endregion Properties

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [DescriptionAttribute("Validate resources.\n Usage: validate[-db= -file = -all] -outdir=")]
        public class validate : WCC_Command
        {
            #region Constructors

            public validate()
            {
                Name = "validate";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Validate all files in depot (not recommended).")]
            [REDName("all")]
            public bool all { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Cook database.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Validate single file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string Outdir { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Generate USMs.\n Usage:  NO INFO")]
        public class venc : WCC_Command
        {
            #region Constructors

            public venc()
            {
                Name = "venc";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Optional
            /// </summary>
            [CategoryAttribute("Optional"),
            DescriptionAttribute("Arabic font set.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("ar_font")]
            public string ArabicFontFile { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("")]
            [REDName("bitrate")]
            public int Bitrate { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("")]
            [REDName("cue_subs")]
            public bool Cue_subs { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("Input directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string InputDirectory { get; set; }

            [CategoryAttribute("Is Required"),
            DescriptionAttribute("")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("usmdir")]
            public string usmDirectory { get; set; }

            #endregion Properties
        }

        [Serializable]
        [DescriptionAttribute("Convert voiceover files from .wav to .ogg.\n Usage: wcc voconvert -wwise_bin_dir= -voiceivers_source_dir= -platform= languages=")]
        public class voconvert : WCC_Command
        {
            #region Constructors

            public voconvert()
            {
                Name = "voconvert";
            }

            #endregion Constructors

            #region Properties

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Languages (en, de...)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("languages")]
            public language Languages { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("Platform (pc ..)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            [CategoryAttribute("Is Required"),
                        DescriptionAttribute("NO INFO")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("voiceivers_source_dir")]
            public string Voiceivers_source_dir { get; set; }

            /// <summary>
            /// Required
            /// </summary>
            [CategoryAttribute("Is Required"),
            DescriptionAttribute("NO INFO.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("wwise_bin_dir")]
            public string Wwise_bin_dir { get; set; }

            #endregion Properties

            /// <summary>
            /// Optional
            /// </summary>
        }

        #endregion Uncommon Commands

        #region Unknown Commands

        [Serializable]
        [DescriptionAttribute("Simply tests wcc.")]
        public class cookertest : WCC_Command
        {
            #region Constructors

            public cookertest()
            {
                Name = "cookertest";
            }

            #endregion Constructors
        }

        [Serializable]
        [DescriptionAttribute("Glues files into optimal files. \n Usage: NO INFO")]
        public class gluefiles : WCC_Command
        {
            #region Constructors

            public gluefiles()
            {
                Name = "gluefiles";
            }

            #endregion Constructors
        }

        [Serializable]
        [DescriptionAttribute("Glues files into optimal files. \n Usage: NO INFO")]
        public class gluefilesdlc : WCC_Command
        {
            #region Constructors

            public gluefilesdlc()
            {
                Name = "gluefilesdlc";
            }

            #endregion Constructors
        }

        [Serializable]
        [DescriptionAttribute("Attempts to load all resources to check for errors.\n Usage: NO INFO")]
        public class loadtest : WCC_Command
        {
            #region Constructors

            public loadtest()
            {
                Name = "loadtest";
            }

            #endregion Constructors
        }

        [Serializable]
        [DescriptionAttribute("Creates the .dep files Creates the .dep files needed for the database creation used by the Database Viewer.\n Usage:  NO INFO")]
        public class WorldSceneDependencyInfoFiles : WCC_Command
        {
            #region Constructors

            public WorldSceneDependencyInfoFiles()
            {
                Name = "WorldSceneDependencyInfoFiles";
            }

            #endregion Constructors
        }

        #endregion Unknown Commands
    }
}
