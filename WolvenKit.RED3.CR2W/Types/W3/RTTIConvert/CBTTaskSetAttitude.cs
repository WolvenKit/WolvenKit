using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetAttitude : IBehTreeTask
	{
		[Ordinal(1)] [RED("towardsActionTarget")] 		public CBool TowardsActionTarget { get; set;}

		[Ordinal(2)] [RED("attitude")] 		public CEnum<EAIAttitude> Attitude { get; set;}

		[Ordinal(3)] [RED("currentAttitude")] 		public CEnum<EAIAttitude> CurrentAttitude { get; set;}

		[Ordinal(4)] [RED("sender")] 		public CHandle<CActor> Sender { get; set;}

		[Ordinal(5)] [RED("petard")] 		public CHandle<W3Petard> Petard { get; set;}

		[Ordinal(6)] [RED("reactionDataStorage")] 		public CHandle<CAIStorageReactionData> ReactionDataStorage { get; set;}

		public CBTTaskSetAttitude(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}