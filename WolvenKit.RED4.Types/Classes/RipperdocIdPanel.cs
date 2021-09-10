using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RipperdocIdPanel : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("NameLabel")] 
		public inkTextWidgetReference NameLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("MoneyLabel")] 
		public inkTextWidgetReference MoneyLabel
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public RipperdocIdPanel()
		{
			NameLabel = new();
			MoneyLabel = new();
		}
	}
}
