using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDynamicDecal : effectTrackItem
	{
		[Ordinal(0)]  [RED("additionalRotation")] public CFloat AdditionalRotation { get; set; }
		[Ordinal(1)]  [RED("fadeInTime")] public CFloat FadeInTime { get; set; }
		[Ordinal(2)]  [RED("fadeOutTime")] public CFloat FadeOutTime { get; set; }
		[Ordinal(3)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(4)]  [RED("material")] public rRef<IMaterial> Material { get; set; }
		[Ordinal(5)]  [RED("randomRotation")] public CBool RandomRotation { get; set; }
		[Ordinal(6)]  [RED("width")] public CFloat Width { get; set; }

		public effectTrackItemDynamicDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
