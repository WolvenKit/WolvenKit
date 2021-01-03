using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectPropertyDictionary : ISerializable
	{
		[Ordinal(0)]  [RED("properties")] public CArray<gameSmartObjectPropertyDictionaryPropertyEntry> Properties { get; set; }

		public gameSmartObjectPropertyDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
