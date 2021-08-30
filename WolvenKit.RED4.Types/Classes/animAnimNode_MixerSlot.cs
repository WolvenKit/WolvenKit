using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_MixerSlot : animAnimNode_OnePoseInput
	{
		private CUInt16 _maxNormalAnimEntriesCount;
		private CUInt16 _maxAdditiveAnimEntriesCount;
		private CUInt16 _maxOverrideAnimEntriesCount;

		[Ordinal(12)] 
		[RED("maxNormalAnimEntriesCount")] 
		public CUInt16 MaxNormalAnimEntriesCount
		{
			get => GetProperty(ref _maxNormalAnimEntriesCount);
			set => SetProperty(ref _maxNormalAnimEntriesCount, value);
		}

		[Ordinal(13)] 
		[RED("maxAdditiveAnimEntriesCount")] 
		public CUInt16 MaxAdditiveAnimEntriesCount
		{
			get => GetProperty(ref _maxAdditiveAnimEntriesCount);
			set => SetProperty(ref _maxAdditiveAnimEntriesCount, value);
		}

		[Ordinal(14)] 
		[RED("maxOverrideAnimEntriesCount")] 
		public CUInt16 MaxOverrideAnimEntriesCount
		{
			get => GetProperty(ref _maxOverrideAnimEntriesCount);
			set => SetProperty(ref _maxOverrideAnimEntriesCount, value);
		}

		public animAnimNode_MixerSlot()
		{
			_maxNormalAnimEntriesCount = 2;
			_maxAdditiveAnimEntriesCount = 2;
			_maxOverrideAnimEntriesCount = 2;
		}
	}
}
