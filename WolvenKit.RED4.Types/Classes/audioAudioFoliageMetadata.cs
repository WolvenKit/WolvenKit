using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioFoliageMetadata : audioAudioMetadata
	{
		private CName _loopStartEvent;
		private CName _loopStopEvent;
		private CName _locomotionTotalVelocityParam;
		private CFloat _locomotionTotalVelocityThreshold;
		private CFloat _locomotionAngularVelocityMultiplier;
		private CFloat _minFoliageMeshVolumeThreshold;
		private CFloat _maxFoliageMeshHeight;
		private CFloat _playerInsideRequiredPercentage;
		private CHandle<audioAudioFoliageMaterialDictionary> _foliageMaterials;

		[Ordinal(1)] 
		[RED("loopStartEvent")] 
		public CName LoopStartEvent
		{
			get => GetProperty(ref _loopStartEvent);
			set => SetProperty(ref _loopStartEvent, value);
		}

		[Ordinal(2)] 
		[RED("loopStopEvent")] 
		public CName LoopStopEvent
		{
			get => GetProperty(ref _loopStopEvent);
			set => SetProperty(ref _loopStopEvent, value);
		}

		[Ordinal(3)] 
		[RED("locomotionTotalVelocityParam")] 
		public CName LocomotionTotalVelocityParam
		{
			get => GetProperty(ref _locomotionTotalVelocityParam);
			set => SetProperty(ref _locomotionTotalVelocityParam, value);
		}

		[Ordinal(4)] 
		[RED("locomotionTotalVelocityThreshold")] 
		public CFloat LocomotionTotalVelocityThreshold
		{
			get => GetProperty(ref _locomotionTotalVelocityThreshold);
			set => SetProperty(ref _locomotionTotalVelocityThreshold, value);
		}

		[Ordinal(5)] 
		[RED("locomotionAngularVelocityMultiplier")] 
		public CFloat LocomotionAngularVelocityMultiplier
		{
			get => GetProperty(ref _locomotionAngularVelocityMultiplier);
			set => SetProperty(ref _locomotionAngularVelocityMultiplier, value);
		}

		[Ordinal(6)] 
		[RED("minFoliageMeshVolumeThreshold")] 
		public CFloat MinFoliageMeshVolumeThreshold
		{
			get => GetProperty(ref _minFoliageMeshVolumeThreshold);
			set => SetProperty(ref _minFoliageMeshVolumeThreshold, value);
		}

		[Ordinal(7)] 
		[RED("maxFoliageMeshHeight")] 
		public CFloat MaxFoliageMeshHeight
		{
			get => GetProperty(ref _maxFoliageMeshHeight);
			set => SetProperty(ref _maxFoliageMeshHeight, value);
		}

		[Ordinal(8)] 
		[RED("playerInsideRequiredPercentage")] 
		public CFloat PlayerInsideRequiredPercentage
		{
			get => GetProperty(ref _playerInsideRequiredPercentage);
			set => SetProperty(ref _playerInsideRequiredPercentage, value);
		}

		[Ordinal(9)] 
		[RED("foliageMaterials")] 
		public CHandle<audioAudioFoliageMaterialDictionary> FoliageMaterials
		{
			get => GetProperty(ref _foliageMaterials);
			set => SetProperty(ref _foliageMaterials, value);
		}
	}
}
