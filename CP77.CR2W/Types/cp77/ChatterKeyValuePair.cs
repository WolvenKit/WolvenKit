using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChatterKeyValuePair : CVariable
	{
		[Ordinal(0)] [RED("Key")] public CRUID Key { get; set; }
		[Ordinal(1)] [RED("Value")] public CHandle<ChatterLineLogicController> Value { get; set; }
		[Ordinal(2)] [RED("Owner")] public wCHandle<gameObject> Owner { get; set; }

		public ChatterKeyValuePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
