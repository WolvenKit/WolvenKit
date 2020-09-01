using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetAttitude : IBehTreeTask
	{
		[Ordinal(0)] [RED("("towardsActionTarget")] 		public CBool TowardsActionTarget { get; set;}

		[Ordinal(0)] [RED("("attitude")] 		public CEnum<EAIAttitude> Attitude { get; set;}

		[Ordinal(0)] [RED("("currentAttitude")] 		public CEnum<EAIAttitude> CurrentAttitude { get; set;}

		[Ordinal(0)] [RED("("sender")] 		public CHandle<CActor> Sender { get; set;}

		[Ordinal(0)] [RED("("petard")] 		public CHandle<W3Petard> Petard { get; set;}

		[Ordinal(0)] [RED("("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		public CBTTaskSetAttitude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetAttitude(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}