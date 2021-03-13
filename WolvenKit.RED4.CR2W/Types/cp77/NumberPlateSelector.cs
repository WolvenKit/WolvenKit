using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NumberPlateSelector : LCDScreenSelector
	{
		[Ordinal(4)] [RED("recordID")] public TweakDBID RecordID { get; set; }

		public NumberPlateSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
