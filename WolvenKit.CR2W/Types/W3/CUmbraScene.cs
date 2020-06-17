using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CUmbraScene : CVector
    {
        public CUInt32 unk1 { get; set; }
        public CFloat unk2 { get; set; }

        public CBufferUInt32<SUmbraSceneData> tiles;
            
        public CUmbraScene(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CUInt32(cr2w) { Name = nameof(unk1) };
            unk2 = new CFloat(cr2w) { Name = nameof(unk2) };
            tiles = new CBufferUInt32<SUmbraSceneData>(cr2w, _ => new SUmbraSceneData(_))
            {
                Name = nameof(tiles)
            };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk1.Read(file, 4);
            unk2.Read(file, 4);
            tiles.Read(file, 0);
           
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk1.Write(file);
            unk2.Write(file);
            tiles.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CUmbraScene(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CUmbraScene) base.Copy(context);

            var.unk1 = (CUInt32)unk1.Copy(context);
            var.unk2 = (CFloat)unk2.Copy(context);
            var.tiles = (CBufferUInt32<SUmbraSceneData>)tiles.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                unk1,
                unk2,
                tiles
            };
        }
    }

    public class SUmbraSceneData : CVariable
    {
        public CFloat positionX;
        public CFloat positionY;
        public CFloat positionZ;
        public CFloat positionW;
        public CHandle umbratile;

        public SUmbraSceneData(CR2WFile cr2w) :
            base(cr2w)
        {
            positionX = new CFloat(cr2w) { Name = nameof(positionX) };
            positionY = new CFloat(cr2w) { Name = nameof(positionY) };
            positionZ = new CFloat(cr2w) { Name = nameof(positionZ) };
            positionW = new CFloat(cr2w) { Name = nameof(positionW) };
            umbratile = new CHandle(cr2w) { Name = nameof(umbratile) };
        }

        public override void Read(BinaryReader file, uint size)
        {
            positionX.Read(file, 0);
            positionY.Read(file, 0);
            positionZ.Read(file, 0);
            positionW.Read(file, 0);
            umbratile.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            positionX.Write(file);
            positionY.Write(file);
            positionZ.Write(file);
            positionW.Write(file);
            umbratile.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SUmbraSceneData(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SUmbraSceneData)base.Copy(context);

            var.positionX = (CFloat)positionX.Copy(context);
            var.positionY = (CFloat)positionY.Copy(context);
            var.positionZ = (CFloat)positionZ.Copy(context);
            var.positionW = (CFloat)positionW.Copy(context);
            var.umbratile = (CHandle)umbratile.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                positionX,
                positionY,
                positionZ,
                positionW,
                umbratile
            };
        }
    }
}