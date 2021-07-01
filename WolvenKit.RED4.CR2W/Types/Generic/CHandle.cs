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
using WolvenKit.Common.Services;

namespace WolvenKit.RED4.CR2W.Types
{
    /// <summary>
    /// Handles are Int32 that store
    /// if > 0: a reference to a chunk inside the cr2w file (aka Soft)
    /// if < 0: a reference to a string in the imports table (aka Pointer)
    /// Exposed are
    /// if ChunkHandle:
    /// if ImportHandle: A string Handle, string Filetype and ushort Flags
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [REDMeta]
    public class CHandle<T> : CVariable, IREDPtr where T : IEditableVariable
    {
        public CHandle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }


        #region Properties

        public int ChunkIndex { get; set; }

        [JsonIgnore] public string ReferenceType => REDType.Split(':').Last();

        #endregion

        #region Methods

        public void SetReference(ICR2WExport value)
        {
            SetValueInternal(value.ChunkIndex + 1);

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

        public override void Read(BinaryReader file, uint size) => SetValueInternal(file.ReadInt32());


        /// <summary>
        /// Call after the stringtable was generated!
        /// </summary>
        /// <param name="file"></param>
        public override void Write(BinaryWriter file)
        {
            var val = 0;
            if (GetReference() != null)
            {
                val = GetReference().ChunkIndex + 1;
            }
            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            this.IsSerialized = true;
            switch (val)
            {
                case string s:
                    SetValueInternal(int.Parse(s));
                    break;
                case int o:
                    SetValueInternal(o);
                    break;
                case IREDPtr cvar:
                    SetReference(cvar.GetReference());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return this;
        }
        private void SetValueInternal(int val)
        {
            if (val < 0)
            {
                throw new NotImplementedException("CHandle.Read");
            }

            ChunkIndex = val;
        }

        public object GetValue() => ChunkIndex;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var copy = (CHandle<T>)base.Copy(context);

            if (GetReference() != null)
            {
                var newref = context.TryLookupReference(GetReference(), copy);
                if (newref != null)
                {
                    copy.SetReference(newref);
                }
            }

            return copy;
        }

        public override string ToString() => GetReference() == null ? "NULL" : $"{GetReference().REDType} #{GetReference().ChunkIndex}";

        public override string REDLeanValue() => GetReference() == null ? "" : $"{GetReference().ChunkIndex}";

        #endregion
    }
}
