using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameRenderGameplayEffectsManagerSaveData : ISerializable
	{
		[Ordinal(0)]  [RED("cyberspacePixelsortEnabled")] public CBool CyberspacePixelsortEnabled { get; set; }
		[Ordinal(1)]  [RED("cyberspacePixelsortParams")] public gameCyberspacePixelsortEffectParams CyberspacePixelsortParams { get; set; }
		[Ordinal(2)]  [RED("enforceScreenSpaceReflectionsUberQuality")] public CBool EnforceScreenSpaceReflectionsUberQuality { get; set; }

		public gameRenderGameplayEffectsManagerSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
