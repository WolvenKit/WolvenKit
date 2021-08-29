using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IceMachineControllerPS : VendingMachineControllerPS
	{
		private TweakDBID _vendorTweakID;
		private IceMachineSFX _iceMachineSFX;

		[Ordinal(112)] 
		[RED("vendorTweakID")] 
		public TweakDBID VendorTweakID
		{
			get => GetProperty(ref _vendorTweakID);
			set => SetProperty(ref _vendorTweakID, value);
		}

		[Ordinal(113)] 
		[RED("iceMachineSFX")] 
		public IceMachineSFX IceMachineSFX
		{
			get => GetProperty(ref _iceMachineSFX);
			set => SetProperty(ref _iceMachineSFX, value);
		}
	}
}
