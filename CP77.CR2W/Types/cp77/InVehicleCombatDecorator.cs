using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InVehicleCombatDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)]  [RED("targetToChase")] public wCHandle<gameObject> TargetToChase { get; set; }

		public InVehicleCombatDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
