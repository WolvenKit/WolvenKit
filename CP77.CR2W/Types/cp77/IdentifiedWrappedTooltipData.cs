using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IdentifiedWrappedTooltipData : ATooltipData
	{
		[Ordinal(0)]  [RED("data")] public CHandle<ATooltipData> Data { get; set; }
		[Ordinal(1)]  [RED("identifier")] public CName Identifier { get; set; }

		public IdentifiedWrappedTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
