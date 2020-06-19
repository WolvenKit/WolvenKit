using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskManageSpawnFXEntityDef : CBTTaskSpawnFXEntityDef
	{
		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("activateOnGameplayEvent")] 		public CName ActivateOnGameplayEvent { get; set;}

		[RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[RED("activationCooldown")] 		public CFloat ActivationCooldown { get; set;}

		[RED("teleportFXEntityOnAnimEvent")] 		public CName TeleportFXEntityOnAnimEvent { get; set;}

		[RED("teleportFXEntityOnGameplayEvent")] 		public CName TeleportFXEntityOnGameplayEvent { get; set;}

		[RED("teleportInRandomDirection")] 		public CBool TeleportInRandomDirection { get; set;}

		[RED("randomPositionPattern")] 		public CEnum<ESpawnPositionPattern> RandomPositionPattern { get; set;}

		[RED("randomTeleportMinRange")] 		public CFloat RandomTeleportMinRange { get; set;}

		[RED("randomTeleportMaxRange")] 		public CFloat RandomTeleportMaxRange { get; set;}

		[RED("randomTeleportInterval")] 		public CFloat RandomTeleportInterval { get; set;}

		[RED("teleportZAxisOffsetMin")] 		public CFloat TeleportZAxisOffsetMin { get; set;}

		[RED("teleportZAxisOffsetMax")] 		public CFloat TeleportZAxisOffsetMax { get; set;}

		[RED("fxNameOnRandomTeleportOnNPC")] 		public CName FxNameOnRandomTeleportOnNPC { get; set;}

		[RED("fxNameOnRandomTeleportOnFXEntity")] 		public CName FxNameOnRandomTeleportOnFXEntity { get; set;}

		[RED("fxNameOnTeleportToTargetOnNPC")] 		public CName FxNameOnTeleportToTargetOnNPC { get; set;}

		[RED("fxNameOnTeleportToTargetOnFXEntity")] 		public CName FxNameOnTeleportToTargetOnFXEntity { get; set;}

		[RED("connectFXWithTarget")] 		public CBool ConnectFXWithTarget { get; set;}

		[RED("destroyEntityOnCombatEnd")] 		public CBool DestroyEntityOnCombatEnd { get; set;}

		public CBTTaskManageSpawnFXEntityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskManageSpawnFXEntityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}