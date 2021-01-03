using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimProfileData_RootItem : ISerializable
	{
		[Ordinal(0)]  [RED("children")] public CArray<CHandle<animAnimProfilerData_TreeItem>> Children { get; set; }
		[Ordinal(1)]  [RED("timeMS")] public CFloat TimeMS { get; set; }

		public animAnimProfileData_RootItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
