using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributesSkills : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("attributes")] public CyberwareAttributes_ContainersStruct Attributes { get; set; }
		[Ordinal(3)] [RED("resistances")] public CyberwareAttributes_ResistancesStruct Resistances { get; set; }
		[Ordinal(4)] [RED("levelUpPoints")] public inkTextWidgetReference LevelUpPoints { get; set; }
		[Ordinal(5)] [RED("uiBlackboard")] public CHandle<gameIBlackboard> UiBlackboard { get; set; }
		[Ordinal(6)] [RED("playerPuppet")] public wCHandle<PlayerPuppet> PlayerPuppet { get; set; }
		[Ordinal(7)] [RED("devPoints")] public CInt32 DevPoints { get; set; }

		public CyberwareAttributesSkills(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
