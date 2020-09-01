using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorMimicLookAtConstraint : IBehaviorMimicConstraint
	{
		[Ordinal(1)] [RED("cachedTargetNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

		[Ordinal(2)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(3)] [RED("cachedControlEyesDataNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedControlEyesDataNode { get; set;}

		[Ordinal(4)] [RED("eyeHorLLeftTrack")] 		public CString EyeHorLLeftTrack { get; set;}

		[Ordinal(5)] [RED("eyeHorRLeftTrack")] 		public CString EyeHorRLeftTrack { get; set;}

		[Ordinal(6)] [RED("eyeHorLRightTrack")] 		public CString EyeHorLRightTrack { get; set;}

		[Ordinal(7)] [RED("eyeHorRRightTrack")] 		public CString EyeHorRRightTrack { get; set;}

		[Ordinal(8)] [RED("eyeVerULeftTrack")] 		public CString EyeVerULeftTrack { get; set;}

		[Ordinal(9)] [RED("eyeVerDLeftTrack")] 		public CString EyeVerDLeftTrack { get; set;}

		[Ordinal(10)] [RED("eyeVerURightTrack")] 		public CString EyeVerURightTrack { get; set;}

		[Ordinal(11)] [RED("eyeVerDRightTrack")] 		public CString EyeVerDRightTrack { get; set;}

		[Ordinal(12)] [RED("eyeLeftPlacerBone")] 		public CString EyeLeftPlacerBone { get; set;}

		[Ordinal(13)] [RED("eyeRightPlacerBone")] 		public CString EyeRightPlacerBone { get; set;}

		[Ordinal(14)] [RED("eyeHorMax")] 		public CFloat EyeHorMax { get; set;}

		[Ordinal(15)] [RED("eyeVerMin")] 		public CFloat EyeVerMin { get; set;}

		[Ordinal(16)] [RED("eyeVerMax")] 		public CFloat EyeVerMax { get; set;}

		[Ordinal(17)] [RED("eyeVerOffset")] 		public CFloat EyeVerOffset { get; set;}

		[Ordinal(18)] [RED("eyesTrackClamp")] 		public CFloat EyesTrackClamp { get; set;}

		[Ordinal(19)] [RED("dampTime")] 		public CFloat DampTime { get; set;}

		[Ordinal(20)] [RED("blinkAnimName")] 		public CName BlinkAnimName { get; set;}

		[Ordinal(21)] [RED("blinkTimeOffset")] 		public CFloat BlinkTimeOffset { get; set;}

		[Ordinal(22)] [RED("blinkSpeed")] 		public CFloat BlinkSpeed { get; set;}

		public CBehaviorMimicLookAtConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorMimicLookAtConstraint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}