using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphCharacterRotationNode : CBehaviorGraphBaseNode
	{
		[RED("axis")] 		public Vector Axis { get; set;}

		[RED("rotationSpeedMultiplier")] 		public CFloat RotationSpeedMultiplier { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("cachedBiasVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedBiasVariableNode { get; set;}

		[RED("cachedAngleVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleVariableNode { get; set;}

		[RED("cachedMaxAngleVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedMaxAngleVariableNode { get; set;}

		public CBehaviorGraphCharacterRotationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphCharacterRotationNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}