using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CSwarmCellMap : CVector
    {
        public CBytes data;
        public CVector3D cornerPosition; 
        public CInt32 dataSizeX;
        public CInt32 dataSizeY;
        public CInt32 dataSizeZ;   
        public CInt32 dataSize;   
        public CFloat sizeInKbytes;


        public CSwarmCellMap(CR2WFile cr2w) : base(cr2w)
        {
            data = new CBytes(cr2w)
            {
                Name = "Data"
            };
            cornerPosition = new CVector3D(cr2w)
            {
                Name = "Corner position"
            };
            dataSizeX = new CInt32(cr2w)
            {
                Name = "Data size X"
            };
            dataSizeY = new CInt32(cr2w)
            {
                Name = "Data size Y"
            };
            dataSizeZ = new CInt32(cr2w)
            {
                Name = "Data size Z"
            };
            dataSize = new CInt32(cr2w)
            {
                Name = "Data size in bits"
            };
            sizeInKbytes = new CFloat(cr2w)
            {
                Name = "Data size in Kilobytes"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            //TODO: Investigate what the first 10 bytes are
            base.Read(file,size);
            data.Bytes = file.ReadBytes((int) ((file.BaseStream.Length - 32) - file.BaseStream.Position));
            cornerPosition.Read(file,size);
            dataSizeX.Read(file,size);
            dataSizeY.Read(file,size);
            dataSizeZ.Read(file,size);
            dataSize.Read(file,size);
            sizeInKbytes.Read(file,size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            data.Write(file);
            cornerPosition.Write(file);
            dataSizeX.Write(file);
            dataSizeY.Write(file);
            dataSizeZ.Write(file);
            dataSize.Write(file);
            sizeInKbytes.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSwarmCellMap(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CSwarmCellMap)base.Copy(context);
            var.data = (CBytes)data.Copy(context);
            var.cornerPosition = (CVector3D) cornerPosition.Copy(context);
            var.dataSizeX = (CInt32) dataSizeX.Copy(context);
            var.dataSizeY = (CInt32)dataSizeY.Copy(context);
            var.dataSizeZ = (CInt32)dataSizeZ.Copy(context);
            var.dataSize = (CInt32) dataSize.Copy(context);
            var.sizeInKbytes = (CFloat)sizeInKbytes.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                data,
                cornerPosition,
                dataSizeX,
                dataSizeY,
                dataSizeZ, 
                dataSize,
                sizeInKbytes
            };
            return list;
        }
    }
}
