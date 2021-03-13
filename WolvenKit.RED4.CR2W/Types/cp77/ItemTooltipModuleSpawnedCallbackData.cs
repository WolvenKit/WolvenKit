using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModuleSpawnedCallbackData : IScriptable
	{
		[Ordinal(0)] [RED("moduleName")] public CName ModuleName { get; set; }

		public ItemTooltipModuleSpawnedCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
