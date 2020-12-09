using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBruxaSpawnDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[Ordinal(2)] [RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[Ordinal(3)] [RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[Ordinal(4)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(5)] [RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[Ordinal(6)] [RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[Ordinal(7)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(8)] [RED("spawnEntityOnDeathName")] 		public CBehTreeValCName SpawnEntityOnDeathName { get; set;}

		[Ordinal(9)] [RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[Ordinal(10)] [RED("validateSpawnPosition")] 		public CBool ValidateSpawnPosition { get; set;}

		[Ordinal(11)] [RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[Ordinal(12)] [RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[Ordinal(13)] [RED("fxNameOnSpawnEntity")] 		public CName FxNameOnSpawnEntity { get; set;}

		[Ordinal(14)] [RED("fxNameOnSpawnOwner")] 		public CName FxNameOnSpawnOwner { get; set;}

		[Ordinal(15)] [RED("fxNameAfterSpawnOwner")] 		public CName FxNameAfterSpawnOwner { get; set;}

		[Ordinal(16)] [RED("fxNameAfterSpawnDelay")] 		public CFloat FxNameAfterSpawnDelay { get; set;}

		[Ordinal(17)] [RED("connectFxAfterSpawnWithEntity")] 		public CBool ConnectFxAfterSpawnWithEntity { get; set;}

		[Ordinal(18)] [RED("bruxaEntityTag")] 		public CName BruxaEntityTag { get; set;}

		[Ordinal(19)] [RED("inheritTagsFromOwner")] 		public CBool InheritTagsFromOwner { get; set;}

		[Ordinal(20)] [RED("setBehVarOnSpawn")] 		public CName SetBehVarOnSpawn { get; set;}

		[Ordinal(21)] [RED("setBehVarValue")] 		public CFloat SetBehVarValue { get; set;}

		[Ordinal(22)] [RED("setAppearanceOnSpawn")] 		public CName SetAppearanceOnSpawn { get; set;}

		[Ordinal(23)] [RED("setEntityAsActionTarget")] 		public CBool SetEntityAsActionTarget { get; set;}

		[Ordinal(24)] [RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[Ordinal(25)] [RED("disableVisibility")] 		public CBool DisableVisibility { get; set;}

		[Ordinal(26)] [RED("disableCollisionOnSpawn")] 		public CBool DisableCollisionOnSpawn { get; set;}

		[Ordinal(27)] [RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[Ordinal(28)] [RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[Ordinal(29)] [RED("teleportInterval")] 		public CFloat TeleportInterval { get; set;}

		[Ordinal(30)] [RED("minTeleportDistFromTarget")] 		public CFloat MinTeleportDistFromTarget { get; set;}

		[Ordinal(31)] [RED("maxTeleportDistFromTarget")] 		public CFloat MaxTeleportDistFromTarget { get; set;}

		public CBTTaskBruxaSpawnDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBruxaSpawnDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}