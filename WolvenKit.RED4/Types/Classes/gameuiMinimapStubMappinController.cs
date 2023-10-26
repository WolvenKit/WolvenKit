using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapStubMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("regularIconContainer")] 
		public inkCompoundWidgetReference RegularIconContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("preventionVehicleIconContainer")] 
		public inkCompoundWidgetReference PreventionVehicleIconContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("stubMappin")] 
		public CWeakHandle<gamemappinsStubMappin> StubMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsStubMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsStubMappin>>(value);
		}

		[Ordinal(17)] 
		[RED("state")] 
		public CName State
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiMinimapStubMappinController()
		{
			RegularIconContainer = new inkCompoundWidgetReference();
			PreventionVehicleIconContainer = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
