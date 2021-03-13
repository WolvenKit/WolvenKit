using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsResetSingleScaleMultiplier : redEvent
	{
		[Ordinal(0)] [RED("shapeName")] public CName ShapeName { get; set; }

		public gamehitRepresentationEventsResetSingleScaleMultiplier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
