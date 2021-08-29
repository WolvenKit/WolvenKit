using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Fridge : InteractiveDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;
		private CName _factOnDoorOpened;

		[Ordinal(97)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		[Ordinal(98)] 
		[RED("factOnDoorOpened")] 
		public CName FactOnDoorOpened
		{
			get => GetProperty(ref _factOnDoorOpened);
			set => SetProperty(ref _factOnDoorOpened, value);
		}
	}
}
