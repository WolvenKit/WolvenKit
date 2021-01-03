using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemsPoolCachedData : IScriptable
	{
		[Ordinal(0)]  [RED("tooltipData")] public CHandle<ATooltipData> TooltipData { get; set; }

		public ItemsPoolCachedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
