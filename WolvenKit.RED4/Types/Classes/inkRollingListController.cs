using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkRollingListController : inkListController
	{
		[Ordinal(6)] 
		[RED("itemsToDisplay")] 
		public CInt32 ItemsToDisplay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("convexity")] 
		public CFloat Convexity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("verticalCompression")] 
		public CFloat VerticalCompression
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("scrollTime")] 
		public CFloat ScrollTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkRollingListController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
