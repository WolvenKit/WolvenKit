using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameTransformAnimationTrackItem : ISerializable
	{
		private CHandle<gameTransformAnimationTrackItemImpl> _impl;
		private CFloat _startTime;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("impl")] 
		public CHandle<gameTransformAnimationTrackItemImpl> Impl
		{
			get => GetProperty(ref _impl);
			set => SetProperty(ref _impl, value);
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}
	}
}
