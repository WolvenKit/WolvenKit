using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DestructibleMasterLight : DestructibleMasterDevice
	{
		[Ordinal(0)]  [RED("lightComponents")] public CArray<CHandle<gameLightComponent>> LightComponents { get; set; }
		[Ordinal(1)]  [RED("lightDefinitions")] public CArray<gamedataLightPreset> LightDefinitions { get; set; }

		public DestructibleMasterLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
