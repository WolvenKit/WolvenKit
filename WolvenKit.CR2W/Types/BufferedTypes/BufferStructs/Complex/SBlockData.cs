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
                case Enums.BlockDataObjectType.Invalid:
                    {
                        packedObject = null;
                        //This is empty
                        break;
                    }
                case Enums.BlockDataObjectType.Mesh:
                    {
                        packedObject = new SBlockDataMeshObject(cr2w, this, nameof(SBlockDataMeshObject));
                        break;
                    }
                case Enums.BlockDataObjectType.Collision:
                    {
                        packedObject = new SBlockDataCollisionObject(cr2w, this, nameof(SBlockDataCollisionObject));
                        break;
                    }
                case Enums.BlockDataObjectType.Decal:
                case Enums.BlockDataObjectType.Dimmer:
                case Enums.BlockDataObjectType.PointLight:
                case Enums.BlockDataObjectType.SpotLight:
                case Enums.BlockDataObjectType.RigidBody:
                case Enums.BlockDataObjectType.Cloth:
                case Enums.BlockDataObjectType.Destruction:
                case Enums.BlockDataObjectType.Particles:
                default:
                    {
                        // For unit testing!
                        //if((int)packedObjectType != 1)
                        //    throw new Exception("Unknown type [" + (int)packedObjectType  + "] object!");
                        packedObject = new CBytes(cr2w, this, "UnknownPackedObjectBytes");
                        break;
                    }
            }

            packedObject.Read(file, size - 58);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if(packedObject != null)
                packedObject.Write(file);
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
                    case Enums.BlockDataObjectType.Invalid:
                        {
                            //Empty
                            break;
                        }
                    case Enums.BlockDataObjectType.Mesh:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataMeshObject;
                            break;
                        }
                    case Enums.BlockDataObjectType.Collision:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataCollisionObject;
                            break;
                        }
                    case Enums.BlockDataObjectType.Decal:
                    case Enums.BlockDataObjectType.Dimmer:
                    case Enums.BlockDataObjectType.PointLight:
                    case Enums.BlockDataObjectType.SpotLight:
                    case Enums.BlockDataObjectType.RigidBody:
                    case Enums.BlockDataObjectType.Cloth:
                    case Enums.BlockDataObjectType.Destruction:
                    case Enums.BlockDataObjectType.Particles:
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
                    case Enums.BlockDataObjectType.Invalid:
                        {
                            //Empty
                            break;
                        }
                    //TODO: Add here the differnt copy methods
                    case Enums.BlockDataObjectType.Mesh:
                        {
                            baseobj.Add((SBlockDataMeshObject)packedObject);
                            break;
                        }
                    case Enums.BlockDataObjectType.Collision:
                        {
                            baseobj.Add((SBlockDataCollisionObject)packedObject);
                            break;
                        }
                    case Enums.BlockDataObjectType.Decal:
                    case Enums.BlockDataObjectType.Dimmer:
                    case Enums.BlockDataObjectType.PointLight:
                    case Enums.BlockDataObjectType.SpotLight:
                    case Enums.BlockDataObjectType.RigidBody:
                    case Enums.BlockDataObjectType.Cloth:
                    case Enums.BlockDataObjectType.Destruction:
                    case Enums.BlockDataObjectType.Particles:
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