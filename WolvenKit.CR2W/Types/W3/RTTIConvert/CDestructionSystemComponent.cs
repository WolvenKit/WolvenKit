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
		[Ordinal(0)] [RED("("m_resource")] 		public CHandle<CApexResource> M_resource { get; set;}

		[Ordinal(0)] [RED("("targetEntityCollisionScriptName")] 		public CName TargetEntityCollisionScriptName { get; set;}

		[Ordinal(0)] [RED("("parentEntityCollisionScriptEventName")] 		public CName ParentEntityCollisionScriptEventName { get; set;}

		[Ordinal(0)] [RED("("parameters.m_materials", 2,0)] 		public CArray<CHandle<CMaterialGraph>> Parameters_m_materials { get; set;}

		[Ordinal(0)] [RED("("m_physicalCollisionType")] 		public CPhysicalCollision M_physicalCollisionType { get; set;}

		[Ordinal(0)] [RED("("m_fracturedPhysicalCollisionType")] 		public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

		[Ordinal(0)] [RED("("dispacher selection")] 		public CEnum<EDispatcherSelection> Dispacher_selection { get; set;}

		[Ordinal(0)] [RED("("dynamic")] 		public CBool Dynamic { get; set;}

		[Ordinal(0)] [RED("("supportDepth")] 		public CUInt32 SupportDepth { get; set;}

		[Ordinal(0)] [RED("("useAssetDefinedSupport")] 		public CBool UseAssetDefinedSupport { get; set;}

		[Ordinal(0)] [RED("("debrisDepth")] 		public CInt32 DebrisDepth { get; set;}

		[Ordinal(0)] [RED("("essentialDepth")] 		public CUInt32 EssentialDepth { get; set;}

		[Ordinal(0)] [RED("("debrisTimeout")] 		public CBool DebrisTimeout { get; set;}

		[Ordinal(0)] [RED("("debrisLifetimeMin")] 		public CFloat DebrisLifetimeMin { get; set;}

		[Ordinal(0)] [RED("("debrisLifetimeMax")] 		public CFloat DebrisLifetimeMax { get; set;}

		[Ordinal(0)] [RED("("debrisMaxSeparation")] 		public CBool DebrisMaxSeparation { get; set;}

		[Ordinal(0)] [RED("("debrisMaxSeparationMin")] 		public CFloat DebrisMaxSeparationMin { get; set;}

		[Ordinal(0)] [RED("("debrisMaxSeparationMax")] 		public CFloat DebrisMaxSeparationMax { get; set;}

		[Ordinal(0)] [RED("("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(0)] [RED("("minimumFractureDepth")] 		public CUInt32 MinimumFractureDepth { get; set;}

		[Ordinal(0)] [RED("("preset")] 		public CEnum<EDestructionPreset> Preset { get; set;}

		[Ordinal(0)] [RED("("debrisDestructionProbability")] 		public CFloat DebrisDestructionProbability { get; set;}

		[Ordinal(0)] [RED("("crumbleSmallestChunks")] 		public CBool CrumbleSmallestChunks { get; set;}

		[Ordinal(0)] [RED("("accumulateDamage")] 		public CBool AccumulateDamage { get; set;}

		[Ordinal(0)] [RED("("damageCap")] 		public CFloat DamageCap { get; set;}

		[Ordinal(0)] [RED("("damageThreshold")] 		public CFloat DamageThreshold { get; set;}

		[Ordinal(0)] [RED("("damageToRadius")] 		public CFloat DamageToRadius { get; set;}

		[Ordinal(0)] [RED("("forceToDamage")] 		public CFloat ForceToDamage { get; set;}

		[Ordinal(0)] [RED("("fractureImpulseScale")] 		public CFloat FractureImpulseScale { get; set;}

		[Ordinal(0)] [RED("("impactDamageDefaultDepth")] 		public CInt32 ImpactDamageDefaultDepth { get; set;}

		[Ordinal(0)] [RED("("impactVelocityThreshold")] 		public CFloat ImpactVelocityThreshold { get; set;}

		[Ordinal(0)] [RED("("materialStrength")] 		public CFloat MaterialStrength { get; set;}

		[Ordinal(0)] [RED("("maxChunkSpeed")] 		public CFloat MaxChunkSpeed { get; set;}

		[Ordinal(0)] [RED("("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[Ordinal(0)] [RED("("useHardSleeping")] 		public CBool UseHardSleeping { get; set;}

		[Ordinal(0)] [RED("("useStressSolver")] 		public CBool UseStressSolver { get; set;}

		[Ordinal(0)] [RED("("stressSolverTimeDelay")] 		public CFloat StressSolverTimeDelay { get; set;}

		[Ordinal(0)] [RED("("stressSolverMassThreshold")] 		public CFloat StressSolverMassThreshold { get; set;}

		[Ordinal(0)] [RED("("sleepVelocityFrameDecayConstant")] 		public CFloat SleepVelocityFrameDecayConstant { get; set;}

		[Ordinal(0)] [RED("("eventOnDestruction", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventOnDestruction { get; set;}

		[Ordinal(0)] [RED("("pathLibCollisionType")] 		public CEnum<EPathLibCollision> PathLibCollisionType { get; set;}

		[Ordinal(0)] [RED("("disableObstacleOnDestruction")] 		public CBool DisableObstacleOnDestruction { get; set;}

		[Ordinal(0)] [RED("("shadowDistanceOverride")] 		public CFloat ShadowDistanceOverride { get; set;}

		public CDestructionSystemComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDestructionSystemComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}