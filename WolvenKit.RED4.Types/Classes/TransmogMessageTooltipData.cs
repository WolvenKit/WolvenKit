using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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

		public TransmogMessageTooltipData()
		{
			TransmogItem = new();
		}
	}
}
