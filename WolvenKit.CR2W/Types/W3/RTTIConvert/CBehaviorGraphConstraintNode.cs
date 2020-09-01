using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNode : CBehaviorGraphNode
	{
		[Ordinal(0)] [RED("("useDampCurve")] 		public CBool UseDampCurve { get; set;}

		[Ordinal(0)] [RED("("dampCurve")] 		public CPtr<CCurve> DampCurve { get; set;}

		[Ordinal(0)] [RED("("dampTimeAxisScale")] 		public CFloat DampTimeAxisScale { get; set;}

		[Ordinal(0)] [RED("("dampTimeSpeed")] 		public CFloat DampTimeSpeed { get; set;}

		[Ordinal(0)] [RED("("useFollowCurve")] 		public CBool UseFollowCurve { get; set;}

		[Ordinal(0)] [RED("("followCurve")] 		public CPtr<CCurve> FollowCurve { get; set;}

		[Ordinal(0)] [RED("("followTimeAxisScale")] 		public CFloat FollowTimeAxisScale { get; set;}

		[Ordinal(0)] [RED("("followTimeSpeed")] 		public CFloat FollowTimeSpeed { get; set;}

		[Ordinal(0)] [RED("("targetObject")] 		public CPtr<IBehaviorConstraintObject> TargetObject { get; set;}

		[Ordinal(0)] [RED("("dampType")] 		public CEnum<EBehaviorConstraintDampType> DampType { get; set;}

		[Ordinal(0)] [RED("("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[Ordinal(0)] [RED("("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedDurationValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedDurationFollowValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationFollowValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedSpeedFollowValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedFollowValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedSpeedDampValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedDampValueNode { get; set;}

		public CBehaviorGraphConstraintNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}