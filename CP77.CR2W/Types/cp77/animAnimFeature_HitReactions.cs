using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_HitReactions : animAnimFeature
	{
		[Ordinal(0)]  [RED("hitBodyPart")] public CInt32 HitBodyPart { get; set; }
		[Ordinal(1)]  [RED("hitDirection")] public Vector4 HitDirection { get; set; }
		[Ordinal(2)]  [RED("hitIntensity")] public CFloat HitIntensity { get; set; }
		[Ordinal(3)]  [RED("hitType")] public CInt32 HitType { get; set; }

		public animAnimFeature_HitReactions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
