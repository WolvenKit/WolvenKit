using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Landing : animAnimFeature
	{
		[Ordinal(0)]  [RED("impactSpeed")] public CFloat ImpactSpeed { get; set; }
		[Ordinal(1)]  [RED("type")] public CInt32 Type { get; set; }

		public AnimFeature_Landing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
