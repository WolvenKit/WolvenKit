using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterGradient : CMaterialParameter
	{
		[Ordinal(2)] [RED("gradient")] public rRef<CGradient> Gradient { get; set; }

		public CMaterialParameterGradient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
