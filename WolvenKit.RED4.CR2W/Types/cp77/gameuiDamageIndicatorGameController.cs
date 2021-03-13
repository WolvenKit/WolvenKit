using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("maxVisibleParts")] public CUInt8 MaxVisibleParts { get; set; }

		public gameuiDamageIndicatorGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
