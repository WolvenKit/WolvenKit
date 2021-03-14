using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterScalar : CMaterialParameter
	{
		[Ordinal(2)] [RED("scalar")] public CFloat Scalar { get; set; }
		[Ordinal(3)] [RED("min")] public CFloat Min { get; set; }
		[Ordinal(4)] [RED("max")] public CFloat Max { get; set; }

		public CMaterialParameterScalar(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
