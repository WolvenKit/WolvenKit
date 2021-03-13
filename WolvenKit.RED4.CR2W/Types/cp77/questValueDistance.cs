using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questValueDistance : questIDistance
	{
		[Ordinal(0)] [RED("distanceValue")] public CFloat DistanceValue { get; set; }

		public questValueDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
