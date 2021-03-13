using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TreeItem : ISerializable
	{
		[Ordinal(0)] [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)] [RED("exclusiveTimeMS")] public CFloat ExclusiveTimeMS { get; set; }
		[Ordinal(2)] [RED("inclusiveTimeMS")] public CFloat InclusiveTimeMS { get; set; }
		[Ordinal(3)] [RED("children")] public CArray<CHandle<animAnimProfilerData_TreeItem>> Children { get; set; }

		public animAnimProfilerData_TreeItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
