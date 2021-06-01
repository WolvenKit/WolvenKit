using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.RED3.CR2W.Reflection;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;

namespace WolvenKit.RED3.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
    public class CPtr<T> : CVariable, IREDPtr where T : CVariable
    {
        public CPtr(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties

        public int ChunkIndex { get; set; }

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
            //Hard mounts
            switch (REDName)
            {
                case "parent":
                case "transformParent":
                    cr2w.Chunks[LookUpChunkIndex()].MountChunkVirtually(GetReference(), true);
                    break;
                //   case "child" when Reference.IsVirtuallyMounted:
                //       //tried for w2ent IAttachments, not the proper way to do it, this is graph viz territory
                //       Reference.MountChunkVirtually(GetVarChunkIndex(), true);
                //       break;
            }
        }

        public ICR2WExport GetReference() => ChunkIndex == 0 ? null : cr2w.Chunks[ChunkIndex - 1];


        public string ReferenceType => REDType.Split(':').Last();

        #endregion

        #region Methods

        public string GetPtrTargetType()
        {
            return ReferenceType;
        }

        /// <summary>
        /// Reads an int from the stream and stores a reference to a chunk.
        /// A value of 0 means a null reference, all other chunk indeces are shifted by 1.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file, uint size) => SetValueInternal(file.ReadInt32());

        private void SetValueInternal(int val)
        {
            if (val < 0)
            {
                throw new NotImplementedException("wCHandle.Read");
            }

            ChunkIndex = val;
        }

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

        public object GetValue() => ChunkIndex;

        public override CVariable Copy(ICR2WCopyAction context)
        {
            var copy = (CPtr<T>)base.Copy(context);

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
