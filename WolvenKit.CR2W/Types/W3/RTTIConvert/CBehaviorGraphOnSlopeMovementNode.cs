using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphOnSlopeMovementNode : CBehaviorGraphValueNode
	{
		[RED("angles", 2,0)] 		public CArray<CFloat> Angles { get; set;}

		[RED("slopeBlendTime")] 		public CFloat SlopeBlendTime { get; set;}

		[RED("slopeMaxBlendSpeed")] 		public CFloat SlopeMaxBlendSpeed { get; set;}

		[RED("neverReachBorderValues")] 		public CBool NeverReachBorderValues { get; set;}

		public CBehaviorGraphOnSlopeMovementNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphOnSlopeMovementNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}