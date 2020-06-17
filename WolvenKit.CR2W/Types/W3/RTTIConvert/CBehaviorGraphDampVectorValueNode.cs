using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphDampVectorValueNode : CBehaviorGraphVectorValueNode
	{
		[RED("increaseSpeed")] 		public Vector IncreaseSpeed { get; set;}

		[RED("decreaseSpeed")] 		public Vector DecreaseSpeed { get; set;}

		[RED("absolute")] 		public CBool Absolute { get; set;}

		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedInputNode { get; set;}

		[RED("cachedIncSpeedNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedIncSpeedNode { get; set;}

		[RED("cachedDecSpeedNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedDecSpeedNode { get; set;}

		public CBehaviorGraphDampVectorValueNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphDampVectorValueNode(cr2w);

	}
}