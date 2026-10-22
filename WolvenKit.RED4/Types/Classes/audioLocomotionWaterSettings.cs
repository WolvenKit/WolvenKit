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

		[Ordinal(11)] 
		[RED("minHeelDepthToSpawnFallFx")] 
		public CFloat MinHeelDepthToSpawnFallFx
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("minDownwardSpeedForRegularFall")] 
		public CFloat MinDownwardSpeedForRegularFall
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("minDownwardSpeedForFastFall")] 
		public CFloat MinDownwardSpeedForFastFall
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("regularFallVfx")] 
		public CResourceAsyncReference<CResource> RegularFallVfx
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(15)] 
		[RED("regularFallEvent")] 
		public CName RegularFallEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("fastFallVfx")] 
		public CResourceAsyncReference<CResource> FastFallVfx
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(17)] 
		[RED("fastFallEvent")] 
		public CName FastFallEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioLocomotionWaterSettings()
		{
			LocomotionStatesLegVfx = new audioLocomotionStateVfxDictionary { EntryType = new audioLocomotionStateVfxDictionaryItem() };
			CustomActionLegVfx = new audioLocomotionCustomActionVfxDictionary { EntryType = new audioLocomotionCustomActionVfxDictionaryItem() };
			MinSpeedToApplyImpulses = 0.050000F;
			MinHeelDepthToApplyImpulses = -0.050000F;
			ShallowWaterDepth = 0.200000F;
			IntermediateWaterDepth = 0.700000F;
			ShallowSettings = new audioLocomotionWaterContextSettings();
			IntermediateSettings = new audioLocomotionWaterContextSettings();
			DeepSettings = new audioLocomotionWaterContextSettings();
			MinHeelDepthToSpawnFallFx = 0.500000F;
			MinDownwardSpeedForRegularFall = 2.500000F;
			MinDownwardSpeedForFastFall = 9.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
