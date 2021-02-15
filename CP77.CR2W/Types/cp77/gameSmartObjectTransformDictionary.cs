using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformDictionary : ISerializable
	{
		[Ordinal(0)] [RED("transforms")] public CArray<gameSmartObjectTransformDictionaryTransformEntry> Transforms { get; set; }

		public gameSmartObjectTransformDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
