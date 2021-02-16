using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UpdateWeaponChargeEvent : redEvent
	{
		[Ordinal(0)] [RED("newValue")] public CFloat NewValue { get; set; }
		[Ordinal(1)] [RED("oldValue")] public CFloat OldValue { get; set; }

		public UpdateWeaponChargeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
