using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpSplinePlacementProvider_Distance : cpSplinePlacementProvider
	{
		[Ordinal(0)] [RED("distance")] public CFloat Distance { get; set; }

		public cpSplinePlacementProvider_Distance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
