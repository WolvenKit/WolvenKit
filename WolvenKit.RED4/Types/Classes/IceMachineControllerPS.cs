using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IceMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(112)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(113)] 
		[RED("iceMachineSFX")] 
		public IceMachineSFX IceMachineSFX
		{
			get => GetPropertyValue<IceMachineSFX>();
			set => SetPropertyValue<IceMachineSFX>(value);
		}

		public IceMachineControllerPS()
		{
			DeviceName = "LocKey#1637";
			TweakDBRecord = "Devices.IceMachine";
			TweakDBDescriptionRecord = 132501907971;
			IceMachineSFX = new IceMachineSFX { IceFalls = "dev_ice_machine_ice_cube_falls", Processing = "dev_vending_machine_processing" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
