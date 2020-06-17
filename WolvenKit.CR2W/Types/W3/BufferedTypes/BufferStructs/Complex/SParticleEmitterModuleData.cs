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

        public SParticleEmitterModuleData(CR2WFile cr2w) : base(cr2w)
        {
            fields = new CVariable[] {
                // CParticleInitializerAlpha
                alpha = new CBufferVLQ<CFloat>(cr2w),
                //CParticleInitializerColor
                color = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleInitializerLifeTime
                lifeTime = new CBufferVLQ<CFloat>(cr2w),
                //CParticleInitializerPosition
                position = new CBufferVLQ<SVector3D>(cr2w),
                position_offset = new CFloat(cr2w),
                //CParticleInitializerRotation
                rotation = new CBufferVLQ<CFloat>(cr2w),
                //CParticleInitializerRotation3D
                rotation3d = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleInitializerRotationRate
                rotationRate = new CBufferVLQ<CFloat>(cr2w),
                //CParticleInitializerRotationRate3D
                rotationRate3d = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleInitializerSize
                size = new CBufferVLQ<SVector2D>(cr2w),
                //CParticleInitializerSize3d
                size_3d = new CBufferVLQ<SVector3D>(cr2w),
                sizeKeepRatio = new CBool(cr2w),
                //CParticleInitializerSpawnBox
                spawnExtents = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleInitializerSpawnCircle
                spawnInnerRadius = new CBufferVLQ<CFloat>(cr2w),
                spawnOuterRadius = new CBufferVLQ<CFloat>(cr2w),
                spawnWorldSpace = new CBool(cr2w),
                spawnSurfaceOnly = new CBool(cr2w),
                p0A8 = new SVector3D(cr2w),
                spawnToLocalMatrix = new CMatrix4x4(cr2w),

                //CParticleInitializerVelocity
                velocity = new CBufferVLQ<SVector3D>(cr2w),
                velocity_world_space = new CBool(cr2w),
                //CParticleInitializerVelocityInherit
                velocity_inherit_scale = new CBufferVLQ<CFloat>(cr2w),
                //CParticleInitializerVelocitySpread
                velocity_spread_scale = new CBufferVLQ<CFloat>(cr2w),
                velocity_spread_conserve_momentum = new CBool(cr2w),
                //CParticleModificatorTextureAnimation
                texture_animation_initial_frame = new CBufferVLQ<CFloat>(cr2w),
                p140 = new CUInt32(cr2w) { Name = "p140" },
                p144 = new CUInt32(cr2w) { Name = "p144" },
                p148 = new CUInt32(cr2w) { Name = "p148" },

                //CParticleModificatorVelocityOverLife
                velocityOverLife = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleModificatorAcceleration
                accelerationDirection = new CBufferVLQ<SVector3D>(cr2w),
                accelerationScale = new CBufferVLQ<CFloat>(cr2w),
                //CParticleModificatorRotationOverLife
                rotationOverLife = new CBufferVLQ<CFloat>(cr2w),
                //CParticleModificatorRotationRateOverLife
                rotationRateOverLife = new CBufferVLQ<CFloat>(cr2w),
                //CParticleModificatorRotation3DOverLife
                rotation3dOverLife = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleModificatorRotationRate3DOverLife
                rotationRate3dOverLife = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleModificatorColorOverLife
                colorOverLife = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleModificatorAlphaOverLife
                alphaOverLife = new CBufferVLQ<CFloat>(cr2w),
                //CParticleModificatorSizeOverLife
                sizeOverLife = new CBufferVLQ<SVector2D>(cr2w),
                //?
                sizeOverLifeOrientation = new CBufferVLQ<SVector3D>(cr2w),
                //CParticleModificatorTextureAnimation (initial frame is... missing? animation mode is defined by flags)
                textureAnimationSpeed = new CBufferVLQ<CFloat>(cr2w),

                //CParticleModificatorVelocityTurbulize
                velocityTurbulizeScale = new CBufferVLQ<SVector3D>(cr2w),
                velocityTurbulizeTimelifeLimit = new CBufferVLQ<CFloat>(cr2w),
                velocityTurbulizeNoiseInterval = new CFloat(cr2w),
                velocityTurbulizeDuration = new CFloat(cr2w),

                //CParticleModificatorTarget
                targetForceScale = new CBufferVLQ<CFloat>(cr2w),
                targetKillRadius = new CBufferVLQ<CFloat>(cr2w),
                targetMaxForce = new CFloat(cr2w),
                targetPosition = new CBufferVLQ<SVector3D>(cr2w),

                //CParticleInitializerSpawnSphere
                spawn_positive_x = new CBool(cr2w),
                spawn_negative_x = new CBool(cr2w),
                spawn_positive_y = new CBool(cr2w),
                spawn_negative_y = new CBool(cr2w),
                spawn_positive_z = new CBool(cr2w),
                spawn_negative_z = new CBool(cr2w),
                spawn_velocity = new CBool(cr2w),



                collisionTriggeringGroupIndex = new CUInt64(cr2w) { Name = "collisionTriggeringGroupIndex" },
                collision_dynamic_friction = new CFloat(cr2w) { Name = "collision_dynamic_friction" },
                collision_static_friction = new CFloat(cr2w) { Name = "collision_static_friction" },
                collision_restitution = new CFloat(cr2w) { Name = "collision_restitution" },
                collision_velocity_dampening = new CFloat(cr2w) { Name = "collision_velocity_dampening" },
                collision_disable_gravity = new CBool(cr2w) { Name = "disableGravity" },
                collision_use_gpu = new CBool(cr2w) { Name = "collision_use_gpu" },
                collision_radius = new CFloat(cr2w) { Name = "collision_radius"},
                collision_kill_when_collide = new CBool(cr2w) { Name = "killWhenCollide", },
                collision_self_emitter_index = new CUInt32(cr2w) { Name = "collision_self_emitter_index" },
                

               

                

                //CParticleModificatorCollision
                collision_spawn_probability = new CFloat(cr2w) { Name = "collision_spawn_probability"},
                collision_spawn_parent_emitter_index = new CUInt32(cr2w) { Name = "collision_spawn_parent_emitter_index" },

                
                //CParticleModificatorAlphaByDistance
                alphaByDistanceFar = new CFloat(cr2w) { Name = "alphaByDistanceFar"},
                alphaByDistanceNear = new CFloat(cr2w) { Name = "alphaByDistanceNear"}
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