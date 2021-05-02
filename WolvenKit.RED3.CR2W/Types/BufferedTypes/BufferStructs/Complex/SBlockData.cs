using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.RED3.CR2W.Types
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

        public SBlockData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            var startp = file.BaseStream.Position;

            base.Read(file, size);

            switch (packedObjectType)
            {
                //TODO: Read the different objects
                case Enums.BlockDataObjectType.Collision:
                    //{
                    //    packedObject = new SBlockDataCollisionObject(cr2w, this, nameof(SBlockDataCollisionObject));
                    //    break;
                    //}

                case Enums.BlockDataObjectType.Particles:
                    //{
                    //    packedObject = new SBlockDataParticles(cr2w, this, nameof(SBlockDataLight));
                    //    break;
                    //}
                case Enums.BlockDataObjectType.RigidBody:
                    //{
                    //    packedObject = new SBlockDataRigidBody(cr2w, this, nameof(SBlockDataRigidBody));
                    //    break;
                    //}
                case Enums.BlockDataObjectType.Mesh:
                    {
                        // MFP - we need this for the scene viewer
                        packedObject = new SBlockDataMeshObject(cr2w, this, nameof(SBlockDataMeshObject));
                        break;
                    }
                case Enums.BlockDataObjectType.Dimmer:
                //{
                //    packedObject = new SBlockDataDimmer(cr2w, this, nameof(SBlockDataDimmer));
                //    break;
                //}

                case Enums.BlockDataObjectType.PointLight:
                //{
                //    packedObject = new SBlockDataLight(cr2w, this, nameof(SBlockDataLight));
                //    break;
                //}
                case Enums.BlockDataObjectType.SpotLight:
                    //{
                    //    packedObject = new SBlockDataSpotLight(cr2w, this, nameof(SBlockDataSpotLight));
                    //    break;
                    //}
                case Enums.BlockDataObjectType.Decal:
                    //{
                    //    packedObject = new SBlockDataDecal(cr2w, this, nameof(SBlockDataDecal));
                    //    break;
                    //}
                case Enums.BlockDataObjectType.Cloth: //TODO: Implement CClothComponent here
                case Enums.BlockDataObjectType.Destruction: //TODO: Implement CDestructionComponent here
                case Enums.BlockDataObjectType.Invalid: //TODO: Check why this breaks sometimes?
                default:
                    {
                        // For unit testing!
                        //if((int)packedObjectType != 1)
                        //    throw new Exception("Unknown type [" + (int)packedObjectType  + "] object!");
                        packedObject = new CBytes(cr2w, this, "UnknownPackedObjectBytes");
                        break;
                    }
            }

            packedObject.Read(file, size - 56);

            var endp = file.BaseStream.Position;
            var read = endp - startp;
            if (read < size)
            {
            }
            else if (read > size)
            {
                throw new InvalidParsingException("Read too far.");
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if(packedObject != null)
                packedObject.Write(file);
        }

        public override string ToString()
        {
            return "Packed [" +
                            Enum.GetName(typeof(Enums.BlockDataObjectType), packedObjectType) + "] object";
        }

        public override IEditableVariable Copy(ICR2WCopyAction context)
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
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataDecal;
                            break;
                        }
                    case Enums.BlockDataObjectType.Dimmer:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataDimmer;
                            break;
                        }
                    case Enums.BlockDataObjectType.SpotLight:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataSpotLight;
                            break;
                        }
                    case Enums.BlockDataObjectType.PointLight:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataLight;
                            break;
                        }
                    case Enums.BlockDataObjectType.Particles:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataParticles;
                            break;
                        }
                    case Enums.BlockDataObjectType.RigidBody:
                        {
                            copy.packedObject = packedObject.Copy(context) as SBlockDataRigidBody;
                            break;
                        }
                    case Enums.BlockDataObjectType.Cloth:
                    case Enums.BlockDataObjectType.Destruction:
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
                    //case Enums.BlockDataObjectType.Invalid:
                    //    {
                    //        //Empty
                    //        break;
                    //    }
                    //TODO: Add here the differnt copy methods

                    case Enums.BlockDataObjectType.Collision:
                        //{
                        //    baseobj.Add((SBlockDataCollisionObject)packedObject);
                        //    break;
                        //}
                    case Enums.BlockDataObjectType.Particles:
                        //{
                        //    baseobj.Add((SBlockDataParticles)packedObject);
                        //    break;
                        //}
                    case Enums.BlockDataObjectType.RigidBody:
                        //{
                        //    baseobj.Add((SBlockDataRigidBody)packedObject);
                        //    break;
                        //}
                    case Enums.BlockDataObjectType.Mesh:
                        //{
                        //    baseobj.Add((SBlockDataMeshObject)packedObject);
                        //    break;
                        //}
                    case Enums.BlockDataObjectType.Dimmer:
                    //{
                    //    baseobj.Add((SBlockDataDimmer)packedObject);
                    //    break;
                    //}
                    case Enums.BlockDataObjectType.PointLight:
                    //{
                    //    baseobj.Add((SBlockDataLight)packedObject);
                    //    break;
                    //}
                    case Enums.BlockDataObjectType.SpotLight:
                        //{
                        //    baseobj.Add((SBlockDataSpotLight)packedObject);
                        //    break;
                        //}
                    case Enums.BlockDataObjectType.Decal:
                        //{
                        //    baseobj.Add((SBlockDataDecal)packedObject);
                        //    break;
                        //}
                    case Enums.BlockDataObjectType.Cloth:
                    case Enums.BlockDataObjectType.Destruction:
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
