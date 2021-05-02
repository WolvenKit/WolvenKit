using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphGameplayAdditiveNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("level_0")] 		public SGameplayAdditiveLevel Level_0 { get; set;}

		[Ordinal(2)] [RED("level_1")] 		public SGameplayAdditiveLevel Level_1 { get; set;}

		[Ordinal(3)] [RED("gatherEvents")] 		public CBool GatherEvents { get; set;}

		[Ordinal(4)] [RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		public CBehaviorGraphGameplayAdditiveNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}