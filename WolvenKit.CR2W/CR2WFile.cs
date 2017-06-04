using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    public class CR2WFile
    {
        /// <summary>
        ///     File structure variables
        /// </summary>
        public static readonly byte[] IDString = {(byte) 'C', (byte) 'R', (byte) '2', (byte) 'W'};

        /// <summary>
        /// </summary>
        private uint headerOffset;

        public List<CLocalizedString> LocalizedStrings = new List<CLocalizedString>();
        public List<string> UnknownTypes = new List<string>();

        public CR2WFile()
        {
            headers = new List<CR2WHeaderData>();
            for (var i = 0; i < 10; i ++)
            {
                headers.Add(new CR2WHeaderData());
            }
            strings = new List<CR2WHeaderString> {new CR2WHeaderString()};
            handles = new List<CR2WHeaderHandle>();
            chunks = new List<CR2WChunk>();
            block4 = new List<CR2WHeaderBlock4>();
            block6 = new List<CR2WHeaderBlock6>();
            block7 = new List<CR2WHeaderBlock7>();

            FileVersion = 162;
        }

        public CR2WFile(BinaryReader file)
        {
            Read(file);
        }

        public uint FileVersion { get; set; }
        public uint unk2 { get; set; }
        public uint unk3 { get; set; }
        public uint unk4 { get; set; }
        public uint unk5 { get; set; }
        public uint cr2wsize { get; set; }
        public uint buffersize { get; set; }
        public uint unk6 { get; set; }
        public uint unk7 { get; set; }
        public List<CR2WHeaderData> headers { get; set; }
        public List<CR2WHeaderString> strings { get; set; }
        public List<CR2WHeaderHandle> handles { get; set; }
        public List<CR2WHeaderBlock4> block4 { get; set; }
        public List<CR2WChunk> chunks { get; set; }
        public List<CR2WHeaderBlock6> block6 { get; set; }
        public List<CR2WHeaderBlock7> block7 { get; set; }
        public byte[] bufferdata { get; set; }
        public string FileName { get; set; }

        /// <summary>
        ///     LocalizedStringSource
        /// </summary>
        public ILocalizedStringSource LocalizedStringSource { get; set; }

        /// <summary>
        ///     EditorController
        /// </summary>
        public IVariableEditor EditorController { get; set; }

        public string GetLocalizedString(uint val)
        {
            if (LocalizedStringSource != null)
                return LocalizedStringSource.GetLocalizedString(val);

            return null;
        }

        public void CreateVariableEditor(CVariable editvar, EVariableEditorAction action)
        {
            if (EditorController != null)
            {
                EditorController.CreateVariableEditor(editvar, action);
            }
        }

        public void Read(BinaryReader file)
        {
            var filetype = file.ReadBytes(4);

            if (!IDString.SequenceEqual(filetype))
            {
                throw new InvalidFileTypeException("Invalid file type");
            }

            FileVersion = file.ReadUInt32();
            unk2 = file.ReadUInt32();
            unk3 = file.ReadUInt32();

            unk4 = file.ReadUInt32();
            unk5 = file.ReadUInt32();

            cr2wsize = file.ReadUInt32();
            buffersize = file.ReadUInt32();

            unk6 = file.ReadUInt32();
            unk7 = file.ReadUInt32();

            headers = new List<CR2WHeaderData>();

            for (var i = 0; i < 10; i++)
            {
                var head = new CR2WHeaderData(file);
                headers.Add(head);

                if (head.size > 0 && i > 6)
                {
                    // Unhandled blocks
                    Debugger.Break();
                }
            }

            var string_buffer_start = headers[0].offset;

            // Read Strings
            {
                strings = new List<CR2WHeaderString>();

                var string_start = headers[1].offset;
                var string_count = headers[1].size;

                file.BaseStream.Seek(string_start, SeekOrigin.Begin);

                for (var i = 0; i < string_count; i++)
                {
                    var str = new CR2WHeaderString(file);
                    str.ReadString(file, string_buffer_start);
                    strings.Add(str);
                }
            }

            // Read Handles
            {
                handles = new List<CR2WHeaderHandle>();

                var handles_start = headers[2].offset;
                var handles_count = headers[2].size;

                file.BaseStream.Seek(handles_start, SeekOrigin.Begin);

                for (var i = 0; i < handles_count; i++)
                {
                    var handle = new CR2WHeaderHandle(file);
                    handle.ReadString(file, string_buffer_start);
                    handles.Add(handle);
                }
            }

            // TODO: Figure out where these things belong, possibly block 4 or 7?
            //file.BaseStream.Seek(handles[handles.Count - 1].offset + string_buffer_start, SeekOrigin.Begin);
            //file.ReadCR2WString();
            //unknownstrings = new List<string>();
            //while (file.BaseStream.Position < headers[1].offset)
            //{
            //   unknownstrings.Add(file.ReadCR2WString());
            //}

            // Read Unknown Block 4
            {
                block4 = new List<CR2WHeaderBlock4>();

                var block4_start = headers[3].offset;
                var block4_count = headers[3].size;

                file.BaseStream.Seek(block4_start, SeekOrigin.Begin);

                for (var i = 0; i < block4_count; i++)
                {
                    var block = new CR2WHeaderBlock4(file);
                    block4.Add(block);
                }
            }

            // Read Chunks
            {
                chunks = new List<CR2WChunk>();

                var chunk_start = headers[4].offset;
                var chunk_count = headers[4].size;

                file.BaseStream.Seek(chunk_start, SeekOrigin.Begin);

                for (var i = 0; i < chunk_count; i++)
                {
                    var chunktypeId = file.ReadUInt16();

                    var chunk = new CR2WChunk(this);
                    chunk.typeId = chunktypeId;
                    chunk.Read(file);
                    chunks.Add(chunk);
                }
            }

            // Read Unknown Block 6
            {
                block6 = new List<CR2WHeaderBlock6>();

                var block6_start = headers[5].offset;
                var block6_count = headers[5].size;

                file.BaseStream.Seek(block6_start, SeekOrigin.Begin);

                for (var i = 0; i < block6_count; i++)
                {
                    var block = new CR2WHeaderBlock6(file);
                    block6.Add(block);
                }
            }


            // Read Unknown Block 7
            {
                block7 = new List<CR2WHeaderBlock7>();

                var block7_start = headers[6].offset;
                var block7_count = headers[6].size;

                file.BaseStream.Seek(block7_start, SeekOrigin.Begin);

                for (var i = 0; i < block7_count; i++)
                {
                    var block = new CR2WHeaderBlock7(file);
                    block7.Add(block);
                }
            }

            // Read Chunk buffers
            {
                for (var i = 0; i < chunks.Count; i++)
                {
                    chunks[i].ReadData(file);
                }
            }

            // Read Block7 buffers
            {
                for (var i = 0; i < block7.Count; i++)
                {
                    block7[i].ReadString(file, string_buffer_start);
                    block7[i].ReadData(file);
                }
            }

            file.BaseStream.Seek(cr2wsize, SeekOrigin.Begin);

            var actualbuffersize = (int) (buffersize - cr2wsize);
            if (actualbuffersize > 0)
            {
                bufferdata = new byte[actualbuffersize];
                file.BaseStream.Read(bufferdata, 0, actualbuffersize);
            }
        }

        public CVariable ReadVariable(BinaryReader file)
        {
            var nameId = file.ReadUInt16();
            if (nameId == 0)
                return null;

            var typepos = file.BaseStream.Position;
            var typeId = file.ReadUInt16();

            var size = file.ReadUInt32() - 4;
            var typename = strings[typeId].str;
            var varname = strings[nameId].str;

            var parsedvar = CR2WTypeManager.Get().GetByName(typename, varname, this);
            parsedvar.Read(file, size);

            parsedvar.nameId = nameId;
            parsedvar.typeId = typeId;

            return parsedvar;
        }

        public void WriteVariable(BinaryWriter file, CVariable var)
        {
            file.Write(var.nameId);
            file.Write(var.typeId);

            var pos = file.BaseStream.Position;
            file.Write((uint) 0); // size placeholder


            var.Write(file);
            var endpos = file.BaseStream.Position;

            file.Seek((int) pos, SeekOrigin.Begin);
            var actualsize = (uint) (endpos - pos);
            file.Write(actualsize); // Write size
            file.Seek((int) endpos, SeekOrigin.Begin);
        }

        public void Write(BinaryWriter file)
        {
            // HACK: Create missing chunk type
            foreach (var c in chunks)
            {
                GetStringIndex(c.Type, true);
            }

            headerOffset = 0;
            var buffersMem = new MemoryStream();
            var buffersWriter = new BinaryWriter(buffersMem);
            // first write the file to memory
            WriteBuffers(buffersWriter);

            // Write headers once to allocate the space for it
            WriteHeader(file);

            headerOffset = (uint) file.BaseStream.Position;

            // Write buffers
            buffersMem.Seek(0, SeekOrigin.Begin);
            buffersMem.WriteTo(file.BaseStream);

            cr2wsize += headerOffset;
            buffersize += headerOffset;

            // Write headers again with fixed offsets
            WriteHeader(file);
        }

        private void WriteHeader(BinaryWriter file)
        {
            file.BaseStream.Seek(0, SeekOrigin.Begin);
            file.Write(IDString);

            file.Write(FileVersion);
            file.Write(unk2);
            file.Write(unk3);

            file.Write(unk4);
            file.Write(unk5);

            file.Write(cr2wsize);
            file.Write(buffersize);

            file.Write(unk6);
            file.Write(unk7);

            for (var i = 0; i < 10; i++)
            {
                headers[i].Write(file);
            }

            var stringbuffer_offset = (uint) file.BaseStream.Position;
            headers[0].offset = stringbuffer_offset;

            // Write string buffers
            var string_offsets = new Dictionary<string, uint>();
            var new_string_offsets = new Dictionary<string, uint>();

            // Add all strings to dictionary
            for (var i = 0; i < strings.Count; i++)
            {
                string_offsets.AddUnique(strings[i].str, strings[i].offset);
            }
            for (var i = 0; i < handles.Count; i++)
            {
                string_offsets.AddUnique(handles[i].str, handles[i].offset);
            }
            for (var i = 0; i < block7.Count; i++)
            {
                foreach (var str in block7[i].handles)
                {
                    string_offsets.AddUnique(str, block7[i].handle_name_offset);
                }
            }

            // Write all strings
            foreach (var str in string_offsets)
            {
                var newoffset = ((uint) file.BaseStream.Position) - stringbuffer_offset;
                new_string_offsets.Add(str.Key, newoffset);
                file.WriteCR2WString(str.Key);
            }

            headers[0].size = ((uint) file.BaseStream.Position - stringbuffer_offset);

            // Update all offsets
            for (var i = 0; i < strings.Count; i++)
            {
                var newoffset = new_string_offsets.Get(strings[i].str);
                if (strings[i].offset != newoffset)
                {
                    strings[i].offset = newoffset;
                }
            }
            for (var i = 0; i < handles.Count; i++)
            {
                var newoffset = new_string_offsets.Get(handles[i].str);
                if (newoffset != handles[i].offset)
                {
                    handles[i].offset = newoffset;
                }
            }
            for (var i = 0; i < block7.Count; i++)
            {
                for (var j = 0; j < block7[i].handles.Count; j++)
                {
                    var newoffset = new_string_offsets.Get(block7[i].handles[j]);
                    if (newoffset != block7[i].handle_name_offset)
                    {
                        block7[i].handle_name_offset = newoffset;
                    }
                }
            }


            headers[1].size = (uint) strings.Count;
            headers[1].offset = (uint) file.BaseStream.Position;
            for (var i = 0; i < strings.Count; i++)
            {
                strings[i].Write(file);
            }

            headers[2].size = (uint) handles.Count;
            headers[2].offset = (uint) file.BaseStream.Position;
            for (var i = 0; i < handles.Count; i++)
            {
                handles[i].Write(file);
            }

            headers[3].size = (uint) block4.Count;
            headers[3].offset = (uint) file.BaseStream.Position;
            for (var i = 0; i < block4.Count; i++)
            {
                block4[i].Write(file);
            }

            headers[4].size = (uint) chunks.Count;
            headers[4].offset = (uint) file.BaseStream.Position;
            for (var i = 0; i < chunks.Count; i++)
            {
                chunks[i].offset += headerOffset;
                chunks[i].Write(file);
            }

            headers[5].size = (uint) block6.Count;
            headers[5].offset = (uint) file.BaseStream.Position;
            for (var i = 0; i < block6.Count; i++)
            {
                block6[i].Write(file);
            }

            headers[6].size = (uint) block7.Count;
            headers[6].offset = (uint) file.BaseStream.Position;
            for (var i = 0; i < block7.Count; i++)
            {
                block7[i].offset += headerOffset;
                block7[i].Write(file);
            }
        }

        private void WriteBuffers(BinaryWriter file)
        {
            var chunkbuffer_offset = file.BaseStream.Position;
            // Write chunk buffers
            for (var i = 0; i < chunks.Count; i++)
            {
                chunks[i].WriteData(file);
            }

            // Write block7
            for (var i = 0; i < block7.Count; i++)
            {
                block7[i].WriteData(file);
            }

            cr2wsize = (uint) file.BaseStream.Position;

            if (bufferdata != null)
            {
                file.Write(bufferdata);
            }
            buffersize = (uint) file.BaseStream.Position;
        }

        public CR2WChunk CreateChunk(string type, CR2WChunk parent = null)
        {
            var chunk = new CR2WChunk(this);
            chunk.Type = type;
            chunk.CreateDefaultData();
            if (parent != null)
            {
                chunk.ParentChunkId = (uint) chunks.IndexOf(parent) + 1;
            }

            chunks.Add(chunk);
            return chunk;
        }

        public CR2WChunk CreateChunk(string type, CVariable data, CR2WChunk parent = null)
        {
            var chunk = new CR2WChunk(this);
            chunk.Type = type;
            chunk.data = data;
            if (parent != null)
            {
                chunk.ParentChunkId = (uint) chunks.IndexOf(parent) + 1;
            }

            chunks.Add(chunk);
            return chunk;
        }

        public int GetStringIndex(string name, bool addnew = false)
        {
            for (var i = 0; i < strings.Count; i++)
            {
                if (strings[i].str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(strings[i].str)))
                    return i;
            }

            if (addnew)
            {
                var newstring = new CR2WHeaderString();
                newstring.str = name;
                strings.Add(newstring);

                return strings.Count - 1;
            }

            return -1;
        }

        public int GetHandleIndex(string name, ushort filetype, ushort flags, bool addnew = false)
        {
            for (var i = 0; i < handles.Count; i++)
            {
                if (handles[i].filetype == filetype && handles[i].flags == flags &&
                    (handles[i].str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(handles[i].str))))
                    return i;
            }

            if (addnew)
            {
                var newstring = new CR2WHeaderHandle();
                newstring.str = name;
                newstring.filetype = filetype;
                newstring.flags = flags;
                handles.Add(newstring);

                return handles.Count - 1;
            }

            return -1;
        }

        public CR2WChunk GetChunkByType(string type)
        {
            for (var i = 0; i < chunks.Count; i++)
            {
                if (chunks[i].Type == type)
                    return chunks[i];
            }

            return null;
        }

        public CVector CreateVector(CR2WChunk in_chunk, string type, string varname = "")
        {
            var var = CreateVector(type, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CVector CreateVector(CArray in_array, string varname = "")
        {
            var var = CreateVector("", varname);
            in_array.AddVariable(var);
            return var;
        }

        public CVector CreateVector(string type, string varname = "")
        {
            var var = new CVector(this);
            var.Type = type;
            var.Name = varname;
            return var;
        }

        public CVariable CreateVariable(CVector in_vector, string type, string varname = "")
        {
            var var = CreateVariable(type, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CVariable CreateVariable(CR2WChunk in_chunk, string type, string varname = "")
        {
            var var = CreateVariable(type, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CVariable CreateVariable(string type, string varname = "")
        {
            var var = CR2WTypeManager.Get().GetByName(type, varname, this, false);
            var.Type = type;
            var.Name = varname;
            return var;
        }

        public CVariable CreateVariable(CArray in_array, string type)
        {
            var var = CreateVariable(type);
            in_array.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(CArray in_array, string type, string handle, string varname = "")
        {
            var var = CreateHandle(type, handle, varname);
            in_array.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(CVector in_vector, string type, string handle, string varname = "")
        {
            var var = CreateHandle(type, handle, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(CR2WChunk in_chunk, string type, string handle, string varname = "")
        {
            var var = CreateHandle(type, handle, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(string type, string handle, string varname = "")
        {
            var reg = new Regex(@"(\w+):(.+)");
            var match = reg.Match(type);
            var targetType = type;

            if (match.Success)
            {
                targetType = match.Groups[2].Value;
            }

            if (handle != null)
            {
                handle = handle.Replace('/', '\\');
            }
            var ptr = new CHandle(this);
            ptr.Name = varname;
            ptr.Type = type;

            ptr.Handle = handle;
            ptr.FileType = targetType;

            return ptr;
        }

        public CSoft CreateSoft(CArray in_array, string type, string handle, string varname = "")
        {
            var var = CreateSoft(type, handle, varname);
            in_array.AddVariable(var);
            return var;
        }

        public CSoft CreateSoft(CVector in_vector, string type, string handle, string varname = "")
        {
            var var = CreateSoft(type, handle, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CSoft CreateSoft(CR2WChunk in_chunk, string type, string handle, string varname = "")
        {
            var var = CreateSoft(type, handle, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CSoft CreateSoft(string type, string handle, string varname = "")
        {
            var reg = new Regex(@"(\w+):(.+)");
            var match = reg.Match(type);
            var targetType = type;

            if (match.Success)
            {
                targetType = match.Groups[2].Value;
            }

            handle = handle.Replace('/', '\\');
            var ptr = new CSoft(this);
            ptr.Name = varname;
            ptr.Type = type;

            ptr.FileType = targetType;
            ptr.Flags = 4;
            ptr.Handle = handle;
            return ptr;
        }

        public CPtr CreatePtr(CArray in_array, CR2WChunk to_chunk, string varname = "")
        {
            var var = CreatePtr("", to_chunk, varname);
            in_array.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(CVector in_vector, string type, CR2WChunk to_chunk, string varname = "")
        {
            var var = CreatePtr(type, to_chunk, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(CR2WChunk in_chunk, string type, CR2WChunk to_chunk, string varname = "")
        {
            var var = CreatePtr(type, to_chunk, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(string type, CR2WChunk tochunk, string varname = "")
        {
            var ptr = new CPtr(this);
            ptr.Name = varname;
            ptr.Type = type;

            if (tochunk != null)
            {
                ptr.val = chunks.IndexOf(tochunk) + 1;
            }
            return ptr;
        }

        public bool RemoveChunk(CR2WChunk chunk)
        {
            return chunks.Remove(chunk);
        }
    }
}