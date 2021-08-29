using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDelayedFunctionsScheduler : ISerializable
	{
		private CBool _initialized;
		private EngineTime _currentTime;
		private CUInt32 _nextCallId;

		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(1)] 
		[RED("currentTime")] 
		public EngineTime CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(2)] 
		[RED("nextCallId")] 
		public CUInt32 NextCallId
		{
			get => GetProperty(ref _nextCallId);
			set => SetProperty(ref _nextCallId, value);
		}
	}
}
