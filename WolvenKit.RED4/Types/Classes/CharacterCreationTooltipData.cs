using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CharacterCreationTooltipData : MessageTooltipData
	{
		[Ordinal(4)] 
		[RED("attribiuteLevel")] 
		public CString AttribiuteLevel
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("maxedOrMinimumLabelText")] 
		public CString MaxedOrMinimumLabelText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public CharacterCreationTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
