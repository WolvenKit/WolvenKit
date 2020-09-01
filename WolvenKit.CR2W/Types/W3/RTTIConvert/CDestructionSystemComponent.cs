using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDestructionSystemComponent : CDrawableComponent
	{
		[Ordinal(1)] [RED("("m_resource")] 		public CHandle<CApexResource> M_resource { get; set;}

		[Ordinal(2)] [RED("("targetEntityCollisionScriptName")] 		public CName TargetEntityCollisionScriptName { get; set;}

		[Ordinal(3)] [RED("("parentEntityCollisionScriptEventName")] 		public CName ParentEntityCollisionScriptEventName { get; set;}

		[Ordinal(4)] [RED("("parameters.m_materials", 2,0)] 		public CArray<CHandle<CMaterialGraph>> Parameters_m_materials { get; set;}

		[Ordinal(5)] [RED("("m_physicalCollisionType")] 		public CPhysicalCollision M_physicalCollisionType { get; set;}

		[Ordinal(6)] [RED("("m_fracturedPhysicalCollisionType")] 		public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

		[Ordinal(7)] [RED("("dispacher selection")] 		public CEnum<EDispatcherSelection> Dispacher_selection { get; set;}

		[Ordinal(8)] [RED("("dynamic")] 		public CBool Dynamic { get; set;}

		[Ordinal(9)] [RED("("supportDepth")] 		public CUInt32 SupportDepth { get; set;}

		[Ordinal(10)] [RED("("useAssetDefinedSupport")] 		public CBool UseAssetDefinedSupport { get; set;}

		[Ordinal(11)] [RED("("debrisDepth")] 		public CInt32 DebrisDepth { get; set;}

		[Ordinal(12)] [RED("("essentialDepth")] 		public CUInt32 EssentialDepth { get; set;}

		[Ordinal(13)] [RED("("debrisTimeout")] 		public CBool DebrisTimeout { get; set;}

		[Ordinal(14)] [RED("("debrisLifetimeMin")] 		public CFloat DebrisLifetimeMin { get; set;}

		[Ordinal(15)] [RED("("debrisLifetimeMax")] 		public CFloat DebrisLifetimeMax { get; set;}

		[Ordinal(16)] [RED("("debrisMaxSeparation")] 		public CBool DebrisMaxSeparation { get; set;}

		[Ordinal(17)] [RED("("debrisMaxSeparationMin")] 		public CFloat DebrisMaxSeparationMin { get; set;}

		[Ordinal(18)] [RED("("debrisMaxSeparationMax")] 		public CFloat DebrisMaxSeparationMax { get; set;}

		[Ordinal(19)] [RED("("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(20)] [RED("("minimumFractureDepth")] 		public CUInt32 MinimumFractureDepth { get; set;}

		[Ordinal(21)] [RED("("preset")] 		public CEnum<EDestructionPreset> Preset { get; set;}

		[Ordinal(22)] [RED("("debrisDestructionProbability")] 		public CFloat DebrisDestructionProbability { get; set;}

		[Ordinal(23)] [RED("("crumbleSmallestChunks")] 		public CBool CrumbleSmallestChunks { get; set;}

		[Ordinal(24)] [RED("("accumulateDamage")] 		public CBool AccumulateDamage { get; set;}

		[Ordinal(25)] [RED("("damageCap")] 		public CFloat DamageCap { get; set;}

		[Ordinal(26)] [RED("("damageThreshold")] 		public CFloat DamageThreshold { get; set;}

		[Ordinal(27)] [RED("("damageToRadius")] 		public CFloat DamageToRadius { get; set;}

		[Ordinal(28)] [RED("("forceToDamage")] 		public CFloat ForceToDamage { get; set;}

		[Ordinal(29)] [RED("("fractureImpulseScale")] 		public CFloat FractureImpulseScale { get; set;}

		[Ordinal(30)] [RED("("impactDamageDefaultDepth")] 		public CInt32 ImpactDamageDefaultDepth { get; set;}

		[Ordinal(31)] [RED("("impactVelocityThreshold")] 		public CFloat ImpactVelocityThreshold { get; set;}

		[Ordinal(32)] [RED("("materialStrength")] 		public CFloat MaterialStrength { get; set;}

		[Ordinal(33)] [RED("("maxChunkSpeed")] 		public CFloat MaxChunkSpeed { get; set;}

		[Ordinal(34)] [RED("("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[Ordinal(35)] [RED("("useHardSleeping")] 		public CBool UseHardSleeping { get; set;}

		[Ordinal(36)] [RED("("useStressSolver")] 		public CBool UseStressSolver { get; set;}

		[Ordinal(37)] [RED("("stressSolverTimeDelay")] 		public CFloat StressSolverTimeDelay { get; set;}

		[Ordinal(38)] [RED("("stressSolverMassThreshold")] 		public CFloat StressSolverMassThreshold { get; set;}

		[Ordinal(39)] [RED("("sleepVelocityFrameDecayConstant")] 		public CFloat SleepVelocityFrameDecayConstant { get; set;}

		[Ordinal(40)] [RED("("eventOnDestruction", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventOnDestruction { get; set;}

		[Ordinal(41)] [RED("("pathLibCollisionType")] 		public CEnum<EPathLibCollision> PathLibCollisionType { get; set;}

		[Ordinal(42)] [RED("("disableObstacleOnDestruction")] 		public CBool DisableObstacleOnDestruction { get; set;}

		[Ordinal(43)] [RED("("shadowDistanceOverride")] 		public CFloat ShadowDistanceOverride { get; set;}

		public CDestructionSystemComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDestructionSystemComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}