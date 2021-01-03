using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_EquipmentDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("itemEquipped")] public gamebbScriptID_Variant ItemEquipped { get; set; }
		[Ordinal(1)]  [RED("lastModifiedArea")] public gamebbScriptID_Variant LastModifiedArea { get; set; }

		public UI_EquipmentDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
