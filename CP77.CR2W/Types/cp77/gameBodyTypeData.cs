using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameBodyTypeData : CVariable
	{
		[Ordinal(0)] [RED("rigHash")] public CUInt64 RigHash { get; set; }
		[Ordinal(1)] [RED("animsetHashes")] public CArray<CUInt64> AnimsetHashes { get; set; }
		[Ordinal(2)] [RED("overrides")] public CArray<gameAnimsetOverrideData> Overrides { get; set; }

		public gameBodyTypeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
