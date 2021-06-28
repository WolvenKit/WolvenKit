using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestIllegalActionAreaNotification : redEvent
	{
		private RevealPlayerSettings _revealPlayerSettings;

		[Ordinal(0)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get => GetProperty(ref _revealPlayerSettings);
			set => SetProperty(ref _revealPlayerSettings, value);
		}

		public QuestIllegalActionAreaNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
