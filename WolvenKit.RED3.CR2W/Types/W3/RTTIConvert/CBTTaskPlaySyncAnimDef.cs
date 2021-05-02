using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlaySyncAnimDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("useSetupSimpleSyncAnim2")] 		public CBool UseSetupSimpleSyncAnim2 { get; set;}

		[Ordinal(2)] [RED("syncAnimNameLeftStance")] 		public CName SyncAnimNameLeftStance { get; set;}

		[Ordinal(3)] [RED("syncAnimNameRightStance")] 		public CName SyncAnimNameRightStance { get; set;}

		[Ordinal(4)] [RED("raiseForceIdle")] 		public CBool RaiseForceIdle { get; set;}

		[Ordinal(5)] [RED("denyWhenTargetIsDodging")] 		public CBool DenyWhenTargetIsDodging { get; set;}

		[Ordinal(6)] [RED("denyIfTargetNotPlayer")] 		public CBool DenyIfTargetNotPlayer { get; set;}

		[Ordinal(7)] [RED("onAnimEvent")] 		public CName OnAnimEvent { get; set;}

		[Ordinal(8)] [RED("onGameplayEvent")] 		public CName OnGameplayEvent { get; set;}

		[Ordinal(9)] [RED("shouldComplete")] 		public CBool ShouldComplete { get; set;}

		public CBTTaskPlaySyncAnimDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlaySyncAnimDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}