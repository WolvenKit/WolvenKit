using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerCover : animAnimFeature
	{
		[Ordinal(0)]  [RED("autoCoverActivationFrame")] public CBool AutoCoverActivationFrame { get; set; }
		[Ordinal(1)]  [RED("cameraOffsetAmount")] public CFloat CameraOffsetAmount { get; set; }
		[Ordinal(2)]  [RED("cameraPositionMS")] public Vector4 CameraPositionMS { get; set; }
		[Ordinal(3)]  [RED("coverState")] public CInt32 CoverState { get; set; }
		[Ordinal(4)]  [RED("leanAmount")] public CFloat LeanAmount { get; set; }

		public animAnimFeature_PlayerCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
