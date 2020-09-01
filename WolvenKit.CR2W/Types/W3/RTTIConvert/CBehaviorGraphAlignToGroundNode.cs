using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAlignToGroundNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("groundNormalBlendTime")] 		public CFloat GroundNormalBlendTime { get; set;}

		[Ordinal(2)] [RED("additionalOffset")] 		public CFloat AdditionalOffset { get; set;}

		[Ordinal(3)] [RED("eatEvent")] 		public CBool EatEvent { get; set;}

		public CBehaviorGraphAlignToGroundNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAlignToGroundNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}