using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ElectricLight : Device
	{
		[Ordinal(0)]  [RED("lightComponents")] public CArray<CHandle<gameLightComponent>> LightComponents { get; set; }
		[Ordinal(1)]  [RED("lightDefinitions")] public CArray<gamedataLightPreset> LightDefinitions { get; set; }

		public ElectricLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
