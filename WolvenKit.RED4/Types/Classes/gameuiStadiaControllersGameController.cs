using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiStadiaControllersGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("stadiaControllerPage")] 
		public inkWidgetReference StadiaControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("nintendoControllerPage")] 
		public inkWidgetReference NintendoControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("durangoControllerPage")] 
		public inkWidgetReference DurangoControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("orbisControllerPage")] 
		public inkWidgetReference OrbisControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("disclaimerText")] 
		public inkWidgetReference DisclaimerText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		public gameuiStadiaControllersGameController()
		{
			StadiaControllerPage = new inkWidgetReference();
			NintendoControllerPage = new inkWidgetReference();
			DurangoControllerPage = new inkWidgetReference();
			OrbisControllerPage = new inkWidgetReference();
			DisclaimerText = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
