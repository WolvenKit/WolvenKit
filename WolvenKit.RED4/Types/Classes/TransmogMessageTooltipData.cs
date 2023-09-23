using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TransmogMessageTooltipData : MessageTooltipData
	{
		[Ordinal(4)] 
		[RED("TransmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(5)] 
		[RED("IconPath")] 
		public CName IconPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("NoIcon")] 
		public CBool NoIcon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TransmogMessageTooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
