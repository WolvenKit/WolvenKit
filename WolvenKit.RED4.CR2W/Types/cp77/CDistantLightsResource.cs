using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CDistantLightsResource : resStreamedResource
	{
		[Ordinal(1)] [RED("data")] public DataBuffer Data { get; set; }

		public CDistantLightsResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
