using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphCharacterRotationNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("axis")] 		public Vector Axis { get; set;}

		[Ordinal(2)] [RED("rotationSpeedMultiplier")] 		public CFloat RotationSpeedMultiplier { get; set;}

		[Ordinal(3)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(4)] [RED("cachedBiasVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedBiasVariableNode { get; set;}

		[Ordinal(5)] [RED("cachedAngleVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleVariableNode { get; set;}

		[Ordinal(6)] [RED("cachedMaxAngleVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedMaxAngleVariableNode { get; set;}

		public CBehaviorGraphCharacterRotationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphCharacterRotationNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}