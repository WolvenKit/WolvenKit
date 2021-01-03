using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PresetAction : ActionBool
	{
		[Ordinal(0)]  [RED("preset")] public CHandle<SmartHousePreset> Preset { get; set; }

		public PresetAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
