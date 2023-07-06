using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestIllegalActionAreaNotification : redEvent
	{
		[Ordinal(0)] 
		[RED("revealPlayerSettings")] 
		public RevealPlayerSettings RevealPlayerSettings
		{
			get => GetPropertyValue<RevealPlayerSettings>();
			set => SetPropertyValue<RevealPlayerSettings>(value);
		}

		public QuestIllegalActionAreaNotification()
		{
			RevealPlayerSettings = new RevealPlayerSettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
