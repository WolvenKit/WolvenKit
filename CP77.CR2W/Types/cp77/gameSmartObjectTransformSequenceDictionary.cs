using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformSequenceDictionary : ISerializable
	{
		[Ordinal(0)] [RED("sequences")] public CArray<gameSmartObjectTransformSequenceDictionaryEntry> Sequences { get; set; }

		public gameSmartObjectTransformSequenceDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
