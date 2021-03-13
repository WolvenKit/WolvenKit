using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimsetOverrideData : CVariable
	{
		[Ordinal(0)] [RED("animsetHash")] public CUInt64 AnimsetHash { get; set; }
		[Ordinal(1)] [RED("variables")] public CArray<CName> Variables { get; set; }

		public gameAnimsetOverrideData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
