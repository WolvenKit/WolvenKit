using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameBodyTypeData : CVariable
	{
		[Ordinal(0)]  [RED("animsetHashes")] public CArray<CUInt64> AnimsetHashes { get; set; }
		[Ordinal(1)]  [RED("overrides")] public CArray<gameAnimsetOverrideData> Overrides { get; set; }
		[Ordinal(2)]  [RED("rigHash")] public CUInt64 RigHash { get; set; }

		public gameBodyTypeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
