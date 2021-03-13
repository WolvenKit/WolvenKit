using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED3.CR2W.Reflection;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SParticleEmitterModuleData : CVariable
    {
        private CVariable[] fields { get; set; }

        public CBufferVLQInt32<CFloat> alpha, lifeTime, rotation, rotationRate, spawnInnerRadius, spawnOuterRadius, velocity_inherit_scale, velocity_spread_scale, texture_animation_initial_frame,
            accelerationScale, rotationOverLife, rotationRateOverLife, alphaOverLife, textureAnimationSpeed,
            velocityTurbulizeTimelifeLimit, targetForceScale, targetKillRadius, unk;
        public CBufferVLQInt32<SVector3D> color, position, rotation3d, rotationRate3d, size_3d, spawnExtents, velocity, velocityOverLife,
            accelerationDirection, rotation3dOverLife, rotationRate3dOverLife, colorOverLife, velocityTurbulizeScale,
           targetPosition, sizeOverLifeOrientation;
        public CBufferVLQInt32<SVector2D> size, sizeOverLife;
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
                alpha = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(alpha)),
                //CParticleInitializerColor
                color = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(color)),
                //CParticleInitializerLifeTime
                lifeTime = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(lifeTime)),
                //CParticleInitializerPosition
                position = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(position)),
                position_offset = new CFloat(cr2w, this, nameof(position_offset)),
                //CParticleInitializerRotation
                rotation = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(rotation)),
                //CParticleInitializerRotation3D
                rotation3d = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(rotation3d)),
                //CParticleInitializerRotationRate
                rotationRate = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(rotationRate)),
                //CParticleInitializerRotationRate3D
                rotationRate3d = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(rotationRate3d)),
                //CParticleInitializerSize
                size = new CBufferVLQInt32<SVector2D>(cr2w, this, nameof(size)),
                //CParticleInitializerSize3d
                size_3d = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(size_3d)),
                sizeKeepRatio = new CBool(cr2w, this, nameof(sizeKeepRatio)),
                //CParticleInitializerSpawnBox
                spawnExtents = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(spawnExtents)),
                //CParticleInitializerSpawnCircle
                spawnInnerRadius = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(spawnInnerRadius)),
                spawnOuterRadius = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(spawnOuterRadius)),
                spawnWorldSpace = new CBool(cr2w, this, nameof(spawnWorldSpace)),
                spawnSurfaceOnly = new CBool(cr2w, this, nameof(spawnSurfaceOnly)),
                p0A8 = new SVector3D(cr2w, this, nameof(p0A8)),
                spawnToLocalMatrix = new CMatrix4x4(cr2w, this, nameof(spawnToLocalMatrix)),

                //CParticleInitializerVelocity
                velocity = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(velocity)),
                velocity_world_space = new CBool(cr2w, this, nameof(velocity_world_space)),
                //CParticleInitializerVelocityInherit
                velocity_inherit_scale = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(velocity_inherit_scale)),
                //CParticleInitializerVelocitySpread
                velocity_spread_scale = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(velocity_spread_scale)),
                velocity_spread_conserve_momentum = new CBool(cr2w, this, nameof(velocity_spread_conserve_momentum)),
                //CParticleModificatorTextureAnimation
                texture_animation_initial_frame = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(texture_animation_initial_frame)),
                p140 = new CUInt32(cr2w, this, nameof(p140)),
                p144 = new CUInt32(cr2w, this, nameof(p144)),
                p148 = new CUInt32(cr2w, this, nameof(p148)),

                //CParticleModificatorVelocityOverLife
                velocityOverLife = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(velocityOverLife)),
                //CParticleModificatorAcceleration
                accelerationDirection = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(accelerationDirection)),
                accelerationScale = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(accelerationScale)),
                //CParticleModificatorRotationOverLife
                rotationOverLife = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(rotationOverLife)),
                //CParticleModificatorRotationRateOverLife
                rotationRateOverLife = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(rotationRateOverLife)),
                //CParticleModificatorRotation3DOverLife
                rotation3dOverLife = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(rotation3dOverLife)),
                //CParticleModificatorRotationRate3DOverLife
                rotationRate3dOverLife = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(rotationRate3dOverLife)),
                //CParticleModificatorColorOverLife
                colorOverLife = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(colorOverLife)),
                //CParticleModificatorAlphaOverLife
                alphaOverLife = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(alphaOverLife)),
                //CParticleModificatorSizeOverLife
                sizeOverLife = new CBufferVLQInt32<SVector2D>(cr2w, this, nameof(sizeOverLife)),
                //?
                sizeOverLifeOrientation = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(sizeOverLifeOrientation)),
                //CParticleModificatorTextureAnimation (initial frame is... missing? animation mode is defined by flags)
                textureAnimationSpeed = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(textureAnimationSpeed)),

                //CParticleModificatorVelocityTurbulize
                velocityTurbulizeScale = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(velocityTurbulizeScale)),
                velocityTurbulizeTimelifeLimit = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(velocityTurbulizeTimelifeLimit)),
                velocityTurbulizeNoiseInterval = new CFloat(cr2w, this, nameof(velocityTurbulizeNoiseInterval)),
                velocityTurbulizeDuration = new CFloat(cr2w, this, nameof(velocityTurbulizeDuration)),

                //CParticleModificatorTarget
                targetForceScale = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(targetForceScale)),
                targetKillRadius = new CBufferVLQInt32<CFloat>(cr2w, this, nameof(targetKillRadius)),
                targetMaxForce = new CFloat(cr2w, this, nameof(targetMaxForce)),
                targetPosition = new CBufferVLQInt32<SVector3D>(cr2w, this, nameof(targetPosition)),

                //CParticleInitializerSpawnSphere
                spawn_positive_x = new CBool(cr2w, this, nameof(spawn_positive_x)),
                spawn_negative_x = new CBool(cr2w, this, nameof(spawn_negative_x)),
                spawn_positive_y = new CBool(cr2w, this, nameof(spawn_positive_y)),
                spawn_negative_y = new CBool(cr2w, this, nameof(spawn_negative_y)),
                spawn_positive_z = new CBool(cr2w, this, nameof(spawn_positive_z)),
                spawn_negative_z = new CBool(cr2w, this, nameof(spawn_negative_z)),
                spawn_velocity = new CBool(cr2w, this, nameof(spawn_velocity)),



                collisionTriggeringGroupIndex = new CUInt64(cr2w, this, nameof(collisionTriggeringGroupIndex)),
                collision_dynamic_friction = new CFloat(cr2w, this, nameof(collision_dynamic_friction)),
                collision_static_friction = new CFloat(cr2w, this, nameof(collision_static_friction)),
                collision_restitution = new CFloat(cr2w, this, nameof(collision_restitution)),
                collision_velocity_dampening = new CFloat(cr2w, this, nameof(collision_velocity_dampening)),
                collision_disable_gravity = new CBool(cr2w, this, nameof(collision_disable_gravity)),
                collision_use_gpu = new CBool(cr2w, this, nameof(collision_use_gpu)),
                collision_radius = new CFloat(cr2w, this, nameof(collision_radius)),
                collision_kill_when_collide = new CBool(cr2w, this, nameof(collision_kill_when_collide)),
                collision_self_emitter_index = new CUInt32(cr2w, this, nameof(collision_self_emitter_index)),
                

               

                

                //CParticleModificatorCollision
                collision_spawn_probability = new CFloat(cr2w, this, nameof(collision_spawn_probability)),
                collision_spawn_parent_emitter_index = new CUInt32(cr2w, this, nameof(collision_spawn_parent_emitter_index)),

                
                //CParticleModificatorAlphaByDistance
                alphaByDistanceFar = new CFloat(cr2w, this, nameof(alphaByDistanceFar)),
                alphaByDistanceNear = new CFloat(cr2w, this, nameof(alphaByDistanceNear))
            };
        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
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

        public override IEditableVariable Copy(ICR2WCopyAction context)
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