using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioEventMetadata : ISerializable
	{
		private CUInt32 _wwiseId;
		private CFloat _maxAttenuation;
		private CFloat _minDuration;
		private CFloat _maxDuration;
		private CBool _isLooping;
		private CArray<CName> _stopActionEvents;
		private CArray<CName> _tags;

		[Ordinal(0)] 
		[RED("wwiseId")] 
		public CUInt32 WwiseId
		{
			get => GetProperty(ref _wwiseId);
			set => SetProperty(ref _wwiseId, value);
		}

		[Ordinal(1)] 
		[RED("maxAttenuation")] 
		public CFloat MaxAttenuation
		{
			get => GetProperty(ref _maxAttenuation);
			set => SetProperty(ref _maxAttenuation, value);
		}

		[Ordinal(2)] 
		[RED("minDuration")] 
		public CFloat MinDuration
		{
			get => GetProperty(ref _minDuration);
			set => SetProperty(ref _minDuration, value);
		}

		[Ordinal(3)] 
		[RED("maxDuration")] 
		public CFloat MaxDuration
		{
			get => GetProperty(ref _maxDuration);
			set => SetProperty(ref _maxDuration, value);
		}

		[Ordinal(4)] 
		[RED("isLooping")] 
		public CBool IsLooping
		{
			get => GetProperty(ref _isLooping);
			set => SetProperty(ref _isLooping, value);
		}

		[Ordinal(5)] 
		[RED("stopActionEvents")] 
		public CArray<CName> StopActionEvents
		{
			get => GetProperty(ref _stopActionEvents);
			set => SetProperty(ref _stopActionEvents, value);
		}

		[Ordinal(6)] 
		[RED("tags")] 
		public CArray<CName> Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		public audioAudioEventMetadata()
		{
			_wwiseId = 2166136261;
		}
	}
}
