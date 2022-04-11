using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestCombatActionAreaNotification : redEvent
	{
		[Ordinal(0)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get => GetPropertyValue<RevealPlayerSettings>();
			set => SetPropertyValue<RevealPlayerSettings>(value);
		}

		public QuestCombatActionAreaNotification()
		{
			RevealPlayerSettings = new();
		}
	}
}
