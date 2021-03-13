using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScreenDefinitionPackage : CVariable
	{
		[Ordinal(0)] [RED("screenDefinition")] public CHandle<gamedataDeviceUIDefinition_Record> ScreenDefinition { get; set; }
		[Ordinal(1)] [RED("style")] public CHandle<gamedataWidgetStyle_Record> Style { get; set; }

		public ScreenDefinitionPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
