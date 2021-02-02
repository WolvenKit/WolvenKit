using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiNarrativePlateData : CVariable
	{
		[Ordinal(0)]  [RED("text")] public CString Text { get; set; }
		[Ordinal(1)]  [RED("caption")] public CString Caption { get; set; }
		[Ordinal(2)]  [RED("entity")] public wCHandle<gameObject> Entity { get; set; }

		public gameuiNarrativePlateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
