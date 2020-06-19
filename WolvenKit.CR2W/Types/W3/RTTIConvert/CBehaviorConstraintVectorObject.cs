using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorConstraintVectorObject : IBehaviorConstraintObject
	{
		[RED("cachedTargetPositionNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPositionNode { get; set;}

		[RED("cachedTargetRotationNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetRotationNode { get; set;}

		public CBehaviorConstraintVectorObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorConstraintVectorObject(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}