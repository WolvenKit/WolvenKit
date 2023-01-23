using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioFoliageMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("loopStartEvent")] 
		public CName LoopStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("loopStopEvent")] 
		public CName LoopStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("locomotionTotalVelocityParam")] 
		public CName LocomotionTotalVelocityParam
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("locomotionTotalVelocityThreshold")] 
		public CFloat LocomotionTotalVelocityThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("locomotionAngularVelocityMultiplier")] 
		public CFloat LocomotionAngularVelocityMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("minFoliageMeshVolumeThreshold")] 
		public CFloat MinFoliageMeshVolumeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("maxFoliageMeshHeight")] 
		public CFloat MaxFoliageMeshHeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("playerInsideRequiredPercentage")] 
		public CFloat PlayerInsideRequiredPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("foliageMaterials")] 
		public CHandle<audioAudioFoliageMaterialDictionary> FoliageMaterials
		{
			get => GetPropertyValue<CHandle<audioAudioFoliageMaterialDictionary>>();
			set => SetPropertyValue<CHandle<audioAudioFoliageMaterialDictionary>>(value);
		}

		public audioAudioFoliageMetadata()
		{
			LocomotionTotalVelocityThreshold = 5.000000F;
			LocomotionAngularVelocityMultiplier = 1.000000F;
			MinFoliageMeshVolumeThreshold = 5.000000F;
			MaxFoliageMeshHeight = 7.000000F;
			PlayerInsideRequiredPercentage = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
