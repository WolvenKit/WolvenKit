using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    /// <summary>
    /// A pointer to a chunk within the same cr2w file.
    /// </summary>
    [REDMeta]
    public class CPtr<T> : CVariable, IPtrAccessor where T : CVariable
    {
       

        public CPtr(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        #region Properties

        public CR2WExportWrapper Reference { get; set; }
        public string ReferenceType => REDType.Split(':').Last();
        #endregion

        #region Methods
        public string GetPtrTargetType()
        {
            return ReferenceType;
            //try
            //{
            //    if (Reference == null)
            //        return "NULL";
            //    return Reference.REDType;
            //}
            //catch (Exception ex)
            //{
            //    throw new InvalidPtrException(ex.Message);
            //}
        }

        /// <summary>
        /// Reads an int from the stream and stores a reference to a chunk.
        /// A value of 0 means a null reference, all other chunk indeces are shifted by 1.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="size"></param>
        public override void Read(BinaryReader file, uint size)
        {
            SetValueInternal(file.ReadInt32());
        }

        private void SetValueInternal(int val)
        {
            try
            {
                Reference = val == 0 ? null : cr2w.Chunks[val - 1];
            }
            catch (Exception ex)
            {
                throw new InvalidPtrException(ex.Message);
            }

            // Try reparenting on virtual mountpoint
            if (Reference != null)
            {
                //Populate the reverse-lookups
                Reference.AdReferences.Add(this);
                cr2w.Chunks[LookUpChunkIndex()].AbReferences.Add(this);
                //Soft mount the chunk except root chunk
                if (Reference.ChunkIndex != 0)
                {
                    Reference.MountChunkVirtually(LookUpChunkIndex());
                }
                //Hard mounts
                switch (REDName)
                {
                    case "parent":
                    case "transformParent":
                        cr2w.Chunks[LookUpChunkIndex()].MountChunkVirtually(Reference, true);
                        break;
                 //   case "child" when Reference.IsVirtuallyMounted:
                 //       //tried for w2ent IAttachments, not the proper way to do it, this is graph viz territory
                 //       Reference.MountChunkVirtually(GetVarChunkIndex(), true);
                 //       break;
                }
            }
        }

        public override void Write(BinaryWriter file)
        {
            int val = 0;
            if (Reference != null)
                val = Reference.ChunkIndex + 1;

            file.Write(val);
        }

        public override CVariable SetValue(object val)
        {
            switch (val)
            {
                case CR2WExportWrapper wrapper:
                    Reference = wrapper;
                    break;
                case IPtrAccessor cval:
                    Reference = cval.Reference;
                    break;
            }

            return this;
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var copy = (CPtr<T>)base.Copy(context);

            if (Reference != null)
            {
                CR2WExportWrapper newref = context.TryLookupReference(Reference, copy);
                if (newref != null)
                    copy.SetValue(newref);
            }
            

            return copy;
        }

        

        public override string ToString()
        {
            if (Reference == null)
                return "NULL";
            return $"{Reference.REDType} #{Reference.ChunkIndex}";
        }

        public override string REDLeanValue()
        {
            if (Reference == null)
                return "";
            return $"{Reference.ChunkIndex}";
        }


        //public override void SerializeToXml(XmlWriter xw)
        //{
        //    DataContractSerializer ser = new DataContractSerializer(GetType());
        //    using (var ms = new MemoryStream())
        //    {
        //        ser.WriteStartObject(xw, this);
        //        ser.WriteObjectContent(xw, this);
        //        xw.WriteElementString("PtrTargetType", GetPtrTargetType());
        //        xw.WriteElementString("Target", ToString());
        //        ser.WriteEndObject(xw);
        //    }
        //}
        #endregion
    }


}
