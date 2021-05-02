using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeSelectorDefinition : IBehTreeNodeCompositeDefinition
	{
		[Ordinal(1)] [RED("checkFrequency")] 		public CFloat CheckFrequency { get; set;}

		[Ordinal(2)] [RED("useScoring")] 		public CBool UseScoring { get; set;}

		[Ordinal(3)] [RED("selectRandom")] 		public CBool SelectRandom { get; set;}

		[Ordinal(4)] [RED("forwardChildrenCompletness")] 		public CBool ForwardChildrenCompletness { get; set;}

		public CBehTreeNodeSelectorDefinition(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeSelectorDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}