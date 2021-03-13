using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerListName : SettingsSelectorControllerList
	{
		[Ordinal(20)] [RED("realValue")] public wCHandle<userSettingsVarListName> RealValue { get; set; }
		[Ordinal(21)] [RED("currentIndex")] public CInt32 CurrentIndex { get; set; }

		public SettingsSelectorControllerListName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
