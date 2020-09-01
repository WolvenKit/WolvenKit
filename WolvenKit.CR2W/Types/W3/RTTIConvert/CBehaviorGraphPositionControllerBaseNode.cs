using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPositionControllerBaseNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("("useHeading")] 		public CBool UseHeading { get; set;}

		[Ordinal(0)] [RED("("cachedWeightVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightVariableNode { get; set;}

		[Ordinal(0)] [RED("("cachedShiftVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedShiftVariableNode { get; set;}

		public CBehaviorGraphPositionControllerBaseNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphPositionControllerBaseNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}