using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAcousticsEmitterMetadata : audioEmitterMetadata
	{
		private CBool _obstuctionEnabled;
		private CBool _occlusionEnabled;
		private CBool _repositioningEnabled;
		private CFloat _obstructionFadeTime;
		private CBool _enableOutdoorness;
		private CBool _postDopplerFactor;
		private CName _dopplerParameter;
		private CFloat _ignoreOcclusionRadius;
		private CBool _elevateSource;

		[Ordinal(1)] 
		[RED("obstuctionEnabled")] 
		public CBool ObstuctionEnabled
		{
			get => GetProperty(ref _obstuctionEnabled);
			set => SetProperty(ref _obstuctionEnabled, value);
		}

		[Ordinal(2)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetProperty(ref _occlusionEnabled);
			set => SetProperty(ref _occlusionEnabled, value);
		}

		[Ordinal(3)] 
		[RED("repositioningEnabled")] 
		public CBool RepositioningEnabled
		{
			get => GetProperty(ref _repositioningEnabled);
			set => SetProperty(ref _repositioningEnabled, value);
		}

		[Ordinal(4)] 
		[RED("obstructionFadeTime")] 
		public CFloat ObstructionFadeTime
		{
			get => GetProperty(ref _obstructionFadeTime);
			set => SetProperty(ref _obstructionFadeTime, value);
		}

		[Ordinal(5)] 
		[RED("enableOutdoorness")] 
		public CBool EnableOutdoorness
		{
			get => GetProperty(ref _enableOutdoorness);
			set => SetProperty(ref _enableOutdoorness, value);
		}

		[Ordinal(6)] 
		[RED("postDopplerFactor")] 
		public CBool PostDopplerFactor
		{
			get => GetProperty(ref _postDopplerFactor);
			set => SetProperty(ref _postDopplerFactor, value);
		}

		[Ordinal(7)] 
		[RED("dopplerParameter")] 
		public CName DopplerParameter
		{
			get => GetProperty(ref _dopplerParameter);
			set => SetProperty(ref _dopplerParameter, value);
		}

		[Ordinal(8)] 
		[RED("ignoreOcclusionRadius")] 
		public CFloat IgnoreOcclusionRadius
		{
			get => GetProperty(ref _ignoreOcclusionRadius);
			set => SetProperty(ref _ignoreOcclusionRadius, value);
		}

		[Ordinal(9)] 
		[RED("elevateSource")] 
		public CBool ElevateSource
		{
			get => GetProperty(ref _elevateSource);
			set => SetProperty(ref _elevateSource, value);
		}

		public audioAcousticsEmitterMetadata()
		{
			_obstructionFadeTime = 0.200000F;
		}
	}
}
