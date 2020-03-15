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
        public CVariable[] fields;
        public CBufferVLQ<CFloat> alpha, lifeTime, rotation, rotationRate, spawnInnerRadius, spawnOuterRadius, velocity_inherit_scale, velocity_spread_scale, texture_animation_initial_frame,
            accelerationScale, rotationOverLife, rotationRateOverLife, alphaOverLife, textureAnimationSpeed,
            velocityTurbulizeTimelifeLimit, targetForceScale, targetKillRadius, unk;
        public CBufferVLQ<CVector3D> color, position, rotation3d, rotationRate3d, size_3d, spawnExtents, velocity, velocityOverLife,
            accelerationDirection, rotation3dOverLife, rotationRate3dOverLife, colorOverLife, velocityTurbulizeScale,
           targetPosition, sizeOverLifeOrientation;
        public CBufferVLQ<CVector2D> size, sizeOverLife;
        public CFloat velocityTurbulizeNoiseInterval, velocityTurbulizeDuration, targetMaxForce, collision_radius, collision_dynamic_friction, collision_static_friction, collision_restitution, collision_velocity_dampening, collision_spawn_probability;
        public CFloat alphaByDistanceFar, alphaByDistanceNear, position_offset;
        public CUInt32 p140, p144, p148, p238, p23C, p240, p244, p24C, collision_spawn_parent_emitter_index;
        public CUInt32 collision_self_emitter_index;
        public CVector3D p0A8;
        public CUInt64 p230, collisionTriggeringGroupIndex;
        public CMatrix4x4 spawnToLocalMatrix;
        public CBool collision_use_gpu, collision_kill_when_collide, collision_disable_gravity, sizeKeepRatio, spawnWorldSpace, spawnSurfaceOnly, velocity_world_space, velocity_spread_conserve_momentum;
        public CBool spawn_positive_x, spawn_negative_x, spawn_positive_y, spawn_negative_y, spawn_positive_z, spawn_negative_z, spawn_velocity, modulate;

        public SParticleEmitterModuleData(CR2WFile cr2w) : base(cr2w)
        {
            fields = new CVariable[] {
                // CParticleInitializerAlpha
                alpha = CBuffers.CreateFloatBuffer(cr2w, "alpha"),
                //CParticleInitializerColor
                color = CBuffers.CreateVector3DBuffer(cr2w, "color"),
                //CParticleInitializerLifeTime
                lifeTime = CBuffers.CreateFloatBuffer(cr2w, "lifeTime"),
                //CParticleInitializerPosition
                position = CBuffers.CreateVector3DBuffer(cr2w, "position"),
                position_offset = new CFloat(cr2w) { Name = "position_offset" },
                //CParticleInitializerRotation
                rotation = CBuffers.CreateFloatBuffer(cr2w, "rotation"),
                //CParticleInitializerRotation3D
                rotation3d = CBuffers.CreateVector3DBuffer(cr2w, "rotation3d"),
                //CParticleInitializerRotationRate
                rotationRate = CBuffers.CreateFloatBuffer(cr2w, "rotationRate"),
                //CParticleInitializerRotationRate3D
                rotationRate3d = CBuffers.CreateVector3DBuffer(cr2w, "rotationRate3d"),
                //CParticleInitializerSize
                size = CBuffers.CreateVector2DBuffer(cr2w, "size"),
                //CParticleInitializerSize3d
                size_3d = CBuffers.CreateVector3DBuffer(cr2w, "sizeOrientation"), //10
                sizeKeepRatio = new CBool(cr2w) { Name = "sizeKeepRatio"}, 
                //CParticleInitializerSpawnBox
                spawnExtents = CBuffers.CreateVector3DBuffer(cr2w, "spawnExtents"),
                //CParticleInitializerSpawnCircle
                spawnInnerRadius = CBuffers.CreateFloatBuffer(cr2w, "spawnInnerRadius"),
                spawnOuterRadius = CBuffers.CreateFloatBuffer(cr2w, "spawnOuterRadius"),
                spawnWorldSpace = new CBool(cr2w) { Name = "spawnWorldSpace" },
                spawnSurfaceOnly = new CBool(cr2w) { Name = "spawnSurfaceOnly" },
                p0A8 = new CVector3D(cr2w) { Name = "p0A8" }, //?
                spawnToLocalMatrix = new CMatrix4x4(cr2w) { Name = "spawnToLocalMatrix", },

                //CParticleInitializerVelocity
                velocity = CBuffers.CreateVector3DBuffer(cr2w, "velocity"),
                velocity_world_space = new CBool(cr2w) { Name = "velocity_world_space"},
                //CParticleInitializerVelocityInherit
                velocity_inherit_scale = CBuffers.CreateFloatBuffer(cr2w, "velocity_inherit_scale"),
                //CParticleInitializerVelocitySpread
                velocity_spread_scale = CBuffers.CreateFloatBuffer(cr2w, "velocity_spread_scale"),
                velocity_spread_conserve_momentum = new CBool(cr2w) { Name = "velocity_spread_conserve_momentum" }, //30
                //CParticleModificatorTextureAnimation
                texture_animation_initial_frame = CBuffers.CreateFloatBuffer(cr2w, "texture_animation_initial_frame"),
                p140 = new CUInt32(cr2w) { Name = "p140", Type = "CUInt32" },
                p144 = new CUInt32(cr2w) { Name = "p144", Type = "CUInt32" },
                p148 = new CUInt32(cr2w) { Name = "p148", Type = "CUInt32" },

                //CParticleModificatorVelocityOverLife
                velocityOverLife = CBuffers.CreateVector3DBuffer(cr2w, "velocityOverLife"),
                //CParticleModificatorAcceleration
                accelerationDirection = CBuffers.CreateVector3DBuffer(cr2w, "accelerationDirection"),
                accelerationScale = CBuffers.CreateFloatBuffer(cr2w, "accelerationScale"),
                //CParticleModificatorRotationOverLife
                rotationOverLife = CBuffers.CreateFloatBuffer(cr2w, "rotationOverLife"),
                //CParticleModificatorRotationRateOverLife
                rotationRateOverLife = CBuffers.CreateFloatBuffer(cr2w, "rotationRateOverLife"),
                //CParticleModificatorRotation3DOverLife
                rotation3dOverLife = CBuffers.CreateVector3DBuffer(cr2w, "rotation3dOverLife"), //40
                //CParticleModificatorRotationRate3DOverLife
                rotationRate3dOverLife = CBuffers.CreateVector3DBuffer(cr2w, "rorationRate3dOverLife"),
                //CParticleModificatorColorOverLife
                colorOverLife = CBuffers.CreateVector3DBuffer(cr2w, "colorOverLife"),
                //CParticleModificatorAlphaOverLife
                alphaOverLife = CBuffers.CreateFloatBuffer(cr2w, "alphaOverLife"),
                //CParticleModificatorSizeOverLife
                sizeOverLife = CBuffers.CreateVector2DBuffer(cr2w, "sizeOverLife"),
                //?
                sizeOverLifeOrientation = CBuffers.CreateVector3DBuffer(cr2w, "sizeOverLifeOrientation"),
                //CParticleModificatorTextureAnimation (initial frame is... missing? animation mode is defined by flags)
                textureAnimationSpeed = CBuffers.CreateFloatBuffer(cr2w, "textureAnimationSpeed"),

                //CParticleModificatorVelocityTurbulize
                velocityTurbulizeScale = CBuffers.CreateVector3DBuffer(cr2w, "velocityTurbulizeScale"),
                velocityTurbulizeTimelifeLimit = CBuffers.CreateFloatBuffer(cr2w, "velocityTurbulizeTimelifeLimit"),
                velocityTurbulizeNoiseInterval = new CFloat(cr2w) { Name = "velocityTurbulizeNoiseInterval"},
                velocityTurbulizeDuration = new CFloat(cr2w) { Name = "velocityTurbulizeDuration" }, //50

                //CParticleModificatorTarget
                targetForceScale = CBuffers.CreateFloatBuffer(cr2w, "targetForceScale"),
                targetKillRadius = CBuffers.CreateFloatBuffer(cr2w, "targetKillRadius"),
                targetMaxForce = new CFloat(cr2w) { Name = "targetMaxForce" },
                targetPosition = CBuffers.CreateVector3DBuffer(cr2w, "targetPosition"),

                //CParticleInitializerSpawnSphere
                spawn_positive_x = new CBool(cr2w) { Name = "spawn_positive_x"}, 
                spawn_negative_x = new CBool(cr2w) { Name = "spawn_negative_x"}, //20
                spawn_positive_y = new CBool(cr2w) { Name = "spawn_positive_y"},
                spawn_negative_y = new CBool(cr2w) { Name = "spawn_negative_y"},
                spawn_positive_z = new CBool(cr2w) { Name = "spawn_position_z"},
                spawn_negative_z = new CBool(cr2w) { Name = "spawn_negative_z"},
                spawn_velocity = new CBool(cr2w) { Name = "spawn_velocity"},



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
                alphaByDistanceFar = new CFloat(cr2w) { Name = "alphaByDistanceFar",},
                alphaByDistanceNear = new CFloat(cr2w) { Name = "alphaByDistanceNear", }
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
    }
}