using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGridItem : CVariable
	{
		[Ordinal(0)]  [RED("rootIdx")] public CUInt32 RootIdx { get; set; }

		public inkGridItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
