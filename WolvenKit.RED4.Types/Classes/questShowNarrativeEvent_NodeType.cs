using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowNarrativeEvent_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("eventText")] 
		public CString EventText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("textColor")] 
		public CColor TextColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(2)] 
		[RED("durationSec")] 
		public CFloat DurationSec
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questShowNarrativeEvent_NodeType()
		{
			TextColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
