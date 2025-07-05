using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questJournalCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIJournalConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIJournalConditionType>>();
			set => SetPropertyValue<CHandle<questIJournalConditionType>>(value);
		}

		public questJournalCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
