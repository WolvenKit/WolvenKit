using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerMask : CMaterialParameter
	{
		[Ordinal(2)] [RED("mask")] public rRef<Multilayer_Mask> Mask { get; set; }

		public CMaterialParameterMultilayerMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
