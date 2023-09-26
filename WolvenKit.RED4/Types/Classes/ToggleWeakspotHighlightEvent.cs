using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleWeakspotHighlightEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public CEnum<EToggleOperationType> Operation
		{
			get => GetPropertyValue<CEnum<EToggleOperationType>>();
			set => SetPropertyValue<CEnum<EToggleOperationType>>(value);
		}

		public ToggleWeakspotHighlightEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
