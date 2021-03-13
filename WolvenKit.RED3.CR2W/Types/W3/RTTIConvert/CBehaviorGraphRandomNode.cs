using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRandomNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("weights", 2,0)] 		public CArray<CFloat> Weights { get; set;}

		[Ordinal(2)] [RED("cooldowns", 2,0)] 		public CArray<CFloat> Cooldowns { get; set;}

		[Ordinal(3)] [RED("maxStartAnimTime", 2,0)] 		public CArray<CFloat> MaxStartAnimTime { get; set;}

		[Ordinal(4)] [RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		public CBehaviorGraphRandomNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRandomNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}