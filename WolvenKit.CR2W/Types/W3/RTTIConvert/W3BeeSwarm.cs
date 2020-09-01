using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BeeSwarm : CGameplayEntity
	{
		[Ordinal(1)] [RED("("damageVal")] 		public SAbilityAttributeValue DamageVal { get; set;}

		[Ordinal(2)] [RED("("destroyEntAfter")] 		public CFloat DestroyEntAfter { get; set;}

		[Ordinal(3)] [RED("("velocity")] 		public CFloat Velocity { get; set;}

		[Ordinal(4)] [RED("("bIsEnabled")] 		public CBool BIsEnabled { get; set;}

		[Ordinal(5)] [RED("("AIReactionRange")] 		public CFloat AIReactionRange { get; set;}

		[Ordinal(6)] [RED("("ignoreNPCsFriendlyToPlayer")] 		public CBool IgnoreNPCsFriendlyToPlayer { get; set;}

		[Ordinal(7)] [RED("("maxChaseDistance")] 		public CFloat MaxChaseDistance { get; set;}

		[Ordinal(8)] [RED("("desiredTargetTag")] 		public CName DesiredTargetTag { get; set;}

		[Ordinal(9)] [RED("("excludedEntitiesTags", 2,0)] 		public CArray<CName> ExcludedEntitiesTags { get; set;}

		[Ordinal(10)] [RED("("factOnDestruction")] 		public CString FactOnDestruction { get; set;}

		[Ordinal(11)] [RED("("originEntity")] 		public CHandle<CGameplayEntity> OriginEntity { get; set;}

		[Ordinal(12)] [RED("("originPoint")] 		public Vector OriginPoint { get; set;}

		[Ordinal(13)] [RED("("victims", 2,0)] 		public CArray<SSwarmVictim> Victims { get; set;}

		[Ordinal(14)] [RED("("buffParams")] 		public SCustomEffectParams BuffParams { get; set;}

		[Ordinal(15)] [RED("("targets", 2,0)] 		public CArray<CHandle<CGameplayEntity>> Targets { get; set;}

		[Ordinal(16)] [RED("("activeDistanceSquared")] 		public CFloat ActiveDistanceSquared { get; set;}

		[Ordinal(17)] [RED("("PLAYER_PRESENCE_CHECK_DISTANCE")] 		public CFloat PLAYER_PRESENCE_CHECK_DISTANCE { get; set;}

		[Ordinal(18)] [RED("("PRESENCE_CHECK_DT")] 		public CFloat PRESENCE_CHECK_DT { get; set;}

		[Ordinal(19)] [RED("("TARGETS_CHECK_DT")] 		public CFloat TARGETS_CHECK_DT { get; set;}

		public W3BeeSwarm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BeeSwarm(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}