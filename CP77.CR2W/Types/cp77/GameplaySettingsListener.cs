using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsListener : userSettingsVarListener
	{
		[Ordinal(0)]  [RED("additiveCameraGroupName")] public CString AdditiveCameraGroupName { get; set; }
		[Ordinal(1)]  [RED("additiveCameraMovements")] public CFloat AdditiveCameraMovements { get; set; }
		[Ordinal(2)]  [RED("diffSettingsGroup")] public CHandle<userSettingsGroup> DiffSettingsGroup { get; set; }
		[Ordinal(3)]  [RED("difficultyPath")] public CString DifficultyPath { get; set; }
		[Ordinal(4)]  [RED("fastForwardGroupName")] public CString FastForwardGroupName { get; set; }
		[Ordinal(5)]  [RED("isFastForwardByLine")] public CBool IsFastForwardByLine { get; set; }
		[Ordinal(6)]  [RED("miscPath")] public CString MiscPath { get; set; }
		[Ordinal(7)]  [RED("miscSettingsGroup")] public CHandle<userSettingsGroup> MiscSettingsGroup { get; set; }
		[Ordinal(8)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(9)]  [RED("userSettings")] public CHandle<userSettingsUserSettings> UserSettings { get; set; }

		public GameplaySettingsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
