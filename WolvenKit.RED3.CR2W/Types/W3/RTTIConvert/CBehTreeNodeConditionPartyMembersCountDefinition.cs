using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionPartyMembersCountDefinition : CBehTreeNodeConditionDefinition
	{
		[Ordinal(1)] [RED("partyMemberName")] 		public CBehTreeValCName PartyMemberName { get; set;}

		[Ordinal(2)] [RED("count")] 		public CBehTreeValInt Count { get; set;}

		public CBehTreeNodeConditionPartyMembersCountDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}