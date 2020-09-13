using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;
using static System.ConsoleColor;

namespace WolvenKit.Console
{
    using Bundles;
    using Common;
    using CR2W;
    using CR2W.Editors;
    using Konsole;
    using Npgsql;
    using NpgsqlTypes;
    using System.Collections.Concurrent;
    using System.IO;
    using System.IO.MemoryMappedFiles;
    using System.Threading;
    using WolvenKit.Common.Extensions;

    public partial class WolvenKitConsole
    {
        internal class Progress
        {
            public int pgr;
            public Progress(int val) => pgr = val;
        }

        internal struct BatchInsertBufferWrapper
        {
            public string CommandHeader;
            public ConcurrentStack<string> InsertBuffer;
            public BatchInsertBufferWrapper(string cmdheader)
            {
                CommandHeader = cmdheader;
                InsertBuffer = new ConcurrentStack<string>();
            }
        }

        private static int CR2WToPostgres(CR2WToPostgresOptions options)
        {
            // NB : There are two main ways to send data to a database : batch inserts and bulky copy.
            // Bulk copy avoids most checks from the db (referential integrity, triggers...) and is much faster.

            //----------------------------------------------------------------------------------
            // I. Setup
            //----------------------------------------------------------------------------------
            // 1) Connecting to db
            //----------------------------------------------------------------------------------
            #region I.dumpsetup
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine("I. Setup");
            System.Console.WriteLine("--------------------------------------------");
            var connString = "Host=localhost;Username=postgres;Password=postgrespwd;Database=wmod";

            System.Console.WriteLine("  1) Connecting to postgres...");
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            System.Console.WriteLine("  2) Populating mappings from db...");
            // 2) Populating cr2w class mappings from db
            //----------------------------------------------------------------------------------
            #region I.2.dbmapping
            var lod2dict = new ConcurrentDictionary<string, int>(); // lod2 absolute_path --> lod2_file_id
            var lod1dict = new ConcurrentDictionary<Tuple<int, string>, int>(); // lod2_id + absolute_virtual_path --> lod1_file_id
            var lod1x2dict = new ConcurrentDictionary<Tuple<int, int>, int>(); // lod1_id + lod2_id --> cr2w_file_id
            var classdict = new ConcurrentDictionary<string, int>(); // class name hash --> class_id
            var propertydict = new ConcurrentDictionary<Tuple<int, string>, int>(); // class_id + propname --> prop_id

            int globalfileidcounter; // number of lod2xlod1 files so far
            // max file_id

            var cmd = new NpgsqlCommand("SELECT max(file_id) from lod0xlod1_file", conn);
            var reader = cmd.ExecuteReader();
            reader.Read();
            globalfileidcounter =reader.GetInt32(0);
            reader.Close();
            cmd.Dispose();
            System.Console.WriteLine("\t... " + globalfileidcounter + "\tlod2xlod1 files so far.");


            // lod2dict - lod2 absolute_path --> lod2_file_id
            uint bundlecnt = 0;
            cmd = new NpgsqlCommand("SELECT _absolute_path, lod0_file_id from lod0_file join physical_inode using(physical_inode_id) where archive_type='Bundle'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bundlecnt++;
                lod2dict.TryAdd(reader.GetString(0), reader.GetInt32(1));
            }
            reader.Close();
            cmd.Dispose();
            System.Console.WriteLine("\t... " + bundlecnt + "\t\tlod2 files read :\tlod2 dictionary complete.");

            // lod1dict - lod2_id + absolute_virtual_path --> lod1_file_id
            // lod1x2dict - lod1_id + lod2_id --> cr2w_file_id
            uint lod1cnt = 0;
            cmd = new NpgsqlCommand("select l01.lod0_file_id, vi._absolute_path, l1.lod1_file_id, l01.file_id from lod1_file l1 join virtual_inode vi using(virtual_inode_id) join lod0xlod1_file l01 using(lod1_file_id) join lod0_file l0 using(lod0_file_id) where l0.archive_type='Bundle'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lod1cnt++;
                var lod0_file_id = reader.GetInt32(0);
                var absolute_path = reader.GetString(1);
                var lod1_file_id = reader.GetInt32(2);
                var crw_file_id = reader.GetInt32(3);
                lod1dict.TryAdd(Tuple.Create(lod0_file_id, absolute_path), lod1_file_id);
                lod1x2dict.TryAdd(Tuple.Create(lod0_file_id, lod1_file_id), crw_file_id);

            }
            reader.Close();
            cmd.Dispose();
            System.Console.WriteLine("\t... " + lod1cnt + "\tlod1 files read :\tlod1 dictionary complete.");
            System.Console.WriteLine("\t... " + lod1cnt + "\tlod1x2 files read :\tlod1x2 dictionary complete.");

            // classdict - class name hash --> class_id
            uint classcnt = 0;
            cmd = new NpgsqlCommand("select name, class_id from rtti.big_class", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                classcnt++;
                classdict.TryAdd(reader.GetString(0), reader.GetInt32(1));
            }
            reader.Close();
            cmd.Dispose();
            System.Console.WriteLine("\t... " + classcnt + "\tclasses read :\t\tclass dictionary complete.");

            // propertydict - class_id + propname --> prop_id
            uint propcnt = 0;
            cmd = new NpgsqlCommand("select class_id, propname, prop_id from rtti.big_class " +
                "join rtti.big_prop on name=classname", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                propcnt++;
                propertydict.TryAdd(new Tuple<int, string>(reader.GetInt32(0), reader.GetString(1)), reader.GetInt32(2));
            }
            reader.Close();
            cmd.Dispose();
            System.Console.WriteLine("\t... " + propcnt + "\tproperties read :\tproperty dictionary complete.");
            conn.Close();
            #endregion //dbmappings

            // 3) Load MemoryMapped Bundles
            //----------------------------------------------------------------------------------
            System.Console.WriteLine("  3) Initializing bundles...");
            var bm = new BundleManager();
            bm.LoadAll("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");

            System.Console.WriteLine("\t... " + bm.Bundles.Count + "\t\tdone.");
            #endregion //dumpsetup


            // II. Dumping cr2w to db
            //----------------------------------------------------------------------------------
            #region II.dump
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine("II. Dump cr2w to database");
            System.Console.WriteLine("--------------------------------------------");
            System.Console.WriteLine("  Creating cr2w insert commands...");
            var bundles = bm.Bundles.Values.ToList();
            List<IWitcherFile> files = bm.Items.SelectMany(_ => _.Value).ToList();
            int globalcvarcounter = 1;

            Encoding iso88591 = Encoding.GetEncoding("ISO-8859-1");
            Encoding utf8 = Encoding.UTF8;

            var notcr2wfiles = new ConcurrentStack<Tuple<int, int, string>>(); // lod2 lod1 lod1-name

            var threadpooldict = new ConcurrentDictionary<int, IConsole>();
            var totalprogressbarwindow = Window.OpenBox("Total Progress", 110, 6, new BoxStyle()
            {
                ThickNess = LineThickNess.Single,
                Title = new Colors(Green, Black)
            });
            var pb = new ProgressBar((IConsole)totalprogressbarwindow, (PbStyle)PbStyle.DoubleLine, (int)bm.Bundles.Count(), (int)70);
            var pg = new Progress(0);

            var bundleprogressbarwindow = Window.OpenBox("Bundle Progress", 110, 6, new BoxStyle()
            {
                ThickNess = LineThickNess.Single,
                Title = new Colors(Green, Black)
            });
            var bundlepb = new ProgressBar((IConsole)bundleprogressbarwindow, (PbStyle)PbStyle.DoubleLine, 100, (int)70);


            //bool flagpass = true;

            /*            var bundlesarray = bundles.ToArray();
                        var part = Partitioner.Create(bundlesarray, EnumerablePartitionerOptions.NoBuffering);
            */

            //irc csharp Suchiman var array = Enumerable.Range(0, 10000).ToArray(); var part = Partitioner.Create(array, EnumerablePartitionerOptions.NoBuffering); Parallel.ForEach(part, Console.WriteLine);

            //Parallel.For(/*part,*/0, bundles.Count(), new ParallelOptions { MaxDegreeOfParallelism = 2 }, i =>
            foreach (var bundle in bundles)
            {
                //var bundle = bundles[i];
                #region bundleloop
                lock (pg)
                {
                    pb.Refresh(++pg.pgr, bundle.ArchiveAbsolutePath);
                }

/*                if (bundle == bundles[21])
                    flagpass = false;
                if (flagpass)
                    continue;
*/


                if (bundle.ArchiveAbsolutePath.Contains("buffers") ||
                        bundle.ArchiveAbsolutePath.Contains("xml"))
                    continue;//return;


                bundlepb.Max = (int)bundle.Items.Count();
                var bundlepg = new Progress(0);
                //Cannot use bundle.GetSize, it is broken on patch1 bundle
                var filerealsize = new FileInfo(bundle.ArchiveAbsolutePath).Length;

                var e = bundle.ArchiveAbsolutePath.GetHashMD5();
                var mmf = MemoryMappedFile.CreateNew(e, /*bundle.GetSize*/filerealsize, MemoryMappedFileAccess.ReadWrite);

                //We try to create a non-persisted memory-mapped file from RAM, or if we can't a persisted mmf from disk.
                // no memory stream on > 2GB files, win32 api.
                if(filerealsize<1900000000)
                {
                    using (MemoryStream ms0 = new MemoryStream(File.ReadAllBytes(bundle.ArchiveAbsolutePath), 0, (int)filerealsize, false, true))
                    using (MemoryMappedViewStream mmvs = mmf.CreateViewStream())
                    {
                        ms0.CopyTo(mmvs);
                    }
                }
                else
                {
                    using (FileStream fs = File.OpenRead(bundle.ArchiveAbsolutePath))
                    //using (MemoryStream ms0 = new MemoryStream(File.ReadAllBytes(bundle.FileName), 0, (int)filerealsize, false, true))
                    using (MemoryMappedViewStream mmvs = mmf.CreateViewStream())
                    {
                        fs.CopyTo(mmvs);
                    }
                }

                //we start by the hardest biggest ones to not throttle stupidly
                var bundleitemssortedbysize = bundle.Items.Values.ToList().OrderByDescending(o => o.Size).ToArray();
                var bundleitempart = Partitioner.Create(bundleitemssortedbysize, EnumerablePartitionerOptions.NoBuffering);
                Parallel.ForEach(bundleitempart, new ParallelOptions { MaxDegreeOfParallelism = 15 }, f =>
                {
                    //BundleItem f = bundleitemssortedbysize[i];

                    lock (bundlepg)
                        if (bundlepg.pgr++ % 10 == 9)
                            bundlepb.Refresh(bundlepg.pgr, f.Name);

                    if (f.Name.Split('.').Last() == "w2l")
                    {
                        //System.Console.WriteLine("Not bothering with buggy files");
                        return;
                    }

                    if (bundle.Patchedfiles.Contains(f))
                    {
                        System.Console.WriteLine("Not bothering with patched files yet  ");
                        return;
                    }

                    // Getting bundle database file id - lod2dict - lod2 absolute_path --> lod2_file_id
                    var lod_2_file_name = f.Bundle.ArchiveAbsolutePath.Replace("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\", "").Replace("\\", "/");
                    int lod2_file_id = lod2dict[lod_2_file_name];

                    // Getting cr2w database general file id (lod1) - lod1dict - lod2_id + absolute_virtual_path --> lod1_file_id
                    int lod1_file_id = lod1dict[Tuple.Create(lod2_file_id, f.Name)];
                    // Getting cr2w database specific file id (lod1x2, cr2w) - lod1x2dict - lod1_id + lod2_id --> cr2w_file_id
                    int cr2w_file_id = lod1x2dict[Tuple.Create(lod2_file_id, lod1_file_id)];

                    var crw = new CR2WFile();


                    using (var ms = new MemoryStream())
                    using (var br = new BinaryReader(ms))
                    {
                        f.ExtractExistingMMF(ms, mmf);
                        ms.Seek(0, SeekOrigin.Begin);

                        try
                        {
                            if (crw.Read(br) == EFileReadErrorCodes.NoCr2w)
                            {
                                notcr2wfiles.Push(Tuple.Create(lod2_file_id, lod1_file_id, f.Name)); // lod2 lod1 lod1-name
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine("weird thing at " + f.Name);
                            System.Console.WriteLine(ex.ToString());
                            throw ex;
                        }
                    }

                    // We make a list of cr2w files with the cr2w file and all its embedded cr2w files.
                    var crwwithembedded = new List<CR2WFile>(Enumerable.Concat(new[] { crw }, crw.embedded.Select(_ => _.GetParsedFile()).ToList()));

                    int newfileid;

                    var oneconn = new NpgsqlConnection(connString);
                    oneconn.Open();
                    foreach (var acrw in crwwithembedded)
                    {
                        if (acrw != crwwithembedded.First())
                        {
                            newfileid = Interlocked.Increment(ref globalfileidcounter);
                            //System.Console.WriteLine(globalfileidcounter);
                        }
                        else
                            newfileid = -1;

                        #region dump_fileheader
                        // File - Fileheader
                        using (var filewriter = oneconn.BeginBinaryImport("COPY cr2w.file (file_id,lod0_file_id,lod1_file_id,embedder_file_id,version,flags,timestamp,buildversion,filesize,internalbuffersize,crc32,numchunks,file_name) FROM STDIN (FORMAT BINARY)"))
                        {
                            var crwfileheader = acrw.GetFileHeader();

                            filewriter.StartRow();
                            if (newfileid == -1) // this is a "real" cr2w
                            {
                                filewriter.Write(cr2w_file_id, NpgsqlDbType.Integer);
                                filewriter.Write(lod2_file_id, NpgsqlDbType.Integer);
                                filewriter.Write(lod1_file_id, NpgsqlDbType.Integer);
                                filewriter.Write(-1, NpgsqlDbType.Integer);
                            }
                            else // this is an embedded cr2w
                            {
                                filewriter.Write(newfileid, NpgsqlDbType.Integer);
                                filewriter.Write(-1, NpgsqlDbType.Integer);
                                filewriter.Write(-1, NpgsqlDbType.Integer);
                                filewriter.Write(cr2w_file_id, NpgsqlDbType.Integer);
                            }
                            filewriter.Write((int)crwfileheader.version, NpgsqlDbType.Smallint);
                            filewriter.Write((int)crwfileheader.flags, NpgsqlDbType.Integer);
                            filewriter.Write((long)crwfileheader.timeStamp, NpgsqlDbType.Bigint);
                            filewriter.Write((int)crwfileheader.buildVersion, NpgsqlDbType.Integer);
                            filewriter.Write((long)crwfileheader.fileSize, NpgsqlDbType.Bigint);
                            filewriter.Write((long)crwfileheader.bufferSize, NpgsqlDbType.Bigint);
                            filewriter.Write((long)crwfileheader.crc32, NpgsqlDbType.Bigint);
                            filewriter.Write((int)crwfileheader.numChunks, NpgsqlDbType.Integer);
                            filewriter.Write(acrw.Cr2wFileName, NpgsqlDbType.Text);
                            filewriter.Complete();
                        }
                        #endregion //dump_fileheader
                        #region dump_tableheader
                        // Tableheader
                        using (var tablewriter = oneconn.BeginBinaryImport("COPY cr2w.tableheaders (file_id,tablenumber,_offset,itemcount,crc32) FROM STDIN (FORMAT BINARY)"))
                        {
                            var tableheaders = acrw.GetTableHeaders();
                            for (int j = 0; j < tableheaders.Count(); j++)
                            {
                                var tableheader = tableheaders[j];

                                tablewriter.StartRow();
                                tablewriter.Write(newfileid == -1 ? cr2w_file_id : newfileid, NpgsqlDbType.Integer);
                                tablewriter.Write(j, NpgsqlDbType.Integer);
                                tablewriter.Write((int)tableheader.offset, NpgsqlDbType.Integer);
                                tablewriter.Write((int)tableheader.itemCount, NpgsqlDbType.Integer);
                                tablewriter.Write((long)tableheader.crc32, NpgsqlDbType.Bigint);
                            }
                            tablewriter.Complete();
                        }
                        #endregion //dump_tableheader
                        #region dump_import
                        // Import
                        using (var importwriter = oneconn.BeginBinaryImport("COPY cr2w.importtable (file_id,depotpath,classname,flags) FROM STDIN (FORMAT BINARY)"))
                        {
                            var imports = acrw.imports;
                            for (int j = 0; j < imports.Count(); j++)
                            {
                                var import = imports[j];

                                importwriter.StartRow();
                                importwriter.Write(newfileid == -1 ? cr2w_file_id : newfileid, NpgsqlDbType.Integer);
                                importwriter.Write(import.DepotPathStr, NpgsqlDbType.Text);
                                importwriter.Write(import.ClassNameStr, NpgsqlDbType.Text);
                                importwriter.Write((short)import.Flags, NpgsqlDbType.Smallint);
                            }
                            importwriter.Complete();
                        }
                        #endregion //dump_import
                        #region dump_properties
                        // Properties
                        using (var propertywriter = oneconn.BeginBinaryImport("COPY cr2w.property (file_id,classname,flags,propname,propflags,hash) FROM STDIN (FORMAT BINARY)"))
                        {
                            var properties = acrw.properties;
                            for (int j = 0; j < properties.Count(); j++)
                            {
                                var property = properties[j];

                                propertywriter.StartRow();
                                propertywriter.Write(newfileid == -1 ? cr2w_file_id : newfileid, NpgsqlDbType.Integer);
                                propertywriter.Write((short)property.Property.className, NpgsqlDbType.Smallint);
                                propertywriter.Write((short)property.Property.classFlags, NpgsqlDbType.Smallint);
                                propertywriter.Write((short)property.Property.propertyName, NpgsqlDbType.Smallint);
                                propertywriter.Write((short)property.Property.propertyFlags, NpgsqlDbType.Smallint);
                                propertywriter.Write((long)property.Property.hash, NpgsqlDbType.Bigint);
                            }
                            propertywriter.Complete();
                        }
                        #endregion //dump_properties
                        #region dump_chunk
                        // Export - Chunk
                        var chunkrecursedresult = new List<(IEditableVariable, int)>();
                        var cvariddict = new Dictionary<IEditableVariable, int>();
                        using (var exportwriter = oneconn.BeginBinaryImport("COPY cr2w.export (file_id,chunkid,class_id,objectflags,parentchunkid,vparentchunkid,datasize,dataoffset,template,crc32) FROM STDIN (FORMAT BINARY)"))
                        {
                            var data0 = acrw.chunks[0].data;
                            for (int chunkcounter = 0; chunkcounter < acrw.chunks.Count; chunkcounter++)
                            {
                                var chunk = acrw.chunks[chunkcounter];
                                var data = chunk.data;
                                exportwriter.StartRow();
                                exportwriter.Write(newfileid == -1 ? cr2w_file_id : newfileid, NpgsqlDbType.Integer);
                                exportwriter.Write(chunk.ChunkIndex, NpgsqlDbType.Integer);
                                exportwriter.Write(classdict[data0.REDType], NpgsqlDbType.Integer);
                                exportwriter.Write((int)chunk.Export.objectFlags, NpgsqlDbType.Smallint);
                                exportwriter.Write((int)chunk.ParentChunkIndex, NpgsqlDbType.Integer);
                                exportwriter.Write((int)chunk.VirtualParentChunkIndex, NpgsqlDbType.Integer);
                                exportwriter.Write((int)chunk.Export.dataSize, NpgsqlDbType.Integer);
                                exportwriter.Write((int)chunk.Export.dataOffset, NpgsqlDbType.Integer);
                                exportwriter.Write((int)chunk.Export.template, NpgsqlDbType.Integer);
                                exportwriter.Write((long)chunk.Export.crc32, NpgsqlDbType.Bigint);

                                var res = RecurseSerializedCvars(data, cvariddict);
                                chunkrecursedresult.AddRange(res.Item1);
                                cvariddict = cvariddict.Concat(res.Item2)
                                    .ToLookup(x => x.Key, x => x.Value)
                                    .ToDictionary(x => x.Key, g => g.First());
                            }
                            exportwriter.Complete();
                        }
                        #endregion //dump_chunk
                        #region dump_cvar
                        // CVariable
                        using (var cvarwriter = oneconn.BeginBinaryImport("COPY cr2w.cvar (cvar_id,file_id,varchunkindex,parent_cvar_id,redname,redtype,redvalue) FROM STDIN (FORMAT BINARY)"))
                        {
                            foreach (var cvart in chunkrecursedresult)
                            {
                                var cvar = cvart.Item1;

                                cvarwriter.StartRow();
                                //var adebug = cvariddict[cvar];
                                cvarwriter.Write(cvariddict[cvar], NpgsqlDbType.Integer);
                                cvarwriter.Write(newfileid == -1 ? cr2w_file_id : newfileid, NpgsqlDbType.Integer);
                                cvarwriter.Write(cvar.VarChunkIndex, NpgsqlDbType.Integer);
                                cvarwriter.Write(cvart.Item2, NpgsqlDbType.Integer);
                                cvarwriter.Write(cvar.REDName, NpgsqlDbType.Text);
                                cvarwriter.Write(cvar.REDType, NpgsqlDbType.Text);
                                //cvarwriter.Write(cvar.REDValue, NpgsqlDbType.Text); // There are null bytes in strings...
                                cvarwriter.Write(Encoding.Convert(iso88591, utf8, ByteArrayRocks.DeleteIn(iso88591.GetBytes(cvar.REDValue), 0x00)), NpgsqlDbType.Text);
                            }
                            cvarwriter.Complete();
                        }
                        #endregion //dump_cvar
                        #region dump_buffers
                        // Properties
                        using (var internalbufferwriter = oneconn.BeginBinaryImport("COPY cr2w.buffers (file_id,flags,_index,_offset,disksize,memsize,crc32,_data) FROM STDIN (FORMAT BINARY)"))
                        {
                            var buffers = acrw.buffers;

                            if (acrw != crwwithembedded.First() && acrw.embedded.Count() > 0)
                                System.Console.WriteLine($"Double embbeded found at ${crwwithembedded.First().Cr2wFileName} !");

                            for (int j = 0; j < buffers.Count(); j++)
                            {
                                var buffer = buffers[j].Buffer;

                                internalbufferwriter.StartRow();
                                internalbufferwriter.Write(newfileid == -1 ? cr2w_file_id : newfileid, NpgsqlDbType.Integer);
                                internalbufferwriter.Write((int)buffer.flags, NpgsqlDbType.Integer);
                                internalbufferwriter.Write((int)buffer.index, NpgsqlDbType.Integer);
                                internalbufferwriter.Write((int)buffer.offset, NpgsqlDbType.Integer);
                                internalbufferwriter.Write((int)buffer.diskSize, NpgsqlDbType.Integer);
                                internalbufferwriter.Write((int)buffer.memSize, NpgsqlDbType.Integer);
                                internalbufferwriter.Write((int)buffer.crc32, NpgsqlDbType.Integer);
                                internalbufferwriter.Write(buffers[j].Data, NpgsqlDbType.Bytea);
                            }
                            internalbufferwriter.Complete();
                        }
                        #endregion //dump_buffers
                        #region dump_embedded
                        // Embedded
                        using (var embeddedwriter = oneconn.BeginBinaryImport("COPY cr2w.embedded (file_id,importindex,path,pathhash,dataoffset,datasize,handle) FROM STDIN (FORMAT BINARY)"))
                        {
                            var embedded = acrw.embedded;

                            if (acrw != crwwithembedded.First() && acrw.embedded.Count() > 0)
                                System.Console.WriteLine($"Double embbeded found at ${crwwithembedded.First().Cr2wFileName} !");

                            for (int j = 0; j < embedded.Count(); j++)
                            {
                                var oneembedded = embedded[j].Embedded;

                                embeddedwriter.StartRow();
                                embeddedwriter.Write(newfileid == -1 ? cr2w_file_id : newfileid, NpgsqlDbType.Integer);
                                embeddedwriter.Write((int)oneembedded.importIndex, NpgsqlDbType.Integer);
                                embeddedwriter.Write((int)oneembedded.path, NpgsqlDbType.Integer);
                                embeddedwriter.Write((long)oneembedded.pathHash, NpgsqlDbType.Bigint);
                                embeddedwriter.Write((int)oneembedded.dataOffset, NpgsqlDbType.Integer);
                                embeddedwriter.Write((int)oneembedded.dataSize, NpgsqlDbType.Integer);
                                embeddedwriter.Write(embedded[j].Handle, NpgsqlDbType.Text);
                            }
                            embeddedwriter.Complete();
                        }
                        #endregion //dump_embedded
                    }
                    oneconn.Close();
                });
                mmf.Dispose();
                //break; // to debug
                bundlepb.Refresh(bundlepb.Max, "");
                #endregion //bundleloop
            }//);
            System.Console.WriteLine("Dump done. :'-)");
            return 1;


            #region internalfunctions
            // Result : A tuple mess - 1 the list of each cvar with its parent (postgres id), + 2 the update to the local cvar - postgresid dictionary
            (List<(IEditableVariable, int)>, Dictionary<IEditableVariable, int>) RecurseSerializedCvars(IEditableVariable data, Dictionary<IEditableVariable, int> cvariddict)
            {
                var parentedcvars = new List<(IEditableVariable, int)>();
                //The root cvariable a.k.a. chunk.data has no parent
                parentedcvars.Add((data, -1));
                //Begin recursion in children variables
                LoopWrapper(data);
                return (parentedcvars, cvariddict);

                //Recurse through children variables in the level right under, and relaunch recursion below again
                void LoopWrapper(IEditableVariable var)
                {
                    int cvarpostgresid = Interlocked.Increment(ref globalcvarcounter);
                    cvariddict.Add(var, cvarpostgresid);
                    //Only existing aka serialized cvars
                    List<IEditableVariable> nextl = var.GetExistingVariables(true);
                    if (nextl == null)
                        return;
                    foreach (var l in nextl)
                    {
                        parentedcvars.Add((l, cvarpostgresid));
                        LoopWrapper(l);
                    }

                }


                #endregion // internalfunctions
                #endregion //dump
            }

        }
    }
    static class ByteArrayRocks
    {
        static readonly int[] Empty = new int[0];

        public static byte[] DeleteIn(this byte[] self, byte source)
        {
            var matches = Locate(self, 0x00);
            if (matches == new int[0])
                return self;
            var res = new byte[self.Length - matches.Length];
            int j = 0;
            for (int i = 0; i < self.Length; i++)
                if (!matches.Contains(i))
                    res[j++] = self[i];
            return res;
        }
        public static int[] Locate(this byte[] self, byte candidate)
        {
            if (IsEmptyLocate(self))
                return Empty;

            var list = new List<int>();

            for (int i = 0; i < self.Length; i++)
            {
                if (self[i]!=candidate)
                    continue;

                list.Add(i);
            }

            return list.Count == 0 ? Empty : list.ToArray();
        }

        static bool IsEmptyLocate(byte[] array)
        {
            return array == null
                || array.Length == 0;
        }
    }

}