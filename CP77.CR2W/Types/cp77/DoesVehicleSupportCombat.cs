using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoesVehicleSupportCombat : AIVehicleConditionAbstract
	{
		public DoesVehicleSupportCombat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
