using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MotionBlurAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("strength")] public CFloat Strength { get; set; }

		public MotionBlurAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
