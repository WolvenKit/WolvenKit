using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerListName : SettingsSelectorControllerList
	{
		[Ordinal(0)]  [RED("currentIndex")] public CInt32 CurrentIndex { get; set; }
		[Ordinal(1)]  [RED("realValue")] public wCHandle<userSettingsVarListName> RealValue { get; set; }

		public SettingsSelectorControllerListName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
