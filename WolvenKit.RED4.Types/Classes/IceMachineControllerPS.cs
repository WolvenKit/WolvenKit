using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			TweakDBRecord = 78736419072;
			TweakDBDescriptionRecord = 132501907971;
			IceMachineSFX = new() { IceFalls = "dev_ice_machine_ice_cube_falls", Processing = "dev_vending_machine_processing" };
		}
	}
}
