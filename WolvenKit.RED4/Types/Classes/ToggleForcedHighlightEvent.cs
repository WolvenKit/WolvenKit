using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleForcedHighlightEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("highlightData")] 
		public CHandle<HighlightEditableData> HighlightData
		{
			get => GetPropertyValue<CHandle<HighlightEditableData>>();
			set => SetPropertyValue<CHandle<HighlightEditableData>>(value);
		}

		[Ordinal(2)] 
		[RED("operation")] 
		public CEnum<EToggleOperationType> Operation
		{
			get => GetPropertyValue<CEnum<EToggleOperationType>>();
			set => SetPropertyValue<CEnum<EToggleOperationType>>(value);
		}

		public ToggleForcedHighlightEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
