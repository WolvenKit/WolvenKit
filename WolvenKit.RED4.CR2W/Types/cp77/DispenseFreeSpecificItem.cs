using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DispenseFreeSpecificItem : redEvent
	{
		[Ordinal(0)] [RED("item")] public TweakDBID Item { get; set; }

		public DispenseFreeSpecificItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
