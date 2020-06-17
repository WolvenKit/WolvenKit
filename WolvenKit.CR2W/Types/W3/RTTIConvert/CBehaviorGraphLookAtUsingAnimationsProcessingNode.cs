using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtUsingAnimationsProcessingNode : CBehaviorGraphVectorValueNode
	{
		[RED("Bone name")] 		public CName Bone_name { get; set;}

		[RED("Use char. rotation")] 		public CBool Use_char__rotation { get; set;}

		[RED("Angle limit")] 		public Vector2 Angle_limit { get; set;}

		[RED("Animation angle range")] 		public Vector2 Animation_angle_range { get; set;}

		[RED("Angle to stop looking")] 		public CFloat Angle_to_stop_looking { get; set;}

		[RED("Max 'Look at' speed")] 		public CFloat Max__Look_at__speed { get; set;}

		[RED("Look at' blend time")] 		public CFloat Look_at__blend_time { get; set;}

		[RED("On//Off blend time")] 		public CFloat On__Off_blend_time { get; set;}

		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[RED("cachedLookAtVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedLookAtVariableNode { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("cachedLookAtBlendTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLookAtBlendTimeNode { get; set;}

		public CBehaviorGraphLookAtUsingAnimationsProcessingNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphLookAtUsingAnimationsProcessingNode(cr2w);

	}
}