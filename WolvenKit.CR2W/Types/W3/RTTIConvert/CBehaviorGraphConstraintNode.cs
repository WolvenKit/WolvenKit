using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("useDampCurve")] 		public CBool UseDampCurve { get; set;}

		[Ordinal(2)] [RED("dampCurve")] 		public CPtr<CCurve> DampCurve { get; set;}

		[Ordinal(3)] [RED("dampTimeAxisScale")] 		public CFloat DampTimeAxisScale { get; set;}

		[Ordinal(4)] [RED("dampTimeSpeed")] 		public CFloat DampTimeSpeed { get; set;}

		[Ordinal(5)] [RED("useFollowCurve")] 		public CBool UseFollowCurve { get; set;}

		[Ordinal(6)] [RED("followCurve")] 		public CPtr<CCurve> FollowCurve { get; set;}

		[Ordinal(7)] [RED("followTimeAxisScale")] 		public CFloat FollowTimeAxisScale { get; set;}

		[Ordinal(8)] [RED("followTimeSpeed")] 		public CFloat FollowTimeSpeed { get; set;}

		[Ordinal(9)] [RED("targetObject")] 		public CPtr<IBehaviorConstraintObject> TargetObject { get; set;}

		[Ordinal(10)] [RED("dampType")] 		public CEnum<EBehaviorConstraintDampType> DampType { get; set;}

		[Ordinal(11)] [RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[Ordinal(12)] [RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[Ordinal(13)] [RED("cachedDurationValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationValueNode { get; set;}

		[Ordinal(14)] [RED("cachedDurationFollowValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationFollowValueNode { get; set;}

		[Ordinal(15)] [RED("cachedSpeedFollowValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedFollowValueNode { get; set;}

		[Ordinal(16)] [RED("cachedSpeedDampValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedDampValueNode { get; set;}

		public CBehaviorGraphConstraintNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}