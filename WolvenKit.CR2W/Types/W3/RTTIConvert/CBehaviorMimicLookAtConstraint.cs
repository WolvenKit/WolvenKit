using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorMimicLookAtConstraint : IBehaviorMimicConstraint
	{
		[RED("cachedTargetNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("cachedControlEyesDataNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedControlEyesDataNode { get; set;}

		[RED("eyeHorLLeftTrack")] 		public CString EyeHorLLeftTrack { get; set;}

		[RED("eyeHorRLeftTrack")] 		public CString EyeHorRLeftTrack { get; set;}

		[RED("eyeHorLRightTrack")] 		public CString EyeHorLRightTrack { get; set;}

		[RED("eyeHorRRightTrack")] 		public CString EyeHorRRightTrack { get; set;}

		[RED("eyeVerULeftTrack")] 		public CString EyeVerULeftTrack { get; set;}

		[RED("eyeVerDLeftTrack")] 		public CString EyeVerDLeftTrack { get; set;}

		[RED("eyeVerURightTrack")] 		public CString EyeVerURightTrack { get; set;}

		[RED("eyeVerDRightTrack")] 		public CString EyeVerDRightTrack { get; set;}

		[RED("eyeLeftPlacerBone")] 		public CString EyeLeftPlacerBone { get; set;}

		[RED("eyeRightPlacerBone")] 		public CString EyeRightPlacerBone { get; set;}

		[RED("eyeHorMax")] 		public CFloat EyeHorMax { get; set;}

		[RED("eyeVerMin")] 		public CFloat EyeVerMin { get; set;}

		[RED("eyeVerMax")] 		public CFloat EyeVerMax { get; set;}

		[RED("eyeVerOffset")] 		public CFloat EyeVerOffset { get; set;}

		[RED("eyesTrackClamp")] 		public CFloat EyesTrackClamp { get; set;}

		[RED("dampTime")] 		public CFloat DampTime { get; set;}

		[RED("blinkAnimName")] 		public CName BlinkAnimName { get; set;}

		[RED("blinkTimeOffset")] 		public CFloat BlinkTimeOffset { get; set;}

		[RED("blinkSpeed")] 		public CFloat BlinkSpeed { get; set;}

		public CBehaviorMimicLookAtConstraint(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorMimicLookAtConstraint(cr2w);

	}
}