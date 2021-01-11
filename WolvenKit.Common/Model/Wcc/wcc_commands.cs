using System;
using System.ComponentModel;

namespace WolvenKit.Common.Model.Wcc
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
        [Description("Uncooks resources from a given bundle set.\n Usage:  uncook -indir= -outdir = [options]")]
        public class uncook : WCC_Command
        {
            public uncook()
            {
                Name = "uncook";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required")]
            [Description("Path to the bundled directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string InputDirectory { get; set; }

            [Category("Is Required"),
            Description("Path to the unbundled directory.")]
            ////[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Path to the input strings file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("infile")]
            public string InputFile { get; set; }

            [Category("Optional"),
            Description("Relative inner path to be extracted.")]
            ////[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("In")]
            [REDName("targetdir")]
            public string TargetDirectory { get; set; }

            [Category("Optional"),
            Description("Comma delineated list of file extensions to uncook. If options missing will uncook all av")]
            [REDName("uncookext")]
            public string UncookExtensions { get; set; }

            [Category("Optional"),
            Description("Image format for XBM files. Choose one of bmp, png, jpg, or tga. Default is tga.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("imgfmt")]
            public imageformat Imgfmt { get; set; } //enum

            [Category("Optional"),
            Description("Dump redswf files.")]
            [REDName("dumpswf")]
            public bool Dumpswf { get; set; }

            [Category("Optional"),
            Description("Upon failure, skips to the next file.")]
            [REDName("skiperrors")]
            public bool Skiperrors { get; set; }

            [Category("Optional"),
            Description("Unbundles data without uncooking it.")]
            [REDName("unbundleonly")]
            public bool Unbundleonly { get; set; }

            [Category("Optional"),
            Description("Target language for recursive dump. Used with targetlanguage.")]
            [REDName("uncookonly")]
            public bool Uncookonly { get; set; }
        }

        [Serializable]
        [Description("Dumps info for bundled files.\n Usage: dumpbundleinfo -indir= -outpath=")]
        public class dumpbundleinfo : WCC_Command
        {
            public dumpbundleinfo()
            {
                Name = "dumpbundleinfo";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Directory with the bundles (recursive).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string Indir { get; set; }

            [Category("Is Required"),
            Description("Absolute path to output text file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outfile")]
            public string Outfile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("where to place output.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outpath")]
            public string Outpath { get; set; }

            [Category("Optional"),
            Description("Absolute path to input bundle (multiple can be specified).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("infile")]
            public string Infile { get; set; }

        }

        [Serializable]
        [Description("Export single assets from the engine. \n Usage: export -depot= -file= -out=")]
        public class export : WCC_Command
        {
            public export()
            {
                Name = "export";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("local - Use local depot(r4data)\n absolutepath - Use depot at given directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("depot")]
            public string Depot { get; set; }

            [Category("Is Required"),
            Description("relativepath - Local(depot) path for the file to export.")]
            [REDTags("In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Is Required"),
            Description("absolutepath - Output absolute path for the exported file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("fbxversion - (Optional) Specify output FBX version - 2016, 2013, 2011, 2010, 2009.")]
            //[TypeConverter(typeof(EnumConverter))]
            [REDName("fbx")]
            public string Fbx { get; set; }

            /*
               xbm(2D Texture) exportable into 5 file format(s):
                   dds: DirectDraw Surface
                   bmp: Windows Bitmap
                   jpg: Joint Photographics Experts Group
                   tga: Truevision Targa
                   png: Portable Network Graphics*/
        }

        [Serializable]
        [Description("Import assets into the engine. \n Usage: import -depot= -file= -out=")]
        public class import : WCC_Command
        {
            public import()
            {
                Name = "import";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("local - Use local depot(r4data) /n absolutepath - Use depot at given directory")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("depot")]
            public string Depot { get; set; }

            [Category("Is Required"),
            Description("inputfile - Absolute path to file to import")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Is Required"),
            Description("outputfile - Relative(depot) path for the output file")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("nameofgroup - (Optional) Name of texture group when importing texture.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("texturegroup")]
            public ETextureGroup texturegroup { get; set; }

        }

        [Serializable]
        [Description("Dump file content(objects).\n Usage: dumpfile -file= -dir= -out=")]
        public class dumpfile : WCC_Command
        {
            public dumpfile()
            {
                Name = "dumpfile";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description(" dump the whole directory (recursive)")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("dir")]
            public string Dir { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("depot path to the file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Is Required"),
            Description("absolute path to the output file")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            [Category("Optional"),
            Description("exclude given file extensions")]
            [REDName("exclude")]
            public string Exclude { get; set; }
        }

        [Serializable]
        [Description(" Unbundle the files.\n Usage: unbundle -dir= -outdir=")]
        public class unbundle : WCC_Command
        {
            public unbundle()
            {
                Name = "unbundle";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("directory with the bundles (recursive)")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("dir")]
            public string InputDirectory { get; set; }

            [Category("Is Required"),
            Description("absolute path to output directory")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("optional bundles.json dump (for repacking)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("json")]
            public string Json { get; set; }
        }

        [Serializable]
        [Description("Build data cache from cooked assets.\n Usage:  buildcache -db -out [optional params]")]
        public class buildcache : WCC_Command
        {
            public buildcache()
            {
                Name = "buildcache";
            }

            /// <summary>
            /// Required
            /// </summary>
            [REDTags(new string[] { "Keyword" })]
            [Category("Is Required"),
            Description("Available Cache builders: physics, shaders, texture. ")]
            [Editor(typeof(EnumConverter), typeof(EnumConverter))]
            [REDName("builder")]
            public cachebuilder builder { get; set; }

            [Category("Is Required"),
            Description("Path to cook.db.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string DataBase { get; set; }

            [Category("Is Required"),
            Description("Uncooked Base Directory")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("basedir")]
            public string basedir { get; set; }

            [Category("Is Required"),
            Description("Select target platform(required)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            [Category("Is Required"),
            Description("Path to output cache file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("N - Process every Nth file")]
            [REDName("modulo")]
            public string Modulo { get; set; }

            [Category("Optional"),
            Description("X - Initial offset for processing(use only with -modulo)")]
            [REDName("offset")]
            public string Offset { get; set; }

       
        }

        [Serializable]
        [Description("Generates a metadata.store file for the specified directory.\n Usage: metadatastore -path=")]
        public class metadatastore : WCC_Command
        {
            public metadatastore()
            {
                Name = "metadatastore";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Path to bundles directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("path")]
            public string Directory { get; set; }
        }

        [Serializable]
        [Description("Cook file lists, generate cooked data and bundle files for packing.\n Usage: cook")]
        public class cook : WCC_Command
        {
            public cook()
            {
                Name = "cook";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Select target platform(required)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            [Category("Is Required"),
            Description("Sepcify output directory(required).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string outdir { get; set; }


            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("basedir")]
            public string basedir { get; set; }

            [Category("Optional"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("mod")]
            public string mod { get; set; }

            [Category("Optional"),
            Description("Input seed file(required).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("seed")]
            public string seed { get; set; }

            [Category("Optional"),
            Description("Manual depot file for cooking.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Optional"),
            Description("Cook.db file to check if it containes trimmed files.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("additionalDB")]
            public string AdditionalDB { get; set; }

            [Category("Optional"),
            Description("List of trimmed files from cook.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path")]
            [REDName("trimedfiles")]
            public string trimedfiles { get; set; }

            [Category("Optional"),
            Description("Don't cook resources from one directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("excludedir")]
            public string excludedir { get; set; }

            [Category("Optional"),
            Description("Cook resources only from one directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags(/*"Path",*/ "In")]
            [REDName("trimdir")]
            public string trimdir { get; set; }

            [Category("Optional"),
            Description("Allow cooking errors.")]
            [REDName("noerrors")]
            public bool noerrors { get; set; }

            [Category("Optional"),
            Description("Allow asserts.")]
            [REDName("noasserts")]
            public bool noasserts { get; set; }

            [Category("Optional"),
            Description("No output.")]
            [REDName("silent")]
            public bool silent { get; set; }

            [Category("Optional"),
            Description("Ignore files with given extension.")]
            [REDName("ignore")]
            public bool ignore { get; set; }

            [Category("Optional"),
            Description("Capture and save all cooked string ID's.")]
            [REDName("stringids")]
            public bool stringids { get; set; }

            [Category("Optional"),
            Description("Capture and save all cooked string key's.")]
            [REDName("stringkeys")]
            public bool stringkeys { get; set; }


        }

        [Serializable]
        [Description("Packs file from given directory into a bundle.\n Usage: pack -dir= -outdir= [-compression=]")]
        public class pack : WCC_Command
        {
            public pack()
            {
                Name = "pack";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Input directory to pack")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("dir")]
            public string Directory { get; set; }

            [Category("Is Required"),
            Description("Output directory with bundles (note: bundles bigger than 4GB are split)")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string Outdir { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Compression type to use(default: LZ4HC)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("compression")]
            public compression compression { get; set; }
        }

        [Serializable]
        [Description("Cooks materials.\n Usage: cookmaterials -platform (-material=) (-fur=)")]
        public class cookmaterials : WCC_Command
        {
            public cookmaterials()
            {
                Name = "cookmaterials";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("")]
            [REDName("static")]
            public bool Static { get; set; }

            [Category("Optional"),
            Description("")]
            [REDName("fastfx")]
            public bool fastfx { get; set; }

            [Category("Optional"),
            Description("")]
            [REDName("allmaterials")]
            public bool allmaterials { get; set; }

            [Category("Optional"),
            Description("")]
            [REDName("material")]
            public string material { get; set; }

            [Category("Optional"),
            Description("")]
            [REDName("resaveCRC")]
            public bool resaveCRC { get; set; }
        
            [Category("Optional"),
            Description("")]
            [REDName("fur")]
            public string fur { get; set; }
        }

        #endregion

        #region Uncommon Commands

        [Serializable]
        [Description("Analyze game and engine data and output cook lists.\n Usage: analyze -out [optional params]")]
        public class analyze : WCC_Command
        {
            public analyze()
            {
                Name = "analyze";
            }


            /// <summary>
            /// Required
            /// </summary>
            [REDTags(new string[] { "Keyword" })]
            [Category("Is Required"),
            Description("Choose object to analyze.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("analyzer")]
            public analyzers Analyzer { get; set; }

            [Category("Is Required"),
            Description("Output absolute path")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Is Required"),
            Description("Choose file to analyze.")]
            [REDName("Object")]
            public string Object { get; set; }/// 

            [Category("Optional"),
            Description("reddlc relative path to use with analyze r4dlc")]
            [REDName("-dlc")]
            public string reddlc { get; set; }
        }

        [Serializable]
        [Description("Split cache file into multiple files.\n Usage: splitcache -file= -db=<cook.db> -outdir= Options:")]
        public class splitcache : WCC_Command
        {
            public splitcache()
            {
                Name = "splitcache";
            }
            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("input cache file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get;set;}

            [Category("Is Required")]
            [Description("path to the cook.db file to use as a reference")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string Database { get; set; }

            [Category("Is Required"),
            Description("where to place output caches.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }


            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("use custom fallback chunk name")]
            [REDName("fallback")]
            public string Fallback { get; set; }

            [Category("Optional"),
            Description("remove data from non cooked files")]
            [REDName("strip")]
            public bool Strip { get; set; }
        
        }

        [Serializable]
        [Description("Reports file usage and chunk distribution of a given cook database.\n Usage: reportchunks -db= -out=")]
        public class reportchunks : WCC_Command
        {
            public reportchunks()
            {
                Name = "reportchunks";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("path to the cook.db file to use as a reference")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string Database { get; set; }

            [Category("Is Required"),
            Description("where to place output.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Output { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Outputs exhaustive report(default).")]
            [REDName("showall")]
            public bool Showall { get; set; }

            [Category("Optional"),
            Description("Outputs global statistics.")]
            [REDName("showsumary")]
            public bool Showsumary { get; set; }

            [Category("Optional"),
            Description("Outputs extension/chunk statistics.")]
            [REDName("showextensions")]
            public bool showextensions { get; set; }

            [Category("Optional"),
            Description("Outputs file/chunk statistics (slow!).")]
            [REDName("showfilechunks")]
            public bool showfilechunks { get; set; }

            [Category("Optional"),
            Description("Outputs the list of files in each chunk(slow!)")]
            [REDName("showchunkfiles")]
            public bool showchunkfiles { get; set; }
        }

        [Serializable]
        [Description("Dump data from compiled scripts. \n Usage: dumpscripts -file= -out=")]
        public class dumpscripts : WCC_Command
        {
            public dumpscripts()
            {
                Name = "dumpscripts";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("<scriptfile.redscripts> - Input file (compiled script binary).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Is Required"),
            Description("<outputfile.txt> - Output report file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outpath")]
            public string Outpath { get; set; }
        }

        [Serializable]
        [Description("Validate resources.\n Usage: validate[-db= -file = -all] -outdir=")]
        public class validate : WCC_Command
        {
            public validate()
            {
                Name = "validate";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("cook.db file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [Category("Is Required"),
            Description("Validate single file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Is Required"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string Outdir { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Validate all files in depot (not recommended)")]
            [REDName("all")]
            public bool all { get; set; }
        }

        [Serializable]
        [Description("Save Dialog Lines.\n Usage: get_txts -db= -outdir= [-lang=]")]
        public class get_txts : WCC_Command
        {
            public get_txts()
            {
                Name = "get_txts";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("cook.db file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [Category("Is Required"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string OutputDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("NO INFO")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("lang")]
            public language lang { get; set; }
        }

        [Serializable]
        [Description("Optimize(resort) collision cache.\n Usage: optimizecollisioncache -file= -out=")]
        public class optimizecollisioncache : WCC_Command
        {
            public optimizecollisioncache()
            {
                Name = "optimizecollisioncache";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("depot path to the file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Is Required"),
            Description("absolute path to the output file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }
        }

        [Serializable]
        [Description("Generalized commandlet for creating differential patches for specified type of content.\n ote: you can use -mod OR -current params\n Usage: patch -base= -current= -mod= [-name= ] -outdir=")]
        public class patch : WCC_Command
        {
            public patch()
            {
                Name = "patch";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Path to the base build (GoldMaster)")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("base")]
            public string Base { get; set; }

            [Category("Is Required"),
            Description("(pro) Path to the current build (latest cook)")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("current")]
            public string Current { get; set; }

            [Category("Is Required"),
            Description("Path to the cooked mod directory")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("mod")]
            public string ModDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Output using custom directory name.")]
            [REDName("name")]
            public string DirectoryName { get; set; }

            [Category("Optional"),
            Description("Output directory where the patched content will be dumped.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("path")]
            public string OutputDirectory { get; set; }


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
        [Description("Extracts a list of character templates from cook.db.\n Usage: r4characters -db= -out=")]
        public class r4characters : WCC_Command
        {
            public r4characters()
            {
                Name = "r4characters";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("cook.db file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [Category("Is Required"),
            Description("Outfile")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }
        }

        [Serializable]
        [Description("Extracts a list of character templates from cook.db.\n Usage: r4characters -db= -out=")]
        public class r4charactersdlc : WCC_Command
        {
            public r4charactersdlc()
            {
                Name = "r4charactersdlc";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("cook.db file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [Category("Is Required"),
            Description("Outfile")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }
        }

        [Serializable]
        [Description("Dumps the charset used in a given strings file(*.w3strings).\n Usage: dumpcharset -instringsfile= -outcharsetfile= [options]")]
        public class dumpcharset : WCC_Command
        {
            public dumpcharset()
            {
                Name = "dumpcharset";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Path to the input strings file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("instringsfile")]
            public string Instringsfile { get; set; }

            [Category("Is Required"),
            Description("Path to the out charset file (if not given, default is used).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outcharsetfile")]
            public string Outcharsetfile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Dumps all string entries into filepath. Only in single file mode.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outentriesfile")]
            public string Outentriesfile { get; set; }

            [Category("Optional"),
            Description("Path to base directory for recursive dump. Used with targetlanguage.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("directory")]
            public string Directory { get; set; }

            [Category("Optional"),
            Description("Target language for recursive dump. Used with targetlanguage.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("language")]
            public language Language { get; set; }
        }

        [Serializable]
        [Description("Create USMs.\n Usage:  NO INFO")]
        public class venc : WCC_Command
        {
            public venc()
            {
                Name = "venc";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Input Directory")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string InputDirectory { get; set; }

            [Category("Is Required"),
            Description("")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("usmdir")]
            public string usmDirectory { get; set; }

            [Category("Is Required"),
            Description("")]
            [REDName("bitrate")]
            public int Bitrate { get; set; }

            [Category("Is Required"),
            Description("")]
            [REDName("cue_subs")]
            public bool Cue_subs { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("arabic font file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("ar_font")]
            public string ArabicFontFile { get; set; }

        }
    
        [Serializable]
        [Description("Build dependency cache file.\n Usage: dependencies -out= -report= [-db=]")]
        public class dependencies : WCC_Command
        {
            public dependencies()
            {
                Name = "dependencies";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Save dependency cache to file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            [Category("Is Required"),
            Description("Use dependencies in cook.db file instead of full depot")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Generate dependency report in given directory")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("report")]
            public string report { get; set; }
        }

        [Serializable]
        [Description("Build final bundle lists.\n Usage: exportbundles -db= -seed= -spatial= -out=")]
        public class exportbundles : WCC_Command
        {
            public exportbundles()
            {
                Name = "exportbundles";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Use dependencies in cook.db file instead of full depot")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [Category("Is Required"),
            Description("Initial list of seed files")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("seed")]
            public string Seed { get; set; }

            [Category("Is Required"),
            Description("Additional list of seed files that represent spatial configuration(they override the existing bundles).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("spatial")]
            public string SpatialSeeds { get; set; }

            [Category("Is Required"),
            Description("Absolute path to the final output file (JSON bundle list)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Split bundles into chunks using given split file.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("split")]
            public string split { get; set; }

            [Category("Optional"),
            Description("Use fast compression for bunles(much faster, larged output bundles).")]
            [REDName("extrafast")]
            public bool extrafast { get; set; }
        }

        [Serializable]
        [Description("Check file versions.\n Usage: filever -ext= -file -min -verbose -histogram")]
        public class filever : WCC_Command
        {
            public filever()
            {
                Name = "filever";
            }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Check only files with give extensions")]
            [REDName("ext")]
            public string ext { get; set; }

            [Category("Optional"),
            Description("Check only given files.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }

            [Category("Optional"),
            Description("Treat any file with version lower than given number as error.")]
            [REDName("min")]
            public bool min { get; set; }

            [Category("Optional"),
            Description("Print all invalid files.")]
            [REDName("verbose")]
            public bool verbose { get; set; }

            [Category("Optional"),
            Description("Print version histogram.")]
            [REDName("histogram")]
            public bool histogram { get; set; }
        }

        [Serializable]
        [Description("Saves quest layout for use in external QuestDebugger.\n Usage: questlayoutdump -quest -out")]
        public class questlayoutdump : WCC_Command
        {
            public questlayoutdump()
            {
                Name = "questlayoutdump";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("quest_path")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("quest")]
            public string quest { get; set; }

            [Category("Is Required"),
            Description("dump_path")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }
        }

        [Serializable]
        [Description("Export spatial resource usage information from a given world.\n Usage:  resourceusage -world= -out= [options]")]
        public class resourceusage : WCC_Command
        {
            public resourceusage()
            {
                Name = "resourceusage";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Specifies path to the world file(required)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string world { get; set; }

            [Category("Is Required"),
            Description("Specifies path to the output file(required)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Allow cooking errors")]
            [REDName("noerrors")]
            public bool noerrors { get; set; }

            [Category("Optional"),
            Description("Allow asserts")]
            [REDName("noasserts")]
            public bool noasserts { get; set; }

            [Category("Optional"),
            Description("No output")]
            [REDName("silent")]
            public bool silent { get; set; }
        }

        [Serializable]
        [Description("Don't ask.\n Usage: cooksubs font subtitles")]
        public class cooksubs : WCC_Command
        {
            public cooksubs()
            {
                Name = "cooksubs";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("subtitles_path needs to be ucs-2 little endian because of our engine the output file is utf8...")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("subtitles")]
            public string Subtitles { get; set; }

            [Category("Is Required"),
            Description("NO INFO")]
            [REDName("font")]
            public string Font { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [Description("No operation.\n Usage: wcc cooksounds output_dir sound_resource_dir platforms")]
        public class cooksounds : WCC_Command
        {
            public cooksounds()
            {
                Name = "cooksounds";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("output_dir")]
            public string OutpuDirectory { get; set; }

            [Category("Is Required"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("sound_resource_dir")]
            public string SoundResourceDirectory { get; set; }

            [Category("Is Required"),
            Description("NO INFO")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platforms")]
            public platform Platforms { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [Description("Split the files into content buckets.\n Usage: split -db= [-seed=] -out=")]
        public class split : WCC_Command
        {
            public split()
            {
                Name = "split";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Path to the cook.db file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("db")]
            public string db { get; set; }

            [Category("Is Required"),
            Description("Output file name")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Path to the a seed file (multiple files supported)")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("seed")]
            public string seed { get; set; }

            [Category("Optional"),
            Description("Specify custom fallback chunk for unassigned resources")]
            [REDName("fallback")]
            public string fallback { get; set; }

        }

        [Serializable]
        [Description("Packs a world directories into a single dzip for faster loading and deployment on consoles.\n  Creates streaming installer data for use by the game. Supported cooking platforms: PS4.\n  Usage: package app [options]")]
        public class package : WCC_Command
        {
            public package()
            {
                Name = "package";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("absolute path to final deliverable. E.g., z:\\Build_109641Change_652889\\PS4")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("i")]
            public string InDirectory { get; set; }

            [Category("Is Required"),
            Description("absolute path where to create gp4, pkg and iso")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("o")]
            public string OutDirectory { get; set; }

            [Category("Is Required"),
            Description("absolute path to the language definitions")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("l")]
            public string Language { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("temp directory")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path")]
            [REDName("t")]
            public string TempDirectory { get; set; }


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
        [Description("Splits strings and speech files for a given language based on JSON descriptor.\n Usage:splitstrings[-dlc] -splitfile= -idsfile= -keysfile= -indir= -outdir=")]
        public class splitstrings : WCC_Command
        {
            public splitstrings()
            {
                Name = "splitstrings";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Path to the split file(mapping resources to chunks, not required in DLC mode).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("splitfile")]
            public string Splitfile { get; set; }

            [Category("Is Required"),
            Description("Path to the ids file(mapping resources to string ID's).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("idsfile")]
            public string Idsfile { get; set; }

            [Category("Is Required"),
            Description("Path to the keys file[optional](mapping resources to string Key's).")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("keysfile")]
            public string Keysfile { get; set; }

            [Category("Is Required"),
            Description("Path to the directory where the language files reside.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("indir")]
            public string Indir { get; set; }

            [Category("Is Required"),
            Description("Path to the directory where the split files will reside.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("outdir")]
            public string outdir { get; set; }
        
            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Add language to the splitting plan(default is 'en').")]
            [REDName("language")]
            public language Language { get; set; }

            [Category("Optional"),
            Description("Add platform to the splitting plan(default is 'pc').")]
            [REDName("platform")]
            public platform Platform { get; set; }
        
            [Category("Optional"),
            Description("Run in the DLC mode (no per-chunk splitting)")]
            [REDName("dlc")]
            public bool Dlc { get; set; }

            [Category("Optional"),
            Description("Split strings only (everything is done by default).")]
            [REDName("idsfile")]
            public bool Dostrings { get; set; }

            [Category("Optional"),
            Description("Split speech only(everything is done by default).")]
            [REDName("dospeech")]
            public bool Dospeech { get; set; }

            [Category("Optional"),
            Description("Merges all chunks into content0(debug option).")]
            [REDName("allincontent0")]
            public bool Allincontent0 { get; set; }

            [Category("Optional"),
            Description("Outputs all files in the same folder(debug option).")]
            [REDName("allinsamefolder")]
            public bool allinsamefolder { get; set; }

        }

        [Serializable]
        [Description("Dumps SWF resources.\n Usage: swfdump[out]")]
        public class swfdump : WCC_Command
        {
            public swfdump()
            {
                Name = "swfdump";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("out directory.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out")]
            public string Out { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [Description(" Bulk import resources preserving directory structure.\n Usage: import [option1 value1 [option2 value2 [...]]]")]
        public class swfimport : WCC_Command
        {
            public swfimport()
            {
                Name = "swfimport";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Optional"),
            Description("absolute path to scan inside")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("fromAbsPath")]
            public string InputDirectory { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("depot path to import to")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("toDepotPath")]
            public string DepotPath { get; set; }
        }

        [Serializable]
        [Description("Resaves resources and optionally submits the changes into P4.\n Usage:  resave -tmpdir= [options]")]
        public class resave : WCC_Command
        {
            public resave()
            {
                Name = "resave";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Absolute path to temporary folder.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path")]
            [REDName("tmpdir")]
            public string TempDirectory { get; set; }

            [Category("Optional"),
            Description("Base directory path to scan(full depot resave if not specified).")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("path")]
            public string Path { get; set; }

            [Category("Optional"),
            Description("Comma-separated list of extensions to scan for (full resave if not specified).")]
            [REDName("ext")]
            public string ext { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Disables version control(local resave).")]
            [REDName("nosourcecontrol")]
            public bool nosourcecontrol { get; set; }

            [Category("Optional"),
            Description("Resave even if files are latest version.")]
            [REDName("ignorefileversion")]
            public bool ignorefileversion { get; set; }

            [Category("Optional"),
            Description("Force reset and setup of streaming in world and layers (dangerous!).")]
            [REDName("forcestreamingsetup")]
            public bool forcestreamingsetup { get; set; }

            [Category("Optional"),
            Description("Add resaved files into the given changelist(when enabled).")]
            [REDName("cl")]
            public bool cl { get; set; }

            [Category("Optional"),
            Description("Enables CL submit when finished(disabled by default).")]
            [REDName("submitwhenfinished")]
            public bool submitwhenfinished { get; set; }

            [Category("Optional"),
            Description("Discards files for which data has not changed(disabled by default, potentially slow).")]
            [REDName("discardunchangeddata")]
            public bool discardunchangeddata { get; set; }

            [Category("Optional"),
            Description("Resaves only the given list of files.")]
            [REDName("customresave")]
            public bool customresave { get; set; }

            [Category("Optional"),
            Description("username -- username for Perforce")]
            [REDName("p4user")]
            public bool p4user { get; set; }

            [Category("Optional"),
            Description("client -- client(workspace) for Perforce")]
            [REDName("p4client")]
            public bool p4client { get; set; }

            [Category("Optional"),
            Description("host -- hostname for Perforce")]
            [REDName("p4host")]
            public bool p4host { get; set; }

            [Category("Optional"),
            Description("password -- password for Perforce")]
            [REDName("p4password")]
            public bool p4password { get; set; }

            [Category("Optional"),
            Description("port -- port for Perforce")]
            [REDName("p4port")]
            public bool p4port { get; set; }
        }

        [Serializable]
        [Description("Generate occlusion for given worlds\n Usage: cookocclusion -world= [-smallesOccluder=][-smallestHole=][-tileSize=][-xMin=][-xMax=][-yMin=][-yMax=]")]
        public class cookocclusion : WCC_Command
        {
            public cookocclusion()
            {
                Name = "cookocclusion";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("pathToWorldFile")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("NO INFO")]
            [REDName("smallesOccluder")]
            public string smallesOccluder { get; set; }

            [Category("Optional"),
            Description("NO INFO")]
            [REDName("smallestHole")]
            public string smallestHole { get; set; }

            [Category("Optional"),
            Description("NO INFO")]
            [REDName("tileSize")]
            public string tileSize { get; set; }

            [Category("Optional"),
            Description("NO INFO")]
            [REDName("xMin")]
            public string xMin { get; set; }

            [Category("Optional"),
            Description("NO INFO")]
            [REDName("xMax")]
            public string xMax { get; set; }

            [Category("Optional"),
            Description("NO INFO")]
            [REDName("yMin")]
            public string yMin { get; set; }

            [Category("Optional"),
            Description("NO INFO")]
            [REDName("yMax")]
            public string yMax { get; set; }
        }

        [Serializable]
        [Description("Calculate required memory for runtime occlusion data for the level.\n Usage: calculateRuntimeOcclusionMemory [-density=] -world=")]
        public class calculateRuntimeOcclusionMemory : WCC_Command
        {
            public calculateRuntimeOcclusionMemory()
            {
                Name = "calculateRuntimeOcclusionMemory";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("pathToWorldFile")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("NO INFO")]
            [REDName("density")]
            public string Density { get; set; }
        }

        [Serializable]
        [Description("Find duplicate geometry for the level.\n Usage: findDuplicates -world= [-output=]")]
        public class findDuplicates : WCC_Command
        {
            public findDuplicates()
            {
                Name = "findDuplicates";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("pathToWorldFile")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("file")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("output")]
            public string output { get; set; }
        }

        [Serializable]
        [Description("Generate navigation data for given world.\n Usage: pathlib -rootSearchDir= -filePattern=")]
        public class pathlib : WCC_Command
        {
            public pathlib()
            {
                Name = "pathlib";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("rootSearchDir")]
            public string RootSearchDir { get; set; }

            [Category("Is Required"),
            Description("NO INFO")]
            [REDName("FilePattern")]
            public string FilePattern { get; set; }
        }

        [Serializable]
        [Description(" Cooks strings and speech database, given a list of languages and platforms.\n Usage: pcookstrings -out_dir= -source_dir= -db_string_view= -languages= -platforms=")]
        public class cookstrings : WCC_Command
        {
            public cookstrings()
            {
                Name = "cookstrings";
            }

            /// <summary>
            /// Required
            /// </summary>
            /// 
            [Category("Is Required"),
            Description("Path to the base directory where speech data resides.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("source_dir")]
            public string InputDirectory { get; set; }

            [Category("Is Required"),
            Description("Path to the directory where the caches will be stored.")]
            //[EditorAttribute(typeof(FolderNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "Out")]
            [REDName("out_dir")]
            public string OutputDirectory { get; set; }

            [Category("Is Required"),
            Description("SQL query.")]
            [REDName("db_string_view")]
            public string db_string_view { get; set; }

            [Category("Is Required"),
            Description("List of languages to cook.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("languages")]
            public language Languages { get; set; }

            [Category("Is Required"),
            Description("List of platforms to cook for.")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platforms")]
            public platform Platforms { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
            [Category("Optional"),
            Description("Cooks only strings.")]
            [REDName("skipspeech")]
            public bool Skipspeech { get; set; }
        }

        [Serializable]
        [Description("Test asynchronous collision cache access.\n Usage: testcollisioncache -file=")]
        public class testcollisioncache : WCC_Command
        {
            public testcollisioncache()
            {
                Name = "testcollisioncache";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("File Cache.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("file")]
            public string File { get; set; }
        }
    
        [Serializable]
        [Description(" Test memory framework, streaming, GC and resource management stability.\n Usage: testmem[params]")]
        public class testmem : WCC_Command
        {
            public testmem()
            {
                Name = "testmem";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("Path to the w2w file to load.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("world")]
            public string WorldFile { get; set; }

            [Category("Is Required"),
            Description("Number of test iterations.")]
            [REDName("numiter")]
            public string TestIterations { get; set; }

            [Category("Is Required"),
            Description("Number of test points.")]
            [REDName("numpoints")]
            public string TestPoints { get; set; }

            [Category("Is Required"),
            Description("Extents (around origin) to test.")]
            [REDName("extents")]
            public string Extents { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
        }

        [Serializable]
        [Description("Convert voiceover files from .wav to .ogg.\n Usage: wcc voconvert -wwise_bin_dir= -voiceivers_source_dir= -platform= languages=")]
        public class voconvert : WCC_Command
        {
            public voconvert()
            {
                Name = "voconvert";
            }

            /// <summary>
            /// Required
            /// </summary>
            [Category("Is Required"),
            Description("NO INFO.")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("wwise_bin_dir")]
            public string Wwise_bin_dir { get; set; }

            [Category("Is Required"),
            Description("NO INFO")]
            //[EditorAttribute(typeof(FileNameEditor), typeof(System.Drawing.Design.UITypeEditor))]
            [REDTags("Path", "In")]
            [REDName("voiceivers_source_dir")]
            public string Voiceivers_source_dir { get; set; }

            [Category("Is Required"),
            Description("Platform (pc ..)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("platform")]
            public platform Platform { get; set; }

            [Category("Is Required"),
            Description("Languages (en, de...)")]
            [TypeConverter(typeof(EnumConverter))]
            [REDName("languages")]
            public language Languages { get; set; }

            /// <summary>
            /// Optional
            /// </summary>
        }

        #endregion

        #region Unknown Commands
        [Serializable]
        [Description("Simply tests wcc.")]
        public class cookertest : WCC_Command
        {
            public cookertest()
            {
                Name = "cookertest";
            }

        }
        [Serializable]
        [Description("Glues files into optimal files. \n Usage: NO INFO")]
        public class gluefiles : WCC_Command
        {
            public gluefiles()
            {
                Name = "gluefiles";
            }

        }

        [Serializable]
        [Description("Glues files into optimal files. \n Usage: NO INFO")]
        public class gluefilesdlc : WCC_Command
        {
            public gluefilesdlc()
            {
                Name = "gluefilesdlc";
            }

        }

        [Serializable]
        [Description("Attempts to load all resources to check for errors.\n Usage: NO INFO")]
        public class loadtest : WCC_Command
        {
            public loadtest()
            {
                Name = "loadtest";
            }

        }

        [Serializable]
        [Description("Creates the .dep files Creates the .dep files needed for the database creation used by the Database Viewer.\n Usage:  NO INFO")]
        public class WorldSceneDependencyInfoFiles : WCC_Command
        {
            public WorldSceneDependencyInfoFiles()
            {
                Name = "WorldSceneDependencyInfoFiles";
            }

        }



            #endregion
    }
}