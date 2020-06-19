using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNode : CBehaviorGraphNode
	{
		[RED("useDampCurve")] 		public CBool UseDampCurve { get; set;}

		[RED("dampCurve")] 		public CPtr<CCurve> DampCurve { get; set;}

		[RED("dampTimeAxisScale")] 		public CFloat DampTimeAxisScale { get; set;}

		[RED("dampTimeSpeed")] 		public CFloat DampTimeSpeed { get; set;}

		[RED("useFollowCurve")] 		public CBool UseFollowCurve { get; set;}

		[RED("followCurve")] 		public CPtr<CCurve> FollowCurve { get; set;}

		[RED("followTimeAxisScale")] 		public CFloat FollowTimeAxisScale { get; set;}

		[RED("followTimeSpeed")] 		public CFloat FollowTimeSpeed { get; set;}

		[RED("targetObject")] 		public CPtr<IBehaviorConstraintObject> TargetObject { get; set;}

		[RED("dampType")] 		public CEnum<EBehaviorConstraintDampType> DampType { get; set;}

		[RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[RED("cachedDurationValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationValueNode { get; set;}

		[RED("cachedDurationFollowValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedDurationFollowValueNode { get; set;}

		[RED("cachedSpeedFollowValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedFollowValueNode { get; set;}

		[RED("cachedSpeedDampValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedSpeedDampValueNode { get; set;}

		public CBehaviorGraphConstraintNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}