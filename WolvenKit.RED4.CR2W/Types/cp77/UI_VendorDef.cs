using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_VendorDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("VendorData")] public gamebbScriptID_Variant VendorData { get; set; }

		public UI_VendorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
