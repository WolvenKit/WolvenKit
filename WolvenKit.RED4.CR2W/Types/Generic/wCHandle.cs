using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using WolvenKit.RED4.CR2W.Reflection;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.RED4.CR2W.Types
{
    /// <summary>
    /// Handles are Int32 that store
    /// if gt 0: a reference to a chunk inside the cr2w file (aka Soft)
    /// if lt 0: a reference to a string in the imports table (aka Pointer)
    /// Exposed are
    /// if ChunkHandle:
    /// if ImportHandle: A string Handle, string Filetype and ushort Flags
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [REDMeta()]
    public class wCHandle<T> : CVariable, IREDHandle where T : IEditableVariable
    {
        public wCHandle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties

        //public int ChunkIndex => GetReference()?.ChunkIndex ?? -1;
        public int ChunkIndex { get; set; }

        [JsonIgnore] public bool ChunkHandle { get; set; }

        [JsonIgnore] public string DepotPath { get; set; }

        [JsonIgnore] public string ClassName { get; set; }

        [JsonIgnore] public ushort Flags { get; set; }

        [JsonIgnore] public string ReferenceType => REDType.Split(':').Last();

        #endregion

        #region Methods

        public void SetReference(ICR2WExport value)
        {
            SetValueInternal(value.ChunkIndex);

            //Populate the reverse-lookups
            GetReference().AdReferences.Add(this);
            cr2w.Chunks[LookUpChunkIndex()].AbReferences.Add(this);
            //Soft mount the chunk except root chunk
            if (GetReference().ChunkIndex != 0)
            {
                GetReference().MountChunkVirtually(LookUpChunkIndex());
            }
        }

        public ICR2WExport GetReference() => ChunkIndex == 0 ? null : cr2w.Chunks[ChunkIndex - 1];

        public IEnumerable<ICR2WExport> GetReferenceChunks()
        {
            var refType = AssemblyDictionary.GetTypeByName(ReferenceType);
            var types = AssemblyDictionary.GetSubClassesOf(refType)
                .Select(_ => _.Name).ToList();

            return Cr2wFile.Chunks.Where(cr2WExport => types.Contains(cr2WExport.REDType)).ToList();
        }

        public void ChangeHandleType()
        {
            ChunkHandle = !ChunkHandle;
            // change to external path
            if (ChunkHandle)
            {

            }
            // change to chunk handle
            else
            {

            }
        }

        public override void Read(BinaryReader file, uint size) => SetValueInternal(file.ReadInt32());


        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            var val = 0;
            if (ChunkHandle)
            {
                if (GetReference() != null)
                {
                    val = GetReference().ChunkIndex + 1;
                }
            }
            else
            {
                var import = cr2w.Imports.FirstOrDefault(_ => _.DepotPathStr == DepotPath && _.ClassNameStr == ClassName);
                val = -cr2w.Imports.IndexOf(import) - 1;
            }
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case int o:
                    SetValueInternal(o);
                    break;
                case IREDHandle cvar:
                    this.ChunkHandle = cvar.ChunkHandle;
                    this.DepotPath = cvar.DepotPath;
                    this.ClassName = cvar.ClassName;
                    this.Flags = cvar.Flags;

                    this.SetReference(cvar.GetReference());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return this;
        }
        private void SetValueInternal(int val)
        {
            if (val >= 0)
            {
                ChunkHandle = true;
            }

            if (ChunkHandle)
            {
                SetReference(val == 0 ? null : cr2w.Chunks[val - 1]);
            }
            else
            {
                DepotPath = cr2w.Imports[-val - 1].DepotPathStr;

                var filetype = cr2w.Imports[-val - 1].ClassName;
                ClassName = cr2w.Names[filetype].Str;

                Flags = cr2w.Imports[-val - 1].Flags;

                //TODO are non-chunk handles used in cp77?
                throw new NotImplementedException("wCHandle.Read");
            }
        }

        public object GetValue() => ChunkIndex;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var copy = (wCHandle<T>)base.Copy(context);
            copy.ChunkHandle = ChunkHandle;

            // Soft
            copy.DepotPath = DepotPath;
            copy.ClassName = ClassName;
            copy.Flags = Flags;

            // Ptr
            if (ChunkHandle && GetReference() != null)
            {
                ICR2WExport newref = context.TryLookupReference(GetReference(), copy);
                if (newref != null)
                    copy.SetReference(newref);
            }

            return copy;
        }

        public override string ToString()
        {
            if (ChunkHandle)
            {
                if (GetReference() == null)
                    return "NULL";
                else
                    return $"{GetReference().REDType} #{GetReference().ChunkIndex}";
            }

            return ClassName + ": " + DepotPath;
        }

        public override string REDLeanValue()
        {
            if (GetReference() == null)
                return "";
            return $"{GetReference().ChunkIndex}";
        }

        #endregion
    }
}
