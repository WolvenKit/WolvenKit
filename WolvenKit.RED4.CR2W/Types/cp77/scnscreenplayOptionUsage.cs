using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnscreenplayOptionUsage : CVariable
	{
		[Ordinal(0)] [RED("playerGenderMask")] public scnGenderMask PlayerGenderMask { get; set; }

		public scnscreenplayOptionUsage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
