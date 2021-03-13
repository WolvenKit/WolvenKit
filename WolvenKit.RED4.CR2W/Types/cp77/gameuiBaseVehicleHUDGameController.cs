using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseVehicleHUDGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("mounted")] public CBool Mounted { get; set; }

		public gameuiBaseVehicleHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
