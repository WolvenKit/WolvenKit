using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TransmogMessageDescTooltip : MessageTooltip
	{
		[Ordinal(5)] 
		[RED("titleWrapper")] 
		public inkWidgetReference TitleWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("descriptionLine")] 
		public inkWidgetReference DescriptionLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public TransmogMessageDescTooltip()
		{
			TitleWrapper = new();
			DescriptionWrapper = new();
			DescriptionLine = new();
			Icon = new();
		}
	}
}
