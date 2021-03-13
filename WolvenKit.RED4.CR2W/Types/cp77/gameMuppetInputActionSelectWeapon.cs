using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionSelectWeapon : gameIMuppetInputAction
	{
		[Ordinal(0)] [RED("wantedWeapon")] public gameItemID WantedWeapon { get; set; }

		public gameMuppetInputActionSelectWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
