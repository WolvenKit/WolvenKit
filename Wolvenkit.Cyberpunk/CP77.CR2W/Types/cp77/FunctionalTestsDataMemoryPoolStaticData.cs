using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FunctionalTestsDataMemoryPoolStaticData : ISerializable
	{
		[Ordinal(0)]  [RED("budget")] public CInt64 Budget { get; set; }
		[Ordinal(1)]  [RED("children")] public CArray<CString> Children { get; set; }
		[Ordinal(2)]  [RED("childrenBudget")] public CInt64 ChildrenBudget { get; set; }
		[Ordinal(3)]  [RED("parent")] public CString Parent { get; set; }
		[Ordinal(4)]  [RED("poolName")] public CString PoolName { get; set; }

		public FunctionalTestsDataMemoryPoolStaticData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
