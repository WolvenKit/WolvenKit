using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class ShBlendMultipleNodeData : CVariable
    {
        public CUInt32 index;
        public CFloat blendvalue;


        public ShBlendMultipleNodeData(CR2WFile cr2w) :
            base(cr2w)
        {
            index = new CUInt32(cr2w) { Name = "index" };
            blendvalue = new CFloat(cr2w) { Name = "blendvalue" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            index.Read(file, 4);
            blendvalue.Read(file, 4);

        }

        public override void Write(BinaryWriter file)
        {
            index.Write(file);
            blendvalue.Write(file);

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new ShBlendMultipleNodeData(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (ShBlendMultipleNodeData)base.Copy(context);

            var.index = (CUInt32)index.Copy(context);
            var.blendvalue = (CFloat)blendvalue.Copy(context);


            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                index,
                blendvalue
            };
        }
    }




    [DataContract(Namespace = "")]
    public class CBehaviorGraphBlendMultipleNode : CVector
    {
        public CBufferVLQ<ShBlendMultipleNodeData> bufferinputvalues;
        
            
        public CBehaviorGraphBlendMultipleNode(CR2WFile cr2w) :
            base(cr2w)
        {
            bufferinputvalues = new CBufferVLQ<ShBlendMultipleNodeData>(cr2w, _ => new ShBlendMultipleNodeData(_) ) { Name = "bufferinputvalues" };

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            bufferinputvalues.Read(file, 0);
            
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            bufferinputvalues.Write(file);
            
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CBehaviorGraphBlendMultipleNode(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CBehaviorGraphBlendMultipleNode) base.Copy(context);

            var.bufferinputvalues = (CBufferVLQ<ShBlendMultipleNodeData>)bufferinputvalues.Copy(context);
            

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                bufferinputvalues
            };
        }
    }
}