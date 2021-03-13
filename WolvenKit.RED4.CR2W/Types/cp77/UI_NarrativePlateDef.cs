using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NarrativePlateDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("PlateData")] public gamebbScriptID_Variant PlateData { get; set; }

		public UI_NarrativePlateDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
