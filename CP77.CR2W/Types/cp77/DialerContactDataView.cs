using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DialerContactDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)]  [RED("compareBuilder")] public CHandle<CompareBuilder> CompareBuilder { get; set; }

		public DialerContactDataView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
