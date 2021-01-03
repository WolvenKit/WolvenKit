using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UpdateWeaponChargeEvent : redEvent
	{
		[Ordinal(0)]  [RED("newValue")] public CFloat NewValue { get; set; }
		[Ordinal(1)]  [RED("oldValue")] public CFloat OldValue { get; set; }

		public UpdateWeaponChargeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
