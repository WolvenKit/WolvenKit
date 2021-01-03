using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerListName : SettingsSelectorControllerList
	{
		[Ordinal(0)]  [RED("currentIndex")] public CInt32 CurrentIndex { get; set; }
		[Ordinal(1)]  [RED("realValue")] public wCHandle<userSettingsVarListName> RealValue { get; set; }

		public SettingsSelectorControllerListName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
