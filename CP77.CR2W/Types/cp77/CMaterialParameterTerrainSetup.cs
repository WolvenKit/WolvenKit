using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterTerrainSetup : CMaterialParameter
	{
		[Ordinal(0)]  [RED("setup")] public rRef<CTerrainSetup> Setup { get; set; }

		public CMaterialParameterTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
