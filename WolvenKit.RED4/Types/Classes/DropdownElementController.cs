using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DropdownElementController : BaseButtonView
	{
		[Ordinal(2)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("frame")] 
		public inkWidgetReference Frame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<DropdownItemData> Data
		{
			get => GetPropertyValue<CHandle<DropdownItemData>>();
			set => SetPropertyValue<CHandle<DropdownItemData>>(value);
		}

		[Ordinal(7)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DropdownElementController()
		{
			Text = new inkTextWidgetReference();
			Arrow = new inkImageWidgetReference();
			Frame = new inkWidgetReference();
			ContentContainer = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
