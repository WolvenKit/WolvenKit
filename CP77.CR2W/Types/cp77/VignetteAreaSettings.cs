using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VignetteAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("vignetteColor")] public CColor VignetteColor { get; set; }
		[Ordinal(1)]  [RED("vignetteEnabled")] public CBool VignetteEnabled { get; set; }
		[Ordinal(2)]  [RED("vignetteExp")] public CFloat VignetteExp { get; set; }
		[Ordinal(3)]  [RED("vignetteRadius")] public CFloat VignetteRadius { get; set; }

		public VignetteAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
