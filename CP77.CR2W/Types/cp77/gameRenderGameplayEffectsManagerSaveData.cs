using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameRenderGameplayEffectsManagerSaveData : ISerializable
	{
		[Ordinal(0)] [RED("cyberspacePixelsortParams")] public gameCyberspacePixelsortEffectParams CyberspacePixelsortParams { get; set; }
		[Ordinal(1)] [RED("cyberspacePixelsortEnabled")] public CBool CyberspacePixelsortEnabled { get; set; }
		[Ordinal(2)] [RED("enforceScreenSpaceReflectionsUberQuality")] public CBool EnforceScreenSpaceReflectionsUberQuality { get; set; }

		public gameRenderGameplayEffectsManagerSaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
