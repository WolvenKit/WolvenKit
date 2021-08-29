using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItem : effectBaseItem
	{
		private CFloat _timeBegin;
		private CFloat _timeDuration;
		private CRUID _ruid;

		[Ordinal(0)] 
		[RED("timeBegin")] 
		public CFloat TimeBegin
		{
			get => GetProperty(ref _timeBegin);
			set => SetProperty(ref _timeBegin, value);
		}

		[Ordinal(1)] 
		[RED("timeDuration")] 
		public CFloat TimeDuration
		{
			get => GetProperty(ref _timeDuration);
			set => SetProperty(ref _timeDuration, value);
		}

		[Ordinal(2)] 
		[RED("ruid")] 
		public CRUID Ruid
		{
			get => GetProperty(ref _ruid);
			set => SetProperty(ref _ruid, value);
		}
	}
}
