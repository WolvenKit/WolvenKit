using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModuleSpawnedCallbackData : IScriptable
	{
		[Ordinal(0)]  [RED("moduleName")] public CName ModuleName { get; set; }

		public ItemTooltipModuleSpawnedCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
