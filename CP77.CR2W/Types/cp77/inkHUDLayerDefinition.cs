using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkHUDLayerDefinition : inkLayerDefinition
	{
		[Ordinal(0)]  [RED("entriesResource")] public rRef<inkHudEntriesResource> EntriesResource { get; set; }

		public inkHUDLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
