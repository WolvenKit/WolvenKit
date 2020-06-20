using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAimingWithIKNode : CBehaviorGraphNode
	{
		[RED("aimingBaseBoneName")] 		public CName AimingBaseBoneName { get; set;}

		[RED("ik")] 		public STwoBonesIKSolverData Ik { get; set;}

		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[RED("cachedBaseInputNode")] 		public CPtr<CBehaviorGraphNode> CachedBaseInputNode { get; set;}

		[RED("cachedLookAtTargetDirMSInputNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedLookAtTargetDirMSInputNode { get; set;}

		public CBehaviorGraphAimingWithIKNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAimingWithIKNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}