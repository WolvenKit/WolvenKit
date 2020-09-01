using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageSpawnFXEntityDef : CBTTaskSpawnFXEntityDef
	{
		[Ordinal(0)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("activateOnGameplayEvent")] 		public CName ActivateOnGameplayEvent { get; set;}

		[Ordinal(0)] [RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[Ordinal(0)] [RED("activationCooldown")] 		public CFloat ActivationCooldown { get; set;}

		[Ordinal(0)] [RED("teleportFXEntityOnAnimEvent")] 		public CName TeleportFXEntityOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("teleportFXEntityOnGameplayEvent")] 		public CName TeleportFXEntityOnGameplayEvent { get; set;}

		[Ordinal(0)] [RED("teleportInRandomDirection")] 		public CBool TeleportInRandomDirection { get; set;}

		[Ordinal(0)] [RED("randomPositionPattern")] 		public CEnum<ESpawnPositionPattern> RandomPositionPattern { get; set;}

		[Ordinal(0)] [RED("randomTeleportMinRange")] 		public CFloat RandomTeleportMinRange { get; set;}

		[Ordinal(0)] [RED("randomTeleportMaxRange")] 		public CFloat RandomTeleportMaxRange { get; set;}

		[Ordinal(0)] [RED("randomTeleportInterval")] 		public CFloat RandomTeleportInterval { get; set;}

		[Ordinal(0)] [RED("teleportZAxisOffsetMin")] 		public CFloat TeleportZAxisOffsetMin { get; set;}

		[Ordinal(0)] [RED("teleportZAxisOffsetMax")] 		public CFloat TeleportZAxisOffsetMax { get; set;}

		[Ordinal(0)] [RED("fxNameOnRandomTeleportOnNPC")] 		public CName FxNameOnRandomTeleportOnNPC { get; set;}

		[Ordinal(0)] [RED("fxNameOnRandomTeleportOnFXEntity")] 		public CName FxNameOnRandomTeleportOnFXEntity { get; set;}

		[Ordinal(0)] [RED("fxNameOnTeleportToTargetOnNPC")] 		public CName FxNameOnTeleportToTargetOnNPC { get; set;}

		[Ordinal(0)] [RED("fxNameOnTeleportToTargetOnFXEntity")] 		public CName FxNameOnTeleportToTargetOnFXEntity { get; set;}

		[Ordinal(0)] [RED("connectFXWithTarget")] 		public CBool ConnectFXWithTarget { get; set;}

		[Ordinal(0)] [RED("destroyEntityOnCombatEnd")] 		public CBool DestroyEntityOnCombatEnd { get; set;}

		public CBTTaskManageSpawnFXEntityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageSpawnFXEntityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}