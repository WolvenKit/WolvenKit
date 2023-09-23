using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FakePhoneContactItemVirtualController : PhoneContactItemVirtualController
	{
		[Ordinal(36)] 
		[RED("dots")] 
		public inkWidgetReference Dots
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public FakePhoneContactItemVirtualController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
