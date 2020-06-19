using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SParticleEmitterModuleData : CVariable
    {
        private CVariable[] fields { get; set; }

        public CBufferVLQ<CFloat> alpha, lifeTime, rotation, rotationRate, spawnInnerRadius, spawnOuterRadius, velocity_inherit_scale, velocity_spread_scale, texture_animation_initial_frame,
            accelerationScale, rotationOverLife, rotationRateOverLife, alphaOverLife, textureAnimationSpeed,
            velocityTurbulizeTimelifeLimit, targetForceScale, targetKillRadius, unk;
        public CBufferVLQ<SVector3D> color, position, rotation3d, rotationRate3d, size_3d, spawnExtents, velocity, velocityOverLife,
            accelerationDirection, rotation3dOverLife, rotationRate3dOverLife, colorOverLife, velocityTurbulizeScale,
           targetPosition, sizeOverLifeOrientation;
        public CBufferVLQ<SVector2D> size, sizeOverLife;
        public CFloat velocityTurbulizeNoiseInterval, velocityTurbulizeDuration, targetMaxForce, collision_radius, collision_dynamic_friction, collision_static_friction, collision_restitution, collision_velocity_dampening, collision_spawn_probability;
        public CFloat alphaByDistanceFar, alphaByDistanceNear, position_offset;
        public CUInt32 p140, p144, p148, p238, p23C, p240, p244, p24C, collision_spawn_parent_emitter_index;
        public CUInt32 collision_self_emitter_index;
        public SVector3D p0A8;
        public CUInt64 p230, collisionTriggeringGroupIndex;
        public CMatrix4x4 spawnToLocalMatrix;
        public CBool collision_use_gpu, collision_kill_when_collide, collision_disable_gravity, sizeKeepRatio, spawnWorldSpace, spawnSurfaceOnly, velocity_world_space, velocity_spread_conserve_momentum;
        public CBool spawn_positive_x, spawn_negative_x, spawn_positive_y, spawn_negative_y, spawn_positive_z, spawn_negative_z, spawn_velocity, modulate;

        public SParticleEmitterModuleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            fields = new CVariable[] {
                // CParticleInitializerAlpha
                alpha = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleInitializerColor
                color = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleInitializerLifeTime
                lifeTime = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleInitializerPosition
                position = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                position_offset = new CFloat(cr2w, this, nameof(alpha)),
                //CParticleInitializerRotation
                rotation = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleInitializerRotation3D
                rotation3d = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleInitializerRotationRate
                rotationRate = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleInitializerRotationRate3D
                rotationRate3d = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleInitializerSize
                size = new CBufferVLQ<SVector2D>(cr2w, this, nameof(alpha)),
                //CParticleInitializerSize3d
                size_3d = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                sizeKeepRatio = new CBool(cr2w, this, nameof(alpha)),
                //CParticleInitializerSpawnBox
                spawnExtents = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleInitializerSpawnCircle
                spawnInnerRadius = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                spawnOuterRadius = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                spawnWorldSpace = new CBool(cr2w, this, nameof(alpha)),
                spawnSurfaceOnly = new CBool(cr2w, this, nameof(alpha)),
                p0A8 = new SVector3D(cr2w, this, nameof(alpha)),
                spawnToLocalMatrix = new CMatrix4x4(cr2w, this, nameof(alpha)),

                //CParticleInitializerVelocity
                velocity = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                velocity_world_space = new CBool(cr2w, this, nameof(alpha)),
                //CParticleInitializerVelocityInherit
                velocity_inherit_scale = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleInitializerVelocitySpread
                velocity_spread_scale = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                velocity_spread_conserve_momentum = new CBool(cr2w, this, nameof(alpha)),
                //CParticleModificatorTextureAnimation
                texture_animation_initial_frame = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                p140 = new CUInt32(cr2w, this, nameof(alpha)),
                p144 = new CUInt32(cr2w, this, nameof(alpha)),
                p148 = new CUInt32(cr2w, this, nameof(alpha)),

                //CParticleModificatorVelocityOverLife
                velocityOverLife = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleModificatorAcceleration
                accelerationDirection = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                accelerationScale = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleModificatorRotationOverLife
                rotationOverLife = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleModificatorRotationRateOverLife
                rotationRateOverLife = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleModificatorRotation3DOverLife
                rotation3dOverLife = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleModificatorRotationRate3DOverLife
                rotationRate3dOverLife = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleModificatorColorOverLife
                colorOverLife = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleModificatorAlphaOverLife
                alphaOverLife = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleModificatorSizeOverLife
                sizeOverLife = new CBufferVLQ<SVector2D>(cr2w, this, nameof(alpha)),
                //?
                sizeOverLifeOrientation = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                //CParticleModificatorTextureAnimation (initial frame is... missing? animation mode is defined by flags)
                textureAnimationSpeed = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),

                //CParticleModificatorVelocityTurbulize
                velocityTurbulizeScale = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),
                velocityTurbulizeTimelifeLimit = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                velocityTurbulizeNoiseInterval = new CFloat(cr2w, this, nameof(alpha)),
                velocityTurbulizeDuration = new CFloat(cr2w, this, nameof(alpha)),

                //CParticleModificatorTarget
                targetForceScale = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                targetKillRadius = new CBufferVLQ<CFloat>(cr2w, this, nameof(alpha)),
                targetMaxForce = new CFloat(cr2w, this, nameof(alpha)),
                targetPosition = new CBufferVLQ<SVector3D>(cr2w, this, nameof(alpha)),

                //CParticleInitializerSpawnSphere
                spawn_positive_x = new CBool(cr2w, this, nameof(alpha)),
                spawn_negative_x = new CBool(cr2w, this, nameof(alpha)),
                spawn_positive_y = new CBool(cr2w, this, nameof(alpha)),
                spawn_negative_y = new CBool(cr2w, this, nameof(alpha)),
                spawn_positive_z = new CBool(cr2w, this, nameof(alpha)),
                spawn_negative_z = new CBool(cr2w, this, nameof(alpha)),
                spawn_velocity = new CBool(cr2w, this, nameof(alpha)),



                collisionTriggeringGroupIndex = new CUInt64(cr2w, this, nameof(alpha)),
                collision_dynamic_friction = new CFloat(cr2w, this, nameof(alpha)),
                collision_static_friction = new CFloat(cr2w, this, nameof(alpha)),
                collision_restitution = new CFloat(cr2w, this, nameof(alpha)),
                collision_velocity_dampening = new CFloat(cr2w, this, nameof(alpha)),
                collision_disable_gravity = new CBool(cr2w, this, nameof(alpha)),
                collision_use_gpu = new CBool(cr2w, this, nameof(alpha)),
                collision_radius = new CFloat(cr2w, this, nameof(alpha)),
                collision_kill_when_collide = new CBool(cr2w, this, nameof(alpha)),
                collision_self_emitter_index = new CUInt32(cr2w, this, nameof(alpha)),
                

               

                

                //CParticleModificatorCollision
                collision_spawn_probability = new CFloat(cr2w, this, nameof(alpha)),
                collision_spawn_parent_emitter_index = new CUInt32(cr2w, this, nameof(alpha)),

                
                //CParticleModificatorAlphaByDistance
                alphaByDistanceFar = new CFloat(cr2w, this, nameof(alpha)),
                alphaByDistanceNear = new CFloat(cr2w, this, nameof(alpha))
            };
        }

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SParticleEmitterModuleData(cr2w, parent, name);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(fields);
        }

        public override void Read(BinaryReader file, uint size)
        {
            for (int i = 0; i < fields.Length; i++)
            {

                CVariable variable = fields[i];
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

        public override CVariable SetValue(object val)
        {
            if (val is SParticleEmitterModuleData)
            {
                fields = (val as SParticleEmitterModuleData).fields;
            }
            return this;
        }

        public override bool CanAddVariable(IEditableVariable newvar) => newvar == null || (newvar is SParticleEmitterModuleData);


    }
}