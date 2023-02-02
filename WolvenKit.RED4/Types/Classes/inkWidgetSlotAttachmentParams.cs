using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetSlotAttachmentParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public CName SlotID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("useSlotLayout")] 
		public CBool UseSlotLayout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("layoutOverride")] 
		public inkWidgetLayout LayoutOverride
		{
			get => GetPropertyValue<inkWidgetLayout>();
			set => SetPropertyValue<inkWidgetLayout>(value);
		}

		public inkWidgetSlotAttachmentParams()
		{
			UseSlotLayout = true;
			LayoutOverride = new() { Padding = new(), Margin = new(), AnchorPoint = new(), SizeCoefficient = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
