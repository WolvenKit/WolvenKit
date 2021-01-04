using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("gameplaySettingsListener")] public CHandle<GameplaySettingsListener> GameplaySettingsListener { get; set; }
		[Ordinal(1)]  [RED("wasEverJohnny")] public CBool WasEverJohnny { get; set; }

		public GameplaySettingsSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
