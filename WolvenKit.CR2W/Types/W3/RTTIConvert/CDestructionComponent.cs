using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDestructionComponent : CMeshTypeComponent
	{
		[RED("m_baseResource")] 		public CHandle<CPhysicsDestructionResource> M_baseResource { get; set;}

		[RED("m_fracturedResource")] 		public CHandle<CPhysicsDestructionResource> M_fracturedResource { get; set;}

		[RED("parameters.m_pose")] 		public CMatrix Parameters_m_pose { get; set;}

		[RED("m_physicalCollisionType")] 		public CPhysicalCollision M_physicalCollisionType { get; set;}

		[RED("m_fracturedPhysicalCollisionType")] 		public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

		[RED("dynamic")] 		public CBool Dynamic { get; set;}

		[RED("kinematic")] 		public CBool Kinematic { get; set;}

		[RED("debrisTimeout")] 		public CBool DebrisTimeout { get; set;}

		[RED("debrisTimeoutMin")] 		public CFloat DebrisTimeoutMin { get; set;}

		[RED("debrisTimeoutMax")] 		public CFloat DebrisTimeoutMax { get; set;}

		[RED("initialBaseVelocity")] 		public Vector InitialBaseVelocity { get; set;}

		[RED("hasInitialFractureVelocity")] 		public CBool HasInitialFractureVelocity { get; set;}

		[RED("maxVelocity")] 		public CFloat MaxVelocity { get; set;}

		[RED("maxAngularFractureVelocity")] 		public CFloat MaxAngularFractureVelocity { get; set;}

		[RED("debrisMaxSeparationDistance")] 		public CFloat DebrisMaxSeparationDistance { get; set;}

		[RED("simulationDistance")] 		public CFloat SimulationDistance { get; set;}

		[RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[RED("forceToDamage")] 		public CFloat ForceToDamage { get; set;}

		[RED("damageThreshold")] 		public CFloat DamageThreshold { get; set;}

		[RED("damageEndurance")] 		public CFloat DamageEndurance { get; set;}

		[RED("accumulateDamage")] 		public CBool AccumulateDamage { get; set;}

		[RED("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[RED("fractureSoundEvent")] 		public StringAnsi FractureSoundEvent { get; set;}

		[RED("fxName")] 		public CName FxName { get; set;}

		[RED("eventOnDestruction", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventOnDestruction { get; set;}

		[RED("pathLibCollisionType")] 		public CEnum<EPathLibCollision> PathLibCollisionType { get; set;}

		[RED("disableObstacleOnDestruction")] 		public CBool DisableObstacleOnDestruction { get; set;}

		public CDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDestructionComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}