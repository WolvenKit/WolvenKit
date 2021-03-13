using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimProfileData_RootItem : ISerializable
	{
		[Ordinal(0)] [RED("timeMS")] public CFloat TimeMS { get; set; }
		[Ordinal(1)] [RED("children")] public CArray<CHandle<animAnimProfilerData_TreeItem>> Children { get; set; }

		public animAnimProfileData_RootItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
