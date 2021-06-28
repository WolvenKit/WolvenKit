using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphValueInterpolationNode : CBehaviorGraphValueBaseNode
	{
		[Ordinal(1)] [RED("x1")] 		public CFloat X1 { get; set;}

		[Ordinal(2)] [RED("y1")] 		public CFloat Y1 { get; set;}

		[Ordinal(3)] [RED("x2")] 		public CFloat X2 { get; set;}

		[Ordinal(4)] [RED("y2")] 		public CFloat Y2 { get; set;}

		public CBehaviorGraphValueInterpolationNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}