using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioWeaponSettingsGroup : audioAudioMetadata
	{
		[Ordinal(1)] [RED("playerSettings")] public CName PlayerSettings { get; set; }
		[Ordinal(2)] [RED("playerSilenced")] public CName PlayerSilenced { get; set; }
		[Ordinal(3)] [RED("npcSettings")] public CName NpcSettings { get; set; }
		[Ordinal(4)] [RED("npcSilenced")] public CName NpcSilenced { get; set; }

		public audioWeaponSettingsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
