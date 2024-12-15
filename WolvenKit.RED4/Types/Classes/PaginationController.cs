using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PaginationController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("paginationRoot")] 
		public inkHorizontalPanelWidgetReference PaginationRoot
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("nextArrow")] 
		public inkWidgetReference NextArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("previousArrow")] 
		public inkWidgetReference PreviousArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("paginationNumbers")] 
		public CArray<CWeakHandle<PaginationNumberController>> PaginationNumbers
		{
			get => GetPropertyValue<CArray<CWeakHandle<PaginationNumberController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<PaginationNumberController>>>(value);
		}

		[Ordinal(5)] 
		[RED("halfPaginationDisplay")] 
		public CInt32 HalfPaginationDisplay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("fullPaginationDisplay")] 
		public CInt32 FullPaginationDisplay
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PaginationController()
		{
			PaginationRoot = new inkHorizontalPanelWidgetReference();
			NextArrow = new inkWidgetReference();
			PreviousArrow = new inkWidgetReference();
			PaginationNumbers = new();
			HalfPaginationDisplay = 2;
			FullPaginationDisplay = 5;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
