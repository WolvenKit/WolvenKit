using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyclableRadialSlot : WeaponRadialSlot
	{
		[Ordinal(0)]  [RED("canCycle")] public CBool CanCycle { get; set; }
		[Ordinal(1)]  [RED("hotkey")] public CEnum<gameEHotkey> Hotkey { get; set; }
		[Ordinal(2)]  [RED("isCycling")] public CBool IsCycling { get; set; }
		[Ordinal(3)]  [RED("leftArrowEmpty")] public inkWidgetReference LeftArrowEmpty { get; set; }
		[Ordinal(4)]  [RED("leftArrowFull")] public inkWidgetReference LeftArrowFull { get; set; }
		[Ordinal(5)]  [RED("rightArrowEmpty")] public inkWidgetReference RightArrowEmpty { get; set; }
		[Ordinal(6)]  [RED("rightArrowFull")] public inkWidgetReference RightArrowFull { get; set; }
		[Ordinal(7)]  [RED("wasCyclingRight")] public CBool WasCyclingRight { get; set; }

		public CyclableRadialSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
