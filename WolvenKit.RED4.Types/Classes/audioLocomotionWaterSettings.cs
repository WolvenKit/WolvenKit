using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionWaterSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("defaultLegVfx")] 
		public CResourceAsyncReference<CResource> DefaultLegVfx
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(2)] 
		[RED("locomotionStatesLegVfx")] 
		public CHandle<audioLocomotionStateVfxDictionary> LocomotionStatesLegVfx
		{
			get => GetPropertyValue<CHandle<audioLocomotionStateVfxDictionary>>();
			set => SetPropertyValue<CHandle<audioLocomotionStateVfxDictionary>>(value);
		}

		[Ordinal(3)] 
		[RED("customActionLegVfx")] 
		public CHandle<audioLocomotionCustomActionVfxDictionary> CustomActionLegVfx
		{
			get => GetPropertyValue<CHandle<audioLocomotionCustomActionVfxDictionary>>();
			set => SetPropertyValue<CHandle<audioLocomotionCustomActionVfxDictionary>>(value);
		}

		[Ordinal(4)] 
		[RED("minSpeedToApplyImpulses")] 
		public CFloat MinSpeedToApplyImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("minHeelDepthToApplyImpulses")] 
		public CFloat MinHeelDepthToApplyImpulses
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("shallowWaterDepth")] 
		public CFloat ShallowWaterDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("intermediateWaterDepth")] 
		public CFloat IntermediateWaterDepth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("shallowSettings")] 
		public audioLocomotionWaterContextSettings ShallowSettings
		{
			get => GetPropertyValue<audioLocomotionWaterContextSettings>();
			set => SetPropertyValue<audioLocomotionWaterContextSettings>(value);
		}

		[Ordinal(9)] 
		[RED("intermediateSettings")] 
		public audioLocomotionWaterContextSettings IntermediateSettings
		{
			get => GetPropertyValue<audioLocomotionWaterContextSettings>();
			set => SetPropertyValue<audioLocomotionWaterContextSettings>(value);
		}

		[Ordinal(10)] 
		[RED("deepSettings")] 
		public audioLocomotionWaterContextSettings DeepSettings
		{
			get => GetPropertyValue<audioLocomotionWaterContextSettings>();
			set => SetPropertyValue<audioLocomotionWaterContextSettings>(value);
		}

		public audioLocomotionWaterSettings()
		{
			MinSpeedToApplyImpulses = 0.050000F;
			MinHeelDepthToApplyImpulses = -0.050000F;
			ShallowWaterDepth = 0.200000F;
			IntermediateWaterDepth = 0.700000F;
			ShallowSettings = new() { MinDistanceBetweenImpulsesSquared = 0.010000F, ImpulseStrength = 0.002500F, ImpulseMinRadius = 0.040000F, ImpulseMaxRadius = 0.050000F };
			IntermediateSettings = new() { MinDistanceBetweenImpulsesSquared = 0.010000F, ImpulseStrength = 0.002500F, ImpulseMinRadius = 0.040000F, ImpulseMaxRadius = 0.050000F };
			DeepSettings = new() { MinDistanceBetweenImpulsesSquared = 0.010000F, ImpulseStrength = 0.002500F, ImpulseMinRadius = 0.040000F, ImpulseMaxRadius = 0.050000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
