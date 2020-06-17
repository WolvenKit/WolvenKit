using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlaySyncAnimDef : IBehTreeConditionalTaskDefinition
	{
		[RED("useSetupSimpleSyncAnim2")] 		public CBool UseSetupSimpleSyncAnim2 { get; set;}

		[RED("syncAnimNameLeftStance")] 		public CName SyncAnimNameLeftStance { get; set;}

		[RED("syncAnimNameRightStance")] 		public CName SyncAnimNameRightStance { get; set;}

		[RED("raiseForceIdle")] 		public CBool RaiseForceIdle { get; set;}

		[RED("denyWhenTargetIsDodging")] 		public CBool DenyWhenTargetIsDodging { get; set;}

		[RED("denyIfTargetNotPlayer")] 		public CBool DenyIfTargetNotPlayer { get; set;}

		[RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[RED("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[RED("shouldComplete")] 		public CBool ShouldComplete { get; set;}

		public CBTTaskPlaySyncAnimDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskPlaySyncAnimDef(cr2w);

	}
}