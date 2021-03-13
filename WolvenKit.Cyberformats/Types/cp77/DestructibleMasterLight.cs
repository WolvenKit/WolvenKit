using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DestructibleMasterLight : DestructibleMasterDevice
	{
		[Ordinal(93)] [RED("lightComponents")] public CArray<CHandle<gameLightComponent>> LightComponents { get; set; }
		[Ordinal(94)] [RED("lightDefinitions")] public CArray<gamedataLightPreset> LightDefinitions { get; set; }

		public DestructibleMasterLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
