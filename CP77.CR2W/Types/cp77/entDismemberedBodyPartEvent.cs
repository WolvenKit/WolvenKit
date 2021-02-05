using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entDismemberedBodyPartEvent : redEvent
	{
		[Ordinal(0)]  [RED("bones", lignas(8) StaticArray<CNam, 32)] public alignas(8) StaticArray<CName> Bones { get; set; }

		public entDismemberedBodyPartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
