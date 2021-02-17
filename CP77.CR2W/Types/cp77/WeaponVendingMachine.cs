using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachine : VendingMachine
	{
		[Ordinal(97)] [RED("bigAdScreen")] public wCHandle<IWorldWidgetComponent> BigAdScreen { get; set; }

		public WeaponVendingMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
