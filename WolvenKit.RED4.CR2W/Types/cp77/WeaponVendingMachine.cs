using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachine : VendingMachine
	{
		[Ordinal(97)] [RED("bigAdScreen")] public wCHandle<IWorldWidgetComponent> BigAdScreen { get; set; }

		public WeaponVendingMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
