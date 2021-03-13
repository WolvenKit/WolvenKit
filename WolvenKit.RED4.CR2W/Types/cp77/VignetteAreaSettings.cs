using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VignetteAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("vignetteEnabled")] public CBool VignetteEnabled { get; set; }
		[Ordinal(3)] [RED("vignetteRadius")] public CFloat VignetteRadius { get; set; }
		[Ordinal(4)] [RED("vignetteExp")] public CFloat VignetteExp { get; set; }
		[Ordinal(5)] [RED("vignetteColor")] public CColor VignetteColor { get; set; }

		public VignetteAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
