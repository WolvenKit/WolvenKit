using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDestructionComponent : CMeshTypeComponent
	{
		[Ordinal(0)] [RED("("m_baseResource")] 		public CHandle<CPhysicsDestructionResource> M_baseResource { get; set;}

		[Ordinal(0)] [RED("("m_fracturedResource")] 		public CHandle<CPhysicsDestructionResource> M_fracturedResource { get; set;}

		[Ordinal(0)] [RED("("parameters.m_pose")] 		public CMatrix Parameters_m_pose { get; set;}

		[Ordinal(0)] [RED("("m_physicalCollisionType")] 		public CPhysicalCollision M_physicalCollisionType { get; set;}

		[Ordinal(0)] [RED("("m_fracturedPhysicalCollisionType")] 		public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

		[Ordinal(0)] [RED("("dynamic")] 		public CBool Dynamic { get; set;}

		[Ordinal(0)] [RED("("kinematic")] 		public CBool Kinematic { get; set;}

		[Ordinal(0)] [RED("("debrisTimeout")] 		public CBool DebrisTimeout { get; set;}

		[Ordinal(0)] [RED("("debrisTimeoutMin")] 		public CFloat DebrisTimeoutMin { get; set;}

		[Ordinal(0)] [RED("("debrisTimeoutMax")] 		public CFloat DebrisTimeoutMax { get; set;}

		[Ordinal(0)] [RED("("initialBaseVelocity")] 		public Vector InitialBaseVelocity { get; set;}

		[Ordinal(0)] [RED("("hasInitialFractureVelocity")] 		public CBool HasInitialFractureVelocity { get; set;}

		[Ordinal(0)] [RED("("maxVelocity")] 		public CFloat MaxVelocity { get; set;}

		[Ordinal(0)] [RED("("maxAngularFractureVelocity")] 		public CFloat MaxAngularFractureVelocity { get; set;}

		[Ordinal(0)] [RED("("debrisMaxSeparationDistance")] 		public CFloat DebrisMaxSeparationDistance { get; set;}

		[Ordinal(0)] [RED("("simulationDistance")] 		public CFloat SimulationDistance { get; set;}

		[Ordinal(0)] [RED("("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(0)] [RED("("forceToDamage")] 		public CFloat ForceToDamage { get; set;}

		[Ordinal(0)] [RED("("damageThreshold")] 		public CFloat DamageThreshold { get; set;}

		[Ordinal(0)] [RED("("damageEndurance")] 		public CFloat DamageEndurance { get; set;}

		[Ordinal(0)] [RED("("accumulateDamage")] 		public CBool AccumulateDamage { get; set;}

		[Ordinal(0)] [RED("("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[Ordinal(0)] [RED("("fractureSoundEvent")] 		public StringAnsi FractureSoundEvent { get; set;}

		[Ordinal(0)] [RED("("fxName")] 		public CName FxName { get; set;}

		[Ordinal(0)] [RED("("eventOnDestruction", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventOnDestruction { get; set;}

		[Ordinal(0)] [RED("("pathLibCollisionType")] 		public CEnum<EPathLibCollision> PathLibCollisionType { get; set;}

		[Ordinal(0)] [RED("("disableObstacleOnDestruction")] 		public CBool DisableObstacleOnDestruction { get; set;}

		public CDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDestructionComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}