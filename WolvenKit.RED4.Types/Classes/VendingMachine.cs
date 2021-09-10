using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingMachine : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("vendorID")] 
		public CHandle<VendorComponent> VendorID
		{
			get => GetPropertyValue<CHandle<VendorComponent>>();
			set => SetPropertyValue<CHandle<VendorComponent>>(value);
		}

		[Ordinal(98)] 
		[RED("advUiComponent")] 
		public CHandle<entIComponent> AdvUiComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(99)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(100)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		public VendingMachine()
		{
			ControllerTypeName = "VendingMachineController";
			ShortGlitchDelayID = new();
		}
	}
}
