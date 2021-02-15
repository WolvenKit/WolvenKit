using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerModule : HUDModule
	{
		[Ordinal(3)] [RED("activeScans")] public CArray<CHandle<ScanInstance>> ActiveScans { get; set; }

		public ScannerModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
