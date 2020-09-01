using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckAttitudes : IBehTreeTask
	{
		[Ordinal(0)] [RED("("onlyHelpActorsFromTheSameAttidueGroup")] 		public CBool OnlyHelpActorsFromTheSameAttidueGroup { get; set;}

		[Ordinal(0)] [RED("("useReactionTarget")] 		public CBool UseReactionTarget { get; set;}

		[Ordinal(0)] [RED("("owner")] 		public CHandle<CActor> Owner { get; set;}

		[Ordinal(0)] [RED("("sender")] 		public CHandle<CActor> Sender { get; set;}

		[Ordinal(0)] [RED("("sendersTarget")] 		public CHandle<CActor> SendersTarget { get; set;}

		[Ordinal(0)] [RED("("attitudeToSender")] 		public CEnum<EAIAttitude> AttitudeToSender { get; set;}

		[Ordinal(0)] [RED("("attitudeToSendersTarget")] 		public CEnum<EAIAttitude> AttitudeToSendersTarget { get; set;}

		[Ordinal(0)] [RED("("senderAttitudeGroup")] 		public CName SenderAttitudeGroup { get; set;}

		[Ordinal(0)] [RED("("sendersTargetAttitudeGroup")] 		public CName SendersTargetAttitudeGroup { get; set;}

		[Ordinal(0)] [RED("("ownerAttitudeGroup")] 		public CName OwnerAttitudeGroup { get; set;}

		[Ordinal(0)] [RED("("actorToChangeAttitude")] 		public CHandle<CActor> ActorToChangeAttitude { get; set;}

		[Ordinal(0)] [RED("("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		public CBTTaskCheckAttitudes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCheckAttitudes(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}