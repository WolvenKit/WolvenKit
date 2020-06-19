using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDestructionSystemComponent : CDrawableComponent
	{
		[RED("m_resource")] 		public CHandle<CApexResource> M_resource { get; set;}

		[RED("targetEntityCollisionScriptName")] 		public CName TargetEntityCollisionScriptName { get; set;}

		[RED("parentEntityCollisionScriptEventName")] 		public CName ParentEntityCollisionScriptEventName { get; set;}

		[RED("parameters.m_materials", 2,0)] 		public CArray<CHandle<CMaterialGraph>> Parameters_m_materials { get; set;}

		[RED("m_physicalCollisionType")] 		public CPhysicalCollision M_physicalCollisionType { get; set;}

		[RED("m_fracturedPhysicalCollisionType")] 		public CPhysicalCollision M_fracturedPhysicalCollisionType { get; set;}

		[RED("dispacher selection")] 		public CEnum<EDispatcherSelection> Dispacher_selection { get; set;}

		[RED("dynamic")] 		public CBool Dynamic { get; set;}

		[RED("supportDepth")] 		public CUInt32 SupportDepth { get; set;}

		[RED("useAssetDefinedSupport")] 		public CBool UseAssetDefinedSupport { get; set;}

		[RED("debrisDepth")] 		public CInt32 DebrisDepth { get; set;}

		[RED("essentialDepth")] 		public CUInt32 EssentialDepth { get; set;}

		[RED("debrisTimeout")] 		public CBool DebrisTimeout { get; set;}

		[RED("debrisLifetimeMin")] 		public CFloat DebrisLifetimeMin { get; set;}

		[RED("debrisLifetimeMax")] 		public CFloat DebrisLifetimeMax { get; set;}

		[RED("debrisMaxSeparation")] 		public CBool DebrisMaxSeparation { get; set;}

		[RED("debrisMaxSeparationMin")] 		public CFloat DebrisMaxSeparationMin { get; set;}

		[RED("debrisMaxSeparationMax")] 		public CFloat DebrisMaxSeparationMax { get; set;}

		[RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[RED("minimumFractureDepth")] 		public CUInt32 MinimumFractureDepth { get; set;}

		[RED("preset")] 		public CEnum<EDestructionPreset> Preset { get; set;}

		[RED("debrisDestructionProbability")] 		public CFloat DebrisDestructionProbability { get; set;}

		[RED("crumbleSmallestChunks")] 		public CBool CrumbleSmallestChunks { get; set;}

		[RED("accumulateDamage")] 		public CBool AccumulateDamage { get; set;}

		[RED("damageCap")] 		public CFloat DamageCap { get; set;}

		[RED("damageThreshold")] 		public CFloat DamageThreshold { get; set;}

		[RED("damageToRadius")] 		public CFloat DamageToRadius { get; set;}

		[RED("forceToDamage")] 		public CFloat ForceToDamage { get; set;}

		[RED("fractureImpulseScale")] 		public CFloat FractureImpulseScale { get; set;}

		[RED("impactDamageDefaultDepth")] 		public CInt32 ImpactDamageDefaultDepth { get; set;}

		[RED("impactVelocityThreshold")] 		public CFloat ImpactVelocityThreshold { get; set;}

		[RED("materialStrength")] 		public CFloat MaterialStrength { get; set;}

		[RED("maxChunkSpeed")] 		public CFloat MaxChunkSpeed { get; set;}

		[RED("useWorldSupport")] 		public CBool UseWorldSupport { get; set;}

		[RED("useHardSleeping")] 		public CBool UseHardSleeping { get; set;}

		[RED("useStressSolver")] 		public CBool UseStressSolver { get; set;}

		[RED("stressSolverTimeDelay")] 		public CFloat StressSolverTimeDelay { get; set;}

		[RED("stressSolverMassThreshold")] 		public CFloat StressSolverMassThreshold { get; set;}

		[RED("sleepVelocityFrameDecayConstant")] 		public CFloat SleepVelocityFrameDecayConstant { get; set;}

		[RED("eventOnDestruction", 2,0)] 		public CArray<CPtr<IPerformableAction>> EventOnDestruction { get; set;}

		[RED("pathLibCollisionType")] 		public CEnum<EPathLibCollision> PathLibCollisionType { get; set;}

		[RED("disableObstacleOnDestruction")] 		public CBool DisableObstacleOnDestruction { get; set;}

		[RED("shadowDistanceOverride")] 		public CFloat ShadowDistanceOverride { get; set;}

		public CDestructionSystemComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDestructionSystemComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}