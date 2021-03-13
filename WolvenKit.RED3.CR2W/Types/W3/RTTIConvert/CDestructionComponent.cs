using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDestructionComponent : CMeshTypeComponent
	{
		[Ordinal(1)] [RED("m_baseResource")] 		public CHandle<CPhysicsDestructionResource> M_baseResource { get; set;}

		[Ordinal(2)] [RED("m_fracturedResource")] 		public CHandle<CPhysicsDestructionResource> M_fracturedResource { get; set;}

		[Ordinal(3)] [RED("parameters.m_pose")] 		public CMatrix Parameters_m_pose { get; set;}

		[Ordinal(4)] [RED("m_physicalCollisionType")] 		public CPhysicalCollision M_physicalCollisionType { get; set;}

		[Ordinal(5)] [RED("m_fracturedPhysicalCollisionType")] 		public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

		[Ordinal(6)] [RED("dynamic")] 		public CBool Dynamic { get; set;}

		[Ordinal(7)] [RED("kinematic")] 		public CBool Kinematic { get; set;}

		[Ordinal(8)] [RED("debrisTimeout")] 		public CBool DebrisTimeout { get; set;}

		[Ordinal(9)] [RED("debrisTimeoutMin")] 		public CFloat DebrisTimeoutMin { get; set;}

		[Ordinal(10)] [RED("debrisTimeoutMax")] 		public CFloat DebrisTimeoutMax { get; set;}

		[Ordinal(11)] [RED("initialBaseVelocity")] 		public Vector InitialBaseVelocity { get; set;}

		[Ordinal(12)] [RED("hasInitialFractureVelocity")] 		public CBool HasInitialFractureVelocity { get; set;}

		[Ordinal(13)] [RED("maxVelocity")] 		public CFloat MaxVelocity { get; set;}

		[Ordinal(14)] [RED("maxAngularFractureVelocity")] 		public CFloat MaxAngularFractureVelocity { get; set;}

		[Ordinal(15)] [RED("debrisMaxSeparationDistance")] 		public CFloat DebrisMaxSeparationDistance { get; set;}

		[Ordinal(16)] [RED("simulationDistance")] 		public CFloat SimulationDistance { get; set;}

		[Ordinal(17)] [RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(18)] [RED("forceToDamage")] 		public CFloat ForceToDamage { get; set;}

		[Ordinal(19)] [RED("damageThreshold")] 		public CFloat DamageThreshold { get; set;}

		[Ordinal(20)] [RED("damageEndurance")] 		public CFloat DamageEndurance { get; set;}

		[Ordinal(21)] [RED("accumulateDamage")] 		public CBool AccumulateDamage { get; set;}

		[Ordinal(22)] [RED("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[Ordinal(23)] [RED("fractureSoundEvent")] 		public StringAnsi FractureSoundEvent { get; set;}

		[Ordinal(24)] [RED("fxName")] 		public CName FxName { get; set;}

		[Ordinal(25)] [RED("eventOnDestruction", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventOnDestruction { get; set;}

		[Ordinal(26)] [RED("pathLibCollisionType")] 		public CEnum<EPathLibCollision> PathLibCollisionType { get; set;}

		[Ordinal(27)] [RED("disableObstacleOnDestruction")] 		public CBool DisableObstacleOnDestruction { get; set;}

		public CDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDestructionComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}