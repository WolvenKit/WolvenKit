using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CClipMap : CVector
    {
        public CBufferUInt32<CHandle> tiles;
            
        public CClipMap(CR2WFile cr2w) :
            base(cr2w)
        {
            tiles = new CBufferUInt32<CHandle>(cr2w, _ => new CHandle(_))
            {
                Name = "tiles"
            };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            tiles.Read(file, 0);
           
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            tiles.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CClipMap(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CClipMap) base.Copy(context);

            var.tiles = (CBufferUInt32<CHandle>)tiles.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                tiles
            };
        }
    }
}