using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkBlackboardDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("Attempt")] public gamebbScriptID_Int32 Attempt { get; set; }
		[Ordinal(1)]  [RED("DeviceID")] public gamebbScriptID_EntityID DeviceID { get; set; }
		[Ordinal(2)]  [RED("DevicesCount")] public gamebbScriptID_Int32 DevicesCount { get; set; }
		[Ordinal(3)]  [RED("ItemBreach")] public gamebbScriptID_Bool ItemBreach { get; set; }
		[Ordinal(4)]  [RED("MinigameDef")] public gamebbScriptID_Variant MinigameDef { get; set; }
		[Ordinal(5)]  [RED("NetworkName")] public gamebbScriptID_String NetworkName { get; set; }
		[Ordinal(6)]  [RED("NetworkTDBID")] public gamebbScriptID_Variant NetworkTDBID { get; set; }
		[Ordinal(7)]  [RED("OfficerBreach")] public gamebbScriptID_Bool OfficerBreach { get; set; }
		[Ordinal(8)]  [RED("RemoteBreach")] public gamebbScriptID_Bool RemoteBreach { get; set; }
		[Ordinal(9)]  [RED("SelectedMinigameDef")] public gamebbScriptID_Variant SelectedMinigameDef { get; set; }
		[Ordinal(10)]  [RED("SuicideBreach")] public gamebbScriptID_Bool SuicideBreach { get; set; }

		public NetworkBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
