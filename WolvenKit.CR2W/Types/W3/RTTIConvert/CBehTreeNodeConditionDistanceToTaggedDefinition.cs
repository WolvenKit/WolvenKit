using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeConditionDistanceToTaggedDefinition : CBehTreeNodeConditionDefinition
	{
		[Ordinal(1)] [RED("minDistance")] 		public CBehTreeValFloat MinDistance { get; set;}

		[Ordinal(2)] [RED("maxDistance")] 		public CBehTreeValFloat MaxDistance { get; set;}

		[Ordinal(3)] [RED("checkRotation")] 		public CBool CheckRotation { get; set;}

		[Ordinal(4)] [RED("tag")] 		public CBehTreeValCName Tag { get; set;}

		[Ordinal(5)] [RED("allowActivationWhenNoTarget")] 		public CBool AllowActivationWhenNoTarget { get; set;}

		public CBehTreeNodeConditionDistanceToTaggedDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeConditionDistanceToTaggedDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}