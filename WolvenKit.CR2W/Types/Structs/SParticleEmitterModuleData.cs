using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class SParticleEmitterModuleData : CVariable
    {
        public CVariable[] fields;
        public CBuffer<CFloat> alpha, lifeTime, rotation, rotationRate, spawnInnerRadius, spawnOuterRadius, p118, p124, p134,
            accelerationScale, rotationOverLife, rotationRateOverLife, alphaOverLife, textureAnimationSpeed,
            velocityTurbulizeTimelifeLimit, targetForceScale, targetKillRadius;
        public CBuffer<CVector3D> color, position, rotation3d, rotationRate3d, sizeOrientation, spawnExtents, p108, velocityOverLife,
            accelerationDirection, rotation3dOverLife, rotationRate3dOverLife, colorOverLife,
            sizeOverLifeOrientation, velocityTurbulizeScale, targetPosition;
        public CBuffer<CVector2D> size, sizeOverLife;
        public CFloat velocityTurbulizeNoiseInterval, velocityTurbulizeDuration, targetMaxForce;
        public CUInt32 p030, p140, p144, p148, p224, p238, p23C, p240, p244, p24C, alphaByDistanceFar, alphaByDistanceNear;
        public CInt32 p228, collisionTriggeringGroupIndex;
        public CUInt8 sizeKeepRatio, spawnWorldSpace, spawnSurfaceOnly, p100, p101, p102, p103, p104, p105, p106, p114, p130, p248, p249, p250;
        public CVector3D p0A8;
        public CUInt64 p230;
        public CMatrix4x4 spawnToLocalMatrix;

        public SParticleEmitterModuleData(CR2WFile cr2w) : base(cr2w)
        {
            fields = new CVariable[] {
                alpha = CBuffers.CreateFloatBuffer(cr2w, "alpha"),
                color = CBuffers.CreateVector3DBuffer(cr2w, "color"),
                lifeTime = CBuffers.CreateFloatBuffer(cr2w, "lifeTime"),
                position = CBuffers.CreateVector3DBuffer(cr2w, "position"),
                p030 = new CUInt32(cr2w) { Name = "p030", Type = "CUInt32" },
                rotation = CBuffers.CreateFloatBuffer(cr2w, "rotation"),
                rotation3d = CBuffers.CreateVector3DBuffer(cr2w, "rotation3d"),
                rotationRate = CBuffers.CreateFloatBuffer(cr2w, "rotationRate"),
                rotationRate3d = CBuffers.CreateVector3DBuffer(cr2w, "rotationRate3d"),
                size = CBuffers.CreateVector2DBuffer(cr2w, "size"),
                sizeOrientation = CBuffers.CreateVector3DBuffer(cr2w, "sizeOrientation"),
                sizeKeepRatio = new CUInt8(cr2w) { Name = "p07C", Type = "sizeKeepRatio" },
                spawnExtents = CBuffers.CreateVector3DBuffer(cr2w, "spawnExtents"),
                spawnInnerRadius = CBuffers.CreateFloatBuffer(cr2w, "spawnInnerRadius"),
                spawnOuterRadius = CBuffers.CreateFloatBuffer(cr2w, "spawnOuterRadius"),
                spawnWorldSpace = new CUInt8(cr2w) { Name = "spawnWorldSpace", Type = "CUInt8" },
                spawnSurfaceOnly = new CUInt8(cr2w) { Name = "spawnSurfaceOnly", Type = "CUInt8" },
                p0A8 = new CVector3D(cr2w) { Name = "p0A8", Type = "CVector3D" },
                spawnToLocalMatrix = new CMatrix4x4(cr2w) { Name = "spawnToLocalMatrix", Type = "CMatrix4x4" },
                p108 = CBuffers.CreateVector3DBuffer(cr2w, "p108"),
                p114 = new CUInt8(cr2w) { Name = "p114", Type = "CUInt8" },
                p118 = CBuffers.CreateFloatBuffer(cr2w, "p118"),
                p124 = CBuffers.CreateFloatBuffer(cr2w, "p124"),
                p130 = new CUInt8(cr2w) { Name = "p130", Type = "CUInt8" },
                p134 = CBuffers.CreateFloatBuffer(cr2w, "p134"),
                p140 = new CUInt32(cr2w) { Name = "p140", Type = "CUInt32" },
                p144 = new CUInt32(cr2w) { Name = "p144", Type = "CUInt32" },
                p148 = new CUInt32(cr2w) { Name = "p148", Type = "CUInt32" },
                velocityOverLife = CBuffers.CreateVector3DBuffer(cr2w, "velocityOverLife"),
                accelerationDirection = CBuffers.CreateVector3DBuffer(cr2w, "accelerationDirection"),
                accelerationScale = CBuffers.CreateFloatBuffer(cr2w, "accelerationScale"),
                rotationOverLife = CBuffers.CreateFloatBuffer(cr2w, "rotationOverLife"),
                rotationRateOverLife = CBuffers.CreateFloatBuffer(cr2w, "rotationRateOverLife"),
                rotation3dOverLife = CBuffers.CreateVector3DBuffer(cr2w, "rotation3dOverLife"),
                rotationRate3dOverLife = CBuffers.CreateVector3DBuffer(cr2w, "rorationRate3dOverLife"),
                colorOverLife = CBuffers.CreateVector3DBuffer(cr2w, "colorOverLife"),
                alphaOverLife = CBuffers.CreateFloatBuffer(cr2w, "alphaOverLife"),
                sizeOverLife = CBuffers.CreateVector2DBuffer(cr2w, "sizeOverLife"),
                sizeOverLifeOrientation = CBuffers.CreateVector3DBuffer(cr2w, "sizeOverLifeOrientation"),
                textureAnimationSpeed = CBuffers.CreateFloatBuffer(cr2w, "textureAnimationSpeed"),
                velocityTurbulizeScale = CBuffers.CreateVector3DBuffer(cr2w, "velocityTurbulizeScale"),
                velocityTurbulizeTimelifeLimit = CBuffers.CreateFloatBuffer(cr2w, "velocityTurbulizeTimelifeLimit"),
                velocityTurbulizeNoiseInterval = new CFloat(cr2w) { Name = "velocityTurbulizeNoiseInterval", Type = "CFloat" },
                velocityTurbulizeDuration = new CFloat(cr2w) { Name = "velocityTurbulizeDuration", Type = "CFloat" },
                targetForceScale = CBuffers.CreateFloatBuffer(cr2w, "targetForceScale"),
                targetKillRadius = CBuffers.CreateFloatBuffer(cr2w, "targetKillRadius"),
                targetMaxForce = new CFloat(cr2w) { Name = "targetMaxForce", Type = "CFloat" },
                targetPosition = CBuffers.CreateVector3DBuffer(cr2w, "targetPosition"),
                p100 = new CUInt8(cr2w) { Name = "p100", Type = "CUInt8" },
                p101 = new CUInt8(cr2w) { Name = "p101", Type = "CUInt8" },
                p102 = new CUInt8(cr2w) { Name = "p102", Type = "CUInt8" },
                p103 = new CUInt8(cr2w) { Name = "p103", Type = "CUInt8" },
                p104 = new CUInt8(cr2w) { Name = "p104", Type = "CUInt8" },
                p105 = new CUInt8(cr2w) { Name = "p105", Type = "CUInt8" },
                p106 = new CUInt8(cr2w) { Name = "p106", Type = "CUInt8" },
                p230 = new CUInt64(cr2w) { Name = "p230", Type = "CUInt64" },
                p238 = new CUInt32(cr2w) { Name = "p238", Type = "CUInt32" },
                p23C = new CUInt32(cr2w) { Name = "p23C", Type = "CUInt32" },
                p240 = new CUInt32(cr2w) { Name = "p240", Type = "CUInt32" },
                p244 = new CUInt32(cr2w) { Name = "p244", Type = "CUInt32" },
                p248 = new CUInt8(cr2w) { Name = "p248", Type = "CUInt8" },
                p249 = new CUInt8(cr2w) { Name = "p249", Type = "CUInt8" },
                p24C = new CUInt32(cr2w) { Name = "p24C", Type = "CUInt32" },
                p250 = new CUInt8(cr2w) { Name = "p250", Type = "CUInt8" },
                collisionTriggeringGroupIndex = new CInt32(cr2w) { Name = "collisionTriggeringGroupIndex", Type = "CInt32" },
                p224 = new CUInt32(cr2w) { Name = "p224", Type = "CUInt32" },
                p228 = new CInt32(cr2w) { Name = "p228", Type = "CInt32" },
                alphaByDistanceFar = new CUInt32(cr2w) { Name = "alphaByDistanceFar", Type = "CUInt32" },
                alphaByDistanceNear = new CUInt32(cr2w) { Name = "alphaByDistanceNear", Type = "CUInt32" }
            };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SParticleEmitterModuleData(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(fields);
        }

        public override void Read(BinaryReader file, uint size)
        {
            foreach (var variable in fields)
            {
                variable.Read(file, size);
            }
        }

        public override void Write(BinaryWriter file)
        {
            foreach (var variable in fields)
            {
                variable.Write(file);
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            return W3ReaderExtensions.CopyViaBuffer(this, base.Copy(context));
        }
    }
}