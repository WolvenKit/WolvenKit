using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintGroupData : CVariable
	{
		[Ordinal(0)] [RED("iconReference")] public TweakDBID IconReference { get; set; }
		[Ordinal(1)] [RED("localizedTitle")] public CString LocalizedTitle { get; set; }
		[Ordinal(2)] [RED("localizedDescription")] public CString LocalizedDescription { get; set; }
		[Ordinal(3)] [RED("sortingPriority")] public CInt32 SortingPriority { get; set; }

		public gameuiInputHintGroupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
