using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DiodeControlComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("affectedLights")] public CArray<CName> AffectedLights { get; set; }
		[Ordinal(6)] [RED("lightsState")] public CBool LightsState { get; set; }
		[Ordinal(7)] [RED("primaryLightPreset")] public DiodeLightPreset PrimaryLightPreset { get; set; }
		[Ordinal(8)] [RED("secondaryLightPreset")] public DiodeLightPreset SecondaryLightPreset { get; set; }
		[Ordinal(9)] [RED("secondaryPresetActive")] public CBool SecondaryPresetActive { get; set; }
		[Ordinal(10)] [RED("secondaryPresetRemovalID")] public gameDelayID SecondaryPresetRemovalID { get; set; }

		public DiodeControlComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
