using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckAttitudes : IBehTreeTask
	{
		[Ordinal(1)] [RED("onlyHelpActorsFromTheSameAttidueGroup")] 		public CBool OnlyHelpActorsFromTheSameAttidueGroup { get; set;}

		[Ordinal(2)] [RED("useReactionTarget")] 		public CBool UseReactionTarget { get; set;}

		[Ordinal(3)] [RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(4)] [RED("sender")] 		public CHandle<CActor> Sender { get; set;}

		[Ordinal(5)] [RED("sendersTarget")] 		public CHandle<CActor> SendersTarget { get; set;}

		[Ordinal(6)] [RED("attitudeToSender")] 		public CEnum<EAIAttitude> AttitudeToSender { get; set;}

		[Ordinal(7)] [RED("attitudeToSendersTarget")] 		public CEnum<EAIAttitude> AttitudeToSendersTarget { get; set;}

		[Ordinal(8)] [RED("senderAttitudeGroup")] 		public CName SenderAttitudeGroup { get; set;}

		[Ordinal(9)] [RED("sendersTargetAttitudeGroup")] 		public CName SendersTargetAttitudeGroup { get; set;}

		[Ordinal(10)] [RED("ownerAttitudeGroup")] 		public CName OwnerAttitudeGroup { get; set;}

		[Ordinal(11)] [RED("actorToChangeAttitude")] 		public CHandle<CActor> ActorToChangeAttitude { get; set;}

		[Ordinal(12)] [RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		public CBTTaskCheckAttitudes(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCheckAttitudes(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}