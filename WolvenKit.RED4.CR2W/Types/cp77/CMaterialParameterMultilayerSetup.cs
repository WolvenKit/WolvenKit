using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerSetup : CMaterialParameter
	{
		[Ordinal(2)] [RED("setup")] public rRef<Multilayer_Setup> Setup { get; set; }

		public CMaterialParameterMultilayerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
