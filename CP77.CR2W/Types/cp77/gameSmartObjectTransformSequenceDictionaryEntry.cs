using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformSequenceDictionaryEntry : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CUInt8 Id { get; set; }
		[Ordinal(1)]  [RED("sequence")] public CArray<CUInt16> Sequence { get; set; }

		public gameSmartObjectTransformSequenceDictionaryEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
