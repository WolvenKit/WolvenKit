using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeChoiceDefinition : IBehTreeNodeCompositeDefinition
	{
		[RED("useScoring")] 		public CBool UseScoring { get; set;}

		[RED("selectRandom")] 		public CBool SelectRandom { get; set;}

		[RED("forwardChildrenCompletness")] 		public CBool ForwardChildrenCompletness { get; set;}

		public CBehTreeNodeChoiceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeChoiceDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}