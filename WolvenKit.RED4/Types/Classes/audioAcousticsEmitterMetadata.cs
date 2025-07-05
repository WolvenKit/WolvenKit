using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAcousticsEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("obstuctionEnabled")] 
		public CBool ObstuctionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("repositioningEnabled")] 
		public CBool RepositioningEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("obstructionFadeTime")] 
		public CFloat ObstructionFadeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("enableOutdoorness")] 
		public CBool EnableOutdoorness
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("postDopplerFactor")] 
		public CBool PostDopplerFactor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("dopplerParameter")] 
		public CName DopplerParameter
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("ignoreOcclusionRadius")] 
		public CFloat IgnoreOcclusionRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("elevateSource")] 
		public CBool ElevateSource
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("leakingFloorHack")] 
		public CBool LeakingFloorHack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioAcousticsEmitterMetadata()
		{
			ObstructionFadeTime = 0.200000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
