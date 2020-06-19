using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAdjustDirectionNode : CBehaviorGraphBaseNode
	{
		[RED("animDirectionChange")] 		public CFloat AnimDirectionChange { get; set;}

		[RED("updateAnimDirectionChangeFromAnimation")] 		public CBool UpdateAnimDirectionChangeFromAnimation { get; set;}

		[RED("maxDirectionDiff")] 		public CFloat MaxDirectionDiff { get; set;}

		[RED("maxOppositeDirectionDiff")] 		public CFloat MaxOppositeDirectionDiff { get; set;}

		[RED("basedOnEvent")] 		public CName BasedOnEvent { get; set;}

		[RED("basedOnEventOverrideAnimation")] 		public CBool BasedOnEventOverrideAnimation { get; set;}

		[RED("adjustmentBlendSpeed")] 		public CFloat AdjustmentBlendSpeed { get; set;}

		[RED("requestedMovementDirectionVariableName")] 		public CName RequestedMovementDirectionVariableName { get; set;}

		[RED("cachedRequestedMovementDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedMovementDirectionWSValueNode { get; set;}

		public CBehaviorGraphAdjustDirectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAdjustDirectionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}