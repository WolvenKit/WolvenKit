using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class garmentSmoothingParams : CVariable
	{
		[Ordinal(0)]  [RED("smoothingExponent")] public CFloat SmoothingExponent { get; set; }
		[Ordinal(1)]  [RED("smoothingNumNeighbours")] public CUInt32 SmoothingNumNeighbours { get; set; }
		[Ordinal(2)]  [RED("smoothingRadiusInCM")] public CFloat SmoothingRadiusInCM { get; set; }
		[Ordinal(3)]  [RED("smoothingStrength")] public CFloat SmoothingStrength { get; set; }

		public garmentSmoothingParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
