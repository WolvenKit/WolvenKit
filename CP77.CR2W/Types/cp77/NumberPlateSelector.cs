using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NumberPlateSelector : LCDScreenSelector
	{
		[Ordinal(4)] [RED("recordID")] public TweakDBID RecordID { get; set; }

		public NumberPlateSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
