using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CrossingLightSetup : RedBaseClass
	{
		private CName _greenLightSFX;
		private CName _redLightSFX;

		[Ordinal(0)] 
		[RED("greenLightSFX")] 
		public CName GreenLightSFX
		{
			get => GetProperty(ref _greenLightSFX);
			set => SetProperty(ref _greenLightSFX, value);
		}

		[Ordinal(1)] 
		[RED("redLightSFX")] 
		public CName RedLightSFX
		{
			get => GetProperty(ref _redLightSFX);
			set => SetProperty(ref _redLightSFX, value);
		}
	}
}
