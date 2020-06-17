using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicLookAtSystemNode : CBehaviorGraphBaseMimicNode
	{
		[RED("cachedTargetNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("cachedLevelVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedLevelVariableNode { get; set;}

		[RED("eyeHorLeftTrack")] 		public CString EyeHorLeftTrack { get; set;}

		[RED("eyeVerLeftTrack")] 		public CString EyeVerLeftTrack { get; set;}

		[RED("eyeHorRightTrack")] 		public CString EyeHorRightTrack { get; set;}

		[RED("eyeVerRightTrack")] 		public CString EyeVerRightTrack { get; set;}

		[RED("eyeLeftPlacerBone")] 		public CString EyeLeftPlacerBone { get; set;}

		[RED("eyeRightPlacerBone")] 		public CString EyeRightPlacerBone { get; set;}

		[RED("eyeHorMax")] 		public CFloat EyeHorMax { get; set;}

		[RED("eyeVerMax")] 		public CFloat EyeVerMax { get; set;}

		[RED("dampTime")] 		public CFloat DampTime { get; set;}

		[RED("dampCurve")] 		public CPtr<CCurve> DampCurve { get; set;}

		public CBehaviorGraphMimicLookAtSystemNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMimicLookAtSystemNode(cr2w);

	}
}