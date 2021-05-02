using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphDampVectorValueNode : CBehaviorGraphVectorValueNode
	{
		[Ordinal(1)] [RED("increaseSpeed")] 		public Vector IncreaseSpeed { get; set;}

		[Ordinal(2)] [RED("decreaseSpeed")] 		public Vector DecreaseSpeed { get; set;}

		[Ordinal(3)] [RED("absolute")] 		public CBool Absolute { get; set;}

		[Ordinal(4)] [RED("cachedInputNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedInputNode { get; set;}

		[Ordinal(5)] [RED("cachedIncSpeedNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedIncSpeedNode { get; set;}

		[Ordinal(6)] [RED("cachedDecSpeedNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedDecSpeedNode { get; set;}

		public CBehaviorGraphDampVectorValueNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}