using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DiodeControlComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("affectedLights")] public CArray<CName> AffectedLights { get; set; }
		[Ordinal(1)]  [RED("lightsState")] public CBool LightsState { get; set; }
		[Ordinal(2)]  [RED("primaryLightPreset")] public DiodeLightPreset PrimaryLightPreset { get; set; }
		[Ordinal(3)]  [RED("secondaryLightPreset")] public DiodeLightPreset SecondaryLightPreset { get; set; }
		[Ordinal(4)]  [RED("secondaryPresetActive")] public CBool SecondaryPresetActive { get; set; }
		[Ordinal(5)]  [RED("secondaryPresetRemovalID")] public gameDelayID SecondaryPresetRemovalID { get; set; }

		public DiodeControlComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
