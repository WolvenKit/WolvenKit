using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questMappinState_ConditionType : questIJournalConditionType
	{
		[Ordinal(0)] 
		[RED("mappinPath")] 
		public CHandle<gameJournalPath> MappinPath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questMappinState_ConditionType()
		{
			Active = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
