using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestListHeaderClicked : redEvent
	{
		[Ordinal(0)] 
		[RED("questType")] 
		public CInt32 QuestType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public QuestListHeaderClicked()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
