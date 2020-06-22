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
		[RED("onlyHelpActorsFromTheSameAttidueGroup")] 		public CBool OnlyHelpActorsFromTheSameAttidueGroup { get; set;}

		[RED("useReactionTarget")] 		public CBool UseReactionTarget { get; set;}

		[RED("owner")] 		public CHandle<CActor> Owner { get; set;}

		[RED("sender")] 		public CHandle<CActor> Sender { get; set;}

		[RED("sendersTarget")] 		public CHandle<CActor> SendersTarget { get; set;}

		[RED("attitudeToSender")] 		public CEnum<EAIAttitude> AttitudeToSender { get; set;}

		[RED("attitudeToSendersTarget")] 		public CEnum<EAIAttitude> AttitudeToSendersTarget { get; set;}

		[RED("senderAttitudeGroup")] 		public CName SenderAttitudeGroup { get; set;}

		[RED("sendersTargetAttitudeGroup")] 		public CName SendersTargetAttitudeGroup { get; set;}

		[RED("ownerAttitudeGroup")] 		public CName OwnerAttitudeGroup { get; set;}

		[RED("actorToChangeAttitude")] 		public CHandle<CActor> ActorToChangeAttitude { get; set;}

		[RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		public CBTTaskCheckAttitudes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCheckAttitudes(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}