using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRotationControllerNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("eventAllowRot")] 		public CName EventAllowRot { get; set;}

		[Ordinal(2)] [RED("continueUpdate")] 		public CBool ContinueUpdate { get; set;}

		[Ordinal(3)] [RED("cachedAngleVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleVariableNode { get; set;}

		[Ordinal(4)] [RED("cachedWeightVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightVariableNode { get; set;}

		public CBehaviorGraphRotationControllerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRotationControllerNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}