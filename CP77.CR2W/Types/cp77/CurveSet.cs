using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CurveSet : CResource
	{
		[Ordinal(1)] [RED("curves")] public CArray<CurveSetEntry> Curves { get; set; }

		public CurveSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
