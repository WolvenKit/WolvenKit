using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BlurAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("circularBlurRadius")] public CFloat CircularBlurRadius { get; set; }

		public BlurAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
