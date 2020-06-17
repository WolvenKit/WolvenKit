using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPositionControllerBaseNode : CBehaviorGraphBaseNode
	{
		[RED("useHeading")] 		public CBool UseHeading { get; set;}

		[RED("cachedWeightVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightVariableNode { get; set;}

		[RED("cachedShiftVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedShiftVariableNode { get; set;}

		public CBehaviorGraphPositionControllerBaseNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphPositionControllerBaseNode(cr2w);

	}
}