using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleBrandFilterLogicController : BaseButtonView
	{
		[Ordinal(5)] 
		[RED("brandLogo")] 
		public inkImageWidgetReference BrandLogo
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("brandText")] 
		public inkTextWidgetReference BrandText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("brand")] 
		public CName Brand
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("brandAsString")] 
		public CString BrandAsString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("state")] 
		public CEnum<EVehicleBrandState> State
		{
			get => GetPropertyValue<CEnum<EVehicleBrandState>>();
			set => SetPropertyValue<CEnum<EVehicleBrandState>>(value);
		}

		[Ordinal(10)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("styleWidget")] 
		public CWeakHandle<inkWidget> StyleWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("newOffers")] 
		public CArray<CName> NewOffers
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public VehicleBrandFilterLogicController()
		{
			BrandLogo = new inkImageWidgetReference();
			BrandText = new inkTextWidgetReference();
			NewOffers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
