using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendingMachine : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("vendorID")] 
		public CHandle<VendorComponent> VendorID
		{
			get => GetPropertyValue<CHandle<VendorComponent>>();
			set => SetPropertyValue<CHandle<VendorComponent>>(value);
		}

		[Ordinal(95)] 
		[RED("advUiComponent")] 
		public CHandle<entIComponent> AdvUiComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(96)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(97)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public VendingMachine()
		{
			ControllerTypeName = "VendingMachineController";
			ShortGlitchDelayID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
