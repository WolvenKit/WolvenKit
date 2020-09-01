using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtUsingAnimationsProcessingNode : CBehaviorGraphVectorValueNode
	{
		[Ordinal(1)] [RED("("Bone name")] 		public CName Bone_name { get; set;}

		[Ordinal(2)] [RED("("Use char. rotation")] 		public CBool Use_char__rotation { get; set;}

		[Ordinal(3)] [RED("("Angle limit")] 		public Vector2 Angle_limit { get; set;}

		[Ordinal(4)] [RED("("Animation angle range")] 		public Vector2 Animation_angle_range { get; set;}

		[Ordinal(5)] [RED("("Angle to stop looking")] 		public CFloat Angle_to_stop_looking { get; set;}

		[Ordinal(6)] [RED("("Max 'Look at' speed")] 		public CFloat Max__Look_at__speed { get; set;}

		[Ordinal(7)] [RED("("'Look at' blend time")] 		public CFloat _Look_at__blend_time { get; set;}

		[Ordinal(8)] [RED("("On//Off blend time")] 		public CFloat On__Off_blend_time { get; set;}

		[Ordinal(9)] [RED("("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[Ordinal(10)] [RED("("cachedLookAtVariableNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedLookAtVariableNode { get; set;}

		[Ordinal(11)] [RED("("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(12)] [RED("("cachedLookAtBlendTimeNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLookAtBlendTimeNode { get; set;}

		public CBehaviorGraphLookAtUsingAnimationsProcessingNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphLookAtUsingAnimationsProcessingNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}