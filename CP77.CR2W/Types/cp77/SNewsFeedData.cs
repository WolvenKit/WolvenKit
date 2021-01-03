using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SNewsFeedData : CVariable
	{
		[Ordinal(0)]  [RED("elements")] public CArray<SNewsFeedElementData> Elements { get; set; }
		[Ordinal(1)]  [RED("interval")] public CFloat Interval { get; set; }

		public SNewsFeedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
