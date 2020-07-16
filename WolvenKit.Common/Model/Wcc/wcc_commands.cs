using System.ComponentModel;
using System.IO;
using System.Windows.Forms.Design;
using System.Runtime.CompilerServices;
using System;

namespace WolvenKit.Common.Wcc
{
    /// <summary>
    /// All wcc_lite commands.
    /// </summary>
    public static class Wcc_lite
    {

    



    #region Common Commands

    [Serializable]
    [DescriptionAttribute("Uncooks resources from a given bundle set.\n Usage:  uncook -indir= -outdir = [options]")]
    public class uncook : WCC_Command
    {
        public uncook()
        {
            Name = "uncook";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required")]
        [DescriptionAttribute("Path to the bundled directory.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("indir")]
        public string InputDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the unbundled directory.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string OutputDirectory { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Path to the input strings file.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("infile")]
        public string InputFile { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Relative inner path to be extracted.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("In")]
        [REDName("targetdir")]
        public string TargetDirectory { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Comma delineated list of file extensions to uncook. If options missing will uncook all av")]
        [REDName("uncookext")]
        public string UncookExtensions { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Image format for XBM files. Choose one of bmp, png, jpg, or tga. Default is tga.")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("imgfmt")]
        public imageformat Imgfmt { get; set; } //enum

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Dump redswf files.")]
        [REDName("dumpswf")]
        public bool Dumpswf { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Upon failure, skips to the next file.")]
        [REDName("skiperrors")]
        public bool Skiperrors { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Unbundles data without uncooking it.")]
        [REDName("unbundleonly")]
        public bool Unbundleonly { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Target language for recursive dump. Used with targetlanguage.")]
        [REDName("uncookonly")]
        public bool Uncookonly { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Dumps info for bundled files.\n Usage: dumpbundleinfo -indir= -outpath=")]
    public class dumpbundleinfo : WCC_Command
    {
        public dumpbundleinfo()
        {
            Name = "dumpbundleinfo";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Directory with the bundles (recursive).")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("indir")]
        public string Indir { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Absolute path to output text file.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("outfile")]
        public string Outfile { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("where to place output.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outpath")]
        public string Outpath { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Absolute path to input bundle (multiple can be specified).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("infile")]
        public string Infile { get; set; }

    }

    [Serializable]
    [DescriptionAttribute("Export single assets from the engine. \n Usage: export -depot= -file= -out=")]
    public class export : WCC_Command
    {
        public export()
        {
            Name = "export";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("local - Use local depot(r4data)\n absolutepath - Use depot at given directory.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("depot")]
        public string Depot { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("relativepath - Local(depot) path for the file to export.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("absolutepath - Output absolute path for the exported file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("fbxversion - (Optional) Specify output FBX version - 2016, 2013, 2011, 2010, 2009.")]
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
    [DescriptionAttribute("Import assets into the engine. \n Usage: import -depot= -file= -out=")]
    public class import : WCC_Command
    {
        public import()
        {
            Name = "import";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("local - Use local depot(r4data) /n absolutepath - Use depot at given directory")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("depot")]
        public string Depot { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("inputfile - Absolute path to file to import")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("outputfile - Relative(depot) path for the output file")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("nameofgroup - (Optional) Name of texture group when importing texture.")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("texturegroup")]
        public ETextureGroup texturegroup { get; set; }

    }

    [Serializable]
    [DescriptionAttribute("Dump file content(objects).\n Usage: dumpfile -file= -dir= -out=")]
    public class dumpfile : WCC_Command
    {
        public dumpfile()
        {
            Name = "dumpfile";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute(" dump the whole directory (recursive)")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("dir")]
        public string Dir { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("absolute path to the output file")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("depot path to the file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("exclude given file extensions")]
        [REDName("exclude")]
        public string Exclude { get; set; }
    }

    [Serializable]
    [DescriptionAttribute(" Unbundle the files.\n Usage: unbundle -dir= -outdir=")]
    public class unbundle : WCC_Command
    {
        public unbundle()
        {
            Name = "unbundle";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("directory with the bundles (recursive)")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("dir")]
        public string InputDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("absolute path to output directory")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string OutputDirectory { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("optional bundles.json dump (for repacking)")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("json")]
        public string Json { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Build data cache from cooked assets.\n Usage:  buildcache -db -out [optional params]")]
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
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Available Cache builders: physics, shaders, texture. ")]
        [Editor(typeof(EnumConverter), typeof(EnumConverter))]
        [REDName("builder")]
        public cachebuilder builder { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to cook.db.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string DataBase { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Uncooked Base Directory")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("basedir")]
        public string basedir { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Select target platform(required)")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("platform")]
        public platform Platform { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to output cache file.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("N - Process every Nth file")]
        [REDName("modulo")]
        public string Modulo { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("X - Initial offset for processing(use only with -modulo)")]
        [REDName("offset")]
        public string Offset { get; set; }

       
    }

    [Serializable]
    [DescriptionAttribute("Generates a metadata.store file for the specified directory.\n Usage: metadatastore -path=")]
    public class metadatastore : WCC_Command
    {
        public metadatastore()
        {
            Name = "metadatastore";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to bundles directory.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("path")]
        public string Directory { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Cook file lists, generate cooked data and bundle files for packing.\n Usage: cook")]
    public class cook : WCC_Command
    {
        public cook()
        {
            Name = "cook";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Select target platform(required)")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("platform")]
        public platform Platform { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Sepcify output directory(required).")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string outdir { get; set; }


        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("basedir")]
        public string basedir { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("mod")]
        public string mod { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Input seed file(required).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("seed")]
        public string seed { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Manual depot file for cooking.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Cook.db file to check if it containes trimmed files.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("additionalDB")]
        public string AdditionalDB { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("List of trimmed files from cook.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path")]
        [REDName("trimedfiles")]
        public string trimedfiles { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Don't cook resources from one directory.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("excludedir")]
        public string excludedir { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Cook resources only from one directory.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("trimdir")]
        public string trimdir { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Allow cooking errors.")]
        [REDName("noerrors")]
        public bool noerrors { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Allow asserts.")]
        [REDName("noasserts")]
        public bool noasserts { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("No output.")]
        [REDName("silent")]
        public bool silent { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Ignore files with given extension.")]
        [REDName("ignore")]
        public bool ignore { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Capture and save all cooked string ID's.")]
        [REDName("stringids")]
        public bool stringids { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Capture and save all cooked string key's.")]
        [REDName("stringkeys")]
        public bool stringkeys { get; set; }


    }

    [Serializable]
    [DescriptionAttribute("Packs file from given directory into a bundle.\n Usage: pack -dir= -outdir= [-compression=]")]
    public class pack : WCC_Command
    {
        public pack()
        {
            Name = "pack";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Input directory to pack")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("dir")]
        public string Directory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Output directory with bundles (note: bundles bigger than 4GB are split)")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string Outdir { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Compression type to use(default: LZ4HC)")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("compression")]
        public compression compression { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Cooks materials.\n Usage: cookmaterials -platform (-material=) (-fur=)")]
    public class cookmaterials : WCC_Command
    {
        public cookmaterials()
        {
            Name = "cookmaterials";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("platform")]
        public platform Platform { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("")]
        [REDName("static")]
        public bool Static { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("")]
        [REDName("fastfx")]
        public bool fastfx { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("")]
        [REDName("allmaterials")]
        public bool allmaterials { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("")]
        [REDName("material")]
        public string material { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("")]
        [REDName("resaveCRC")]
        public bool resaveCRC { get; set; }
        
        [CategoryAttribute("Optional"),
        DescriptionAttribute("")]
        [REDName("fur")]
        public string fur { get; set; }
    }

    #endregion

    #region Uncommon Commands

    [Serializable]
    [DescriptionAttribute("Analyze game and engine data and output cook lists.\n Usage: analyze -out [optional params]")]
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
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Choose object to analyze.")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("analyzer")]
        public analyzers Analyzer { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Output absolute path")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Choose file to analyze.")]
        [REDName("Object")]
        public string Object { get; set; }/// 

        [CategoryAttribute("Optional"),
        DescriptionAttribute("reddlc relative path to use with analyze r4dlc")]
        [REDName("-dlc")]
        public string reddlc { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Split cache file into multiple files.\n Usage: splitcache -file= -db=<cook.db> -outdir= Options:")]
    public class splitcache : WCC_Command
    {
        public splitcache()
        {
            Name = "splitcache";
        }
        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("input cache file.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get;set;}

        [CategoryAttribute("Is Required")]
        [DescriptionAttribute("path to the cook.db file to use as a reference")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string Database { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("where to place output caches.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string OutputDirectory { get; set; }


        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("use custom fallback chunk name")]
        [REDName("fallback")]
        public string Fallback { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("remove data from non cooked files")]
        [REDName("strip")]
        public bool Strip { get; set; }
        
    }

    [Serializable]
    [DescriptionAttribute("Reports file usage and chunk distribution of a given cook database.\n Usage: reportchunks -db= -out=")]
    public class reportchunks : WCC_Command
    {
        public reportchunks()
        {
            Name = "reportchunks";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("path to the cook.db file to use as a reference")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string Database { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("where to place output.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Output { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Outputs exhaustive report(default).")]
        [REDName("showall")]
        public bool Showall { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Outputs global statistics.")]
        [REDName("showsumary")]
        public bool Showsumary { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Outputs extension/chunk statistics.")]
        [REDName("showextensions")]
        public bool showextensions { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Outputs file/chunk statistics (slow!).")]
        [REDName("showfilechunks")]
        public bool showfilechunks { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Outputs the list of files in each chunk(slow!)")]
        [REDName("showchunkfiles")]
        public bool showchunkfiles { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Dump data from compiled scripts. \n Usage: dumpscripts -file= -out=")]
    public class dumpscripts : WCC_Command
    {
        public dumpscripts()
        {
            Name = "dumpscripts";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("<scriptfile.redscripts> - Input file (compiled script binary).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("<outputfile.txt> - Output report file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("outpath")]
        public string Outpath { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Validate resources.\n Usage: validate[-db= -file = -all] -outdir=")]
    public class validate : WCC_Command
    {
        public validate()
        {
            Name = "validate";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("cook.db file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string db { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Validate single file.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string Outdir { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Validate all files in depot (not recommended)")]
        [REDName("all")]
        public bool all { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Save Dialog Lines.\n Usage: get_txts -db= -outdir= [-lang=]")]
    public class get_txts : WCC_Command
    {
        public get_txts()
        {
            Name = "get_txts";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("cook.db file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string db { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string OutputDirectory { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("lang")]
        public language lang { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Optimize(resort) collision cache.\n Usage: optimizecollisioncache -file= -out=")]
    public class optimizecollisioncache : WCC_Command
    {
        public optimizecollisioncache()
        {
            Name = "optimizecollisioncache";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("depot path to the file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("absolute path to the output file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Generalized commandlet for creating differential patches for specified type of content.\n ote: you can use -mod OR -current params\n Usage: patch -base= -current= -mod= [-name= ] -outdir=")]
    public class patch : WCC_Command
    {
        public patch()
        {
            Name = "patch";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the base build (GoldMaster)")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("base")]
        public string Base { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("(pro) Path to the current build (latest cook)")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("current")]
        public string Current { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the cooked mod directory")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("mod")]
        public string ModDirectory { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Output using custom directory name.")]
        [REDName("name")]
        public string DirectoryName { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Output directory where the patched content will be dumped.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
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
    [DescriptionAttribute("Extracts a list of character templates from cook.db.\n Usage: r4characters -db= -out=")]
    public class r4characters : WCC_Command
    {
        public r4characters()
        {
            Name = "r4characters";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("cook.db file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string db { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Outfile")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Extracts a list of character templates from cook.db.\n Usage: r4characters -db= -out=")]
    public class r4charactersdlc : WCC_Command
    {
        public r4charactersdlc()
        {
            Name = "r4charactersdlc";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("cook.db file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string db { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Outfile")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Dumps the charset used in a given strings file(*.w3strings).\n Usage: dumpcharset -instringsfile= -outcharsetfile= [options]")]
    public class dumpcharset : WCC_Command
    {
        public dumpcharset()
        {
            Name = "dumpcharset";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the input strings file.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("instringsfile")]
        public string Instringsfile { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the out charset file (if not given, default is used).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("outcharsetfile")]
        public string Outcharsetfile { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Dumps all string entries into filepath. Only in single file mode.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("outentriesfile")]
        public string Outentriesfile { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Path to base directory for recursive dump. Used with targetlanguage.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("directory")]
        public string Directory { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Target language for recursive dump. Used with targetlanguage.")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("language")]
        public language Language { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Create USMs.\n Usage:  NO INFO")]
    public class venc : WCC_Command
    {
        public venc()
        {
            Name = "venc";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Input Directory")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("indir")]
        public string InputDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("usmdir")]
        public string usmDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("")]
        [REDName("bitrate")]
        public int Bitrate { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("")]
        [REDName("cue_subs")]
        public bool Cue_subs { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("arabic font file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("ar_font")]
        public string ArabicFontFile { get; set; }

    }
    
    [Serializable]
    [DescriptionAttribute("Build dependency cache file.\n Usage: dependencies -out= -report= [-db=]")]
    public class dependencies : WCC_Command
    {
        public dependencies()
        {
            Name = "dependencies";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Save dependency cache to file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Use dependencies in cook.db file instead of full depot")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string db { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Generate dependency report in given directory")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("report")]
        public string report { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Build final bundle lists.\n Usage: exportbundles -db= -seed= -spatial= -out=")]
    public class exportbundles : WCC_Command
    {
        public exportbundles()
        {
            Name = "exportbundles";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Use dependencies in cook.db file instead of full depot")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string db { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Initial list of seed files")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("seed")]
        public string Seed { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Additional list of seed files that represent spatial configuration(they override the existing bundles).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("spatial")]
        public string SpatialSeeds { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Absolute path to the final output file (JSON bundle list)")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Split bundles into chunks using given split file.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("split")]
        public string split { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Use fast compression for bunles(much faster, larged output bundles).")]
        [REDName("extrafast")]
        public bool extrafast { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Check file versions.\n Usage: filever -ext= -file -min -verbose -histogram")]
    public class filever : WCC_Command
    {
        public filever()
        {
            Name = "filever";
        }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Check only files with give extensions")]
        [REDName("ext")]
        public string ext { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Check only given files.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Treat any file with version lower than given number as error.")]
        [REDName("min")]
        public bool min { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Print all invalid files.")]
        [REDName("verbose")]
        public bool verbose { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Print version histogram.")]
        [REDName("histogram")]
        public bool histogram { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Saves quest layout for use in external QuestDebugger.\n Usage: questlayoutdump -quest -out")]
    public class questlayoutdump : WCC_Command
    {
        public questlayoutdump()
        {
            Name = "questlayoutdump";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("quest_path")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("quest")]
        public string quest { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("dump_path")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Export spatial resource usage information from a given world.\n Usage:  resourceusage -world= -out= [options]")]
    public class resourceusage : WCC_Command
    {
        public resourceusage()
        {
            Name = "resourceusage";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Specifies path to the world file(required)")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("world")]
        public string world { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Specifies path to the output file(required)")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Allow cooking errors")]
        [REDName("noerrors")]
        public bool noerrors { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Allow asserts")]
        [REDName("noasserts")]
        public bool noasserts { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("No output")]
        [REDName("silent")]
        public bool silent { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Don't ask.\n Usage: cooksubs font subtitles")]
    public class cooksubs : WCC_Command
    {
        public cooksubs()
        {
            Name = "cooksubs";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("subtitles_path needs to be ucs-2 little endian because of our engine the output file is utf8...")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("subtitles")]
        public string Subtitles { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        [REDName("font")]
        public string Font { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
    }

    [Serializable]
    [DescriptionAttribute("No operation.\n Usage: wcc cooksounds output_dir sound_resource_dir platforms")]
    public class cooksounds : WCC_Command
    {
        public cooksounds()
        {
            Name = "cooksounds";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("output_dir")]
        public string OutpuDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("sound_resource_dir")]
        public string SoundResourceDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("platforms")]
        public platform Platforms { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
    }

    [Serializable]
    [DescriptionAttribute("Split the files into content buckets.\n Usage: split -db= [-seed=] -out=")]
    public class split : WCC_Command
    {
        public split()
        {
            Name = "split";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the cook.db file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("db")]
        public string db { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Output file name")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Path to the a seed file (multiple files supported)")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("seed")]
        public string seed { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Specify custom fallback chunk for unassigned resources")]
        [REDName("fallback")]
        public string fallback { get; set; }

    }

    [Serializable]
    [DescriptionAttribute("Packs a world directories into a single dzip for faster loading and deployment on consoles.\n  Creates streaming installer data for use by the game. Supported cooking platforms: PS4.\n  Usage: package app [options]")]
    public class package : WCC_Command
    {
        public package()
        {
            Name = "package";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("absolute path to final deliverable. E.g., z:\\Build_109641Change_652889\\PS4")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("i")]
        public string InDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("absolute path where to create gp4, pkg and iso")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("o")]
        public string OutDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("absolute path to the language definitions")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("l")]
        public string Language { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("temp directory")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
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
    [DescriptionAttribute("Splits strings and speech files for a given language based on JSON descriptor.\n Usage:splitstrings[-dlc] -splitfile= -idsfile= -keysfile= -indir= -outdir=")]
    public class splitstrings : WCC_Command
    {
        public splitstrings()
        {
            Name = "splitstrings";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the split file(mapping resources to chunks, not required in DLC mode).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("splitfile")]
        public string Splitfile { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the ids file(mapping resources to string ID's).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("idsfile")]
        public string Idsfile { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the keys file[optional](mapping resources to string Key's).")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("keysfile")]
        public string Keysfile { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the directory where the language files reside.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("indir")]
        public string Indir { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the directory where the split files will reside.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("outdir")]
        public string outdir { get; set; }
        
        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Add language to the splitting plan(default is 'en').")]
        [REDName("language")]
        public language Language { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Add platform to the splitting plan(default is 'pc').")]
        [REDName("platform")]
        public platform Platform { get; set; }
        
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Run in the DLC mode (no per-chunk splitting)")]
        [REDName("dlc")]
        public bool Dlc { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Split strings only (everything is done by default).")]
        [REDName("idsfile")]
        public bool Dostrings { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Split speech only(everything is done by default).")]
        [REDName("dospeech")]
        public bool Dospeech { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Merges all chunks into content0(debug option).")]
        [REDName("allincontent0")]
        public bool Allincontent0 { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Outputs all files in the same folder(debug option).")]
        [REDName("allinsamefolder")]
        public bool allinsamefolder { get; set; }

    }

    [Serializable]
    [DescriptionAttribute("Dumps SWF resources.\n Usage: swfdump[out]")]
    public class swfdump : WCC_Command
    {
        public swfdump()
        {
            Name = "swfdump";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("out directory.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out")]
        public string Out { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
    }

    [Serializable]
    [DescriptionAttribute(" Bulk import resources preserving directory structure.\n Usage: import [option1 value1 [option2 value2 [...]]]")]
    public class swfimport : WCC_Command
    {
        public swfimport()
        {
            Name = "swfimport";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("absolute path to scan inside")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("fromAbsPath")]
        public string InputDirectory { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("depot path to import to")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("toDepotPath")]
        public string DepotPath { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Resaves resources and optionally submits the changes into P4.\n Usage:  resave -tmpdir= [options]")]
    public class resave : WCC_Command
    {
        public resave()
        {
            Name = "resave";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Absolute path to temporary folder.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path")]
        [REDName("tmpdir")]
        public string TempDirectory { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Base directory path to scan(full depot resave if not specified).")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("path")]
        public string Path { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Comma-separated list of extensions to scan for (full resave if not specified).")]
        [REDName("ext")]
        public string ext { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("Disables version control(local resave).")]
        [REDName("nosourcecontrol")]
        public bool nosourcecontrol { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Resave even if files are latest version.")]
        [REDName("ignorefileversion")]
        public bool ignorefileversion { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Force reset and setup of streaming in world and layers (dangerous!).")]
        [REDName("forcestreamingsetup")]
        public bool forcestreamingsetup { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Add resaved files into the given changelist(when enabled).")]
        [REDName("cl")]
        public bool cl { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Enables CL submit when finished(disabled by default).")]
        [REDName("submitwhenfinished")]
        public bool submitwhenfinished { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Discards files for which data has not changed(disabled by default, potentially slow).")]
        [REDName("discardunchangeddata")]
        public bool discardunchangeddata { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("Resaves only the given list of files.")]
        [REDName("customresave")]
        public bool customresave { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("username -- username for Perforce")]
        [REDName("p4user")]
        public bool p4user { get; set; }

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
    }

    [Serializable]
    [DescriptionAttribute("Generate occlusion for given worlds\n Usage: cookocclusion -world= [-smallesOccluder=][-smallestHole=][-tileSize=][-xMin=][-xMax=][-yMin=][-yMax=]")]
    public class cookocclusion : WCC_Command
    {
        public cookocclusion()
        {
            Name = "cookocclusion";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("pathToWorldFile")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("world")]
        public string WorldFile { get; set; }

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

        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        [REDName("xMin")]
        public string xMin { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        [REDName("xMax")]
        public string xMax { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        [REDName("yMin")]
        public string yMin { get; set; }

        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        [REDName("yMax")]
        public string yMax { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Calculate required memory for runtime occlusion data for the level.\n Usage: calculateRuntimeOcclusionMemory [-density=] -world=")]
    public class calculateRuntimeOcclusionMemory : WCC_Command
    {
        public calculateRuntimeOcclusionMemory()
        {
            Name = "calculateRuntimeOcclusionMemory";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("pathToWorldFile")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("world")]
        public string WorldFile { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("NO INFO")]
        [REDName("density")]
        public string Density { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Find duplicate geometry for the level.\n Usage: findDuplicates -world= [-output=]")]
    public class findDuplicates : WCC_Command
    {
        public findDuplicates()
        {
            Name = "findDuplicates";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("pathToWorldFile")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("world")]
        public string WorldFile { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [CategoryAttribute("Optional"),
        DescriptionAttribute("file")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "Out")]
        [REDName("output")]
        public string output { get; set; }
    }

    [Serializable]
    [DescriptionAttribute("Generate navigation data for given world.\n Usage: pathlib -rootSearchDir= -filePattern=")]
    public class pathlib : WCC_Command
    {
        public pathlib()
        {
            Name = "pathlib";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("rootSearchDir")]
        public string RootSearchDir { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        [REDName("FilePattern")]
        public string FilePattern { get; set; }
    }

    [Serializable]
    [DescriptionAttribute(" Cooks strings and speech database, given a list of languages and platforms.\n Usage: pcookstrings -out_dir= -source_dir= -db_string_view= -languages= -platforms=")]
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
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the base directory where speech data resides.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "In")]
        [REDName("source_dir")]
        public string InputDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the directory where the caches will be stored.")]
        //[Editor(typeof(PropertyGridFolderPicker), typeof(PropertyGridFolderPicker))]
        [REDTags("Path", "Out")]
        [REDName("out_dir")]
        public string OutputDirectory { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("SQL query.")]
        [REDName("db_string_view")]
        public string db_string_view { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("List of languages to cook.")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("languages")]
        public language Languages { get; set; }

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
    }

    [Serializable]
    [DescriptionAttribute("Test asynchronous collision cache access.\n Usage: testcollisioncache -file=")]
    public class testcollisioncache : WCC_Command
    {
        public testcollisioncache()
        {
            Name = "testcollisioncache";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("File Cache.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("file")]
        public string File { get; set; }
    }
    
    [Serializable]
    [DescriptionAttribute(" Test memory framework, streaming, GC and resource management stability.\n Usage: testmem[params]")]
    public class testmem : WCC_Command
    {
        public testmem()
        {
            Name = "testmem";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Path to the w2w file to load.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("world")]
        public string WorldFile { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Number of test iterations.")]
        [REDName("numiter")]
        public string TestIterations { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Number of test points.")]
        [REDName("numpoints")]
        public string TestPoints { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Extents (around origin) to test.")]
        [REDName("extents")]
        public string Extents { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
    }

    [Serializable]
    [DescriptionAttribute("Convert voiceover files from .wav to .ogg.\n Usage: wcc voconvert -wwise_bin_dir= -voiceivers_source_dir= -platform= languages=")]
    public class voconvert : WCC_Command
    {
        public voconvert()
        {
            Name = "voconvert";
        }

        /// <summary>
        /// Required
        /// </summary>
        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO.")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("wwise_bin_dir")]
        public string Wwise_bin_dir { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("NO INFO")]
        //[Editor(typeof(PropertyGridFilePicker), typeof(PropertyGridFilePicker))]
        [REDTags("Path", "In")]
        [REDName("voiceivers_source_dir")]
        public string Voiceivers_source_dir { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Platform (pc ..)")]
        [TypeConverter(typeof(EnumConverter))]
        [REDName("platform")]
        public platform Platform { get; set; }

        [CategoryAttribute("Is Required"),
        DescriptionAttribute("Languages (en, de...)")]
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
    [DescriptionAttribute("Simply tests wcc.")]
    public class cookertest : WCC_Command
    {
        public cookertest()
        {
            Name = "cookertest";
        }

    }
    [Serializable]
    [DescriptionAttribute("Glues files into optimal files. \n Usage: NO INFO")]
    public class gluefiles : WCC_Command
    {
        public gluefiles()
        {
            Name = "gluefiles";
        }

    }

    [Serializable]
    [DescriptionAttribute("Glues files into optimal files. \n Usage: NO INFO")]
    public class gluefilesdlc : WCC_Command
    {
        public gluefilesdlc()
        {
            Name = "gluefilesdlc";
        }

    }

    [Serializable]
    [DescriptionAttribute("Attempts to load all resources to check for errors.\n Usage: NO INFO")]
    public class loadtest : WCC_Command
    {
        public loadtest()
        {
            Name = "loadtest";
        }

    }

    [Serializable]
    [DescriptionAttribute("Creates the .dep files Creates the .dep files needed for the database creation used by the Database Viewer.\n Usage:  NO INFO")]
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