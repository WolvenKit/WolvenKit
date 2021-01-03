using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CameraBreathing : animAnimFeature
	{
		[Ordinal(0)]  [RED("amplitudeWeight")] public CFloat AmplitudeWeight { get; set; }
		[Ordinal(1)]  [RED("dampDecreaseSpeed")] public CFloat DampDecreaseSpeed { get; set; }
		[Ordinal(2)]  [RED("dampIncreaseSpeed")] public CFloat DampIncreaseSpeed { get; set; }

		public AnimFeature_CameraBreathing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
