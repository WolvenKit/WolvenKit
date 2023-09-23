using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IceMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(115)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(116)] 
		[RED("iceMachineSFX")] 
		public IceMachineSFX IceMachineSFX
		{
			get => GetPropertyValue<IceMachineSFX>();
			set => SetPropertyValue<IceMachineSFX>(value);
		}

		public IceMachineControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
