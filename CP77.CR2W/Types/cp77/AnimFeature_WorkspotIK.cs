using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WorkspotIK : animAnimFeature
	{
		[Ordinal(0)] [RED("rightHandPosition")] public Vector4 RightHandPosition { get; set; }
		[Ordinal(1)] [RED("leftHandPosition")] public Vector4 LeftHandPosition { get; set; }
		[Ordinal(2)] [RED("cameraPosition")] public Vector4 CameraPosition { get; set; }
		[Ordinal(3)] [RED("rightHandRotation")] public Quaternion RightHandRotation { get; set; }
		[Ordinal(4)] [RED("leftHandRotation")] public Quaternion LeftHandRotation { get; set; }
		[Ordinal(5)] [RED("cameraRotation")] public Quaternion CameraRotation { get; set; }
		[Ordinal(6)] [RED("shouldCrouch")] public CBool ShouldCrouch { get; set; }
		[Ordinal(7)] [RED("isInteractingWithDevice")] public CBool IsInteractingWithDevice { get; set; }

		public AnimFeature_WorkspotIK(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
