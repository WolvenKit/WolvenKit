using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerSetup : CMaterialParameter
	{
		[Ordinal(0)]  [RED("setup")] public rRef<Multilayer_Setup> Setup { get; set; }

		public CMaterialParameterMultilayerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
