using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StealthMappinGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("controller")] public wCHandle<gameuiStealthMappinController> Controller { get; set; }
		[Ordinal(3)] [RED("ownerNPC")] public wCHandle<NPCPuppet> OwnerNPC { get; set; }

		public StealthMappinGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
