using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighwaySignSelector : StreetSignSelector
	{
		[Ordinal(1)] [RED("recordID")] public TweakDBID RecordID { get; set; }

		public HighwaySignSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
