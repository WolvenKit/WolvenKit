using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent : ISerializable
	{
		private CUInt32 _startFrame;
		private CUInt32 _durationInFrames;
		private CName _eventName;

		[Ordinal(0)] 
		[RED("startFrame")] 
		public CUInt32 StartFrame
		{
			get => GetProperty(ref _startFrame);
			set => SetProperty(ref _startFrame, value);
		}

		[Ordinal(1)] 
		[RED("durationInFrames")] 
		public CUInt32 DurationInFrames
		{
			get => GetProperty(ref _durationInFrames);
			set => SetProperty(ref _durationInFrames, value);
		}

		[Ordinal(2)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}
	}
}
