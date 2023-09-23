using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickhackBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("emptyMask")] 
		public inkWidgetReference EmptyMask
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("empty")] 
		public inkWidgetReference Empty
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("full")] 
		public inkWidgetReference Full
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public QuickhackBarController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
