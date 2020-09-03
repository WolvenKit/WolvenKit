using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBlockData : CVariable
    {

        [Ordinal(0)] [RED] public CMatrix3x3 rotationMatrix { get; set; }
        [Ordinal(1)] [RED] public SVector3D position { get; set; }
        [Ordinal(2)] [RED] public CUInt16 streamingRadius { get; set; }
        [Ordinal(3)] [RED] public CUInt16 flags { get; set; }
        [Ordinal(4)] [RED] public CUInt32 occlusionSystemID { get; set; }
        [Ordinal(5)] [RED] public CUInt16 resourceIndex { get; set; }

        public Enums.BlockDataObjectType packedObjectType;

        public CVariable packedObject;

        public SBlockData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            switch (packedObjectType)
            {
                //TODO: Read the different objects
                case Enums.BlockDataObjectType.Mesh:
                    {
                        packedObject = new SBlockDataMeshObject(cr2w, this, nameof(SBlockDataMeshObject));
                        break;
                    }
                case Enums.BlockDataObjectType.Collision:
                case Enums.BlockDataObjectType.Decal:
                case Enums.BlockDataObjectType.Dimmer:
                case Enums.BlockDataObjectType.PointLight:
                case Enums.BlockDataObjectType.SpotLight:
                case Enums.BlockDataObjectType.RigidBody:
                case Enums.BlockDataObjectType.Cloth:
                case Enums.BlockDataObjectType.Destruction:
                case Enums.BlockDataObjectType.Particles:
                case Enums.BlockDataObjectType.Invalid:
                default:
                    {
                        packedObject = new CBytes(cr2w, this, "UnknownPackedObjectBytes");
                    }
                    break;
            }

            packedObject.Read(file, size - 58);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if(packedObject != null)
                packedObject.Write(file);
        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SBlockData(cr2w, parent, name);
        }

        public override string ToString()
        {
            return "Bytes of object [" +
                            Enum.GetName(typeof(Enums.BlockDataObjectType), packedObjectType) + "]";
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            if (packedObject != null)
            {
                var copy = base.Copy(context) as SBlockData;
                switch (packedObjectType)
                {
                    //TODO: Add here the differnt copy methods
                    case Enums.BlockDataObjectType.Mesh:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataMeshObject;
                            break;
                        }
                    case Enums.BlockDataObjectType.Collision:
                    case Enums.BlockDataObjectType.Decal:
                    case Enums.BlockDataObjectType.Dimmer:
                    case Enums.BlockDataObjectType.PointLight:
                    case Enums.BlockDataObjectType.SpotLight:
                    case Enums.BlockDataObjectType.RigidBody:
                    case Enums.BlockDataObjectType.Cloth:
                    case Enums.BlockDataObjectType.Destruction:
                    case Enums.BlockDataObjectType.Particles:
                    case Enums.BlockDataObjectType.Invalid:
                    default:
                        {
                            copy.packedObject = packedObject.Copy(context) as CBytes;
                        }
                        break;
                }

                return copy;
            }
            else
                return base.Copy(context);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {

            if (packedObject != null)
            {
                var baseobj = base.GetEditableVariables();
                switch (packedObjectType)
                {
                    //TODO: Add here the differnt copy methods
                    case Enums.BlockDataObjectType.Mesh:
                        {
                            baseobj.Add((SBlockDataMeshObject)packedObject);
                            break;
                        }
                    case Enums.BlockDataObjectType.Collision:
                    case Enums.BlockDataObjectType.Decal:
                    case Enums.BlockDataObjectType.Dimmer:
                    case Enums.BlockDataObjectType.PointLight:
                    case Enums.BlockDataObjectType.SpotLight:
                    case Enums.BlockDataObjectType.RigidBody:
                    case Enums.BlockDataObjectType.Cloth:
                    case Enums.BlockDataObjectType.Destruction:
                    case Enums.BlockDataObjectType.Particles:
                    case Enums.BlockDataObjectType.Invalid:
                    default:
                        {
                            baseobj.Add((CBytes)packedObject);
                        }
                        break;
                }
                return baseobj;
            }                
            else
                return base.GetEditableVariables();
        }
    }
}