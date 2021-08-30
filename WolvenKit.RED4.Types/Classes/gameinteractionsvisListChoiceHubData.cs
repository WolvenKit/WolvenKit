using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisListChoiceHubData : RedBaseClass
	{
		private CInt32 _id;
		private CEnum<gameinteractionsvisEVisualizerActivityState> _activityState;
		private CEnum<gameinteractionsvisEVisualizerDefinitionFlags> _flags;
		private CBool _isPhoneLockActive;
		private CString _title;
		private CArray<gameinteractionsvisListChoiceData> _choices;
		private CWeakHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;
		private CUInt8 _hubPriority;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("activityState")] 
		public CEnum<gameinteractionsvisEVisualizerActivityState> ActivityState
		{
			get => GetProperty(ref _activityState);
			set => SetProperty(ref _activityState, value);
		}

		[Ordinal(2)] 
		[RED("flags")] 
		public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(3)] 
		[RED("isPhoneLockActive")] 
		public CBool IsPhoneLockActive
		{
			get => GetProperty(ref _isPhoneLockActive);
			set => SetProperty(ref _isPhoneLockActive, value);
		}

		[Ordinal(4)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(5)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisListChoiceData> Choices
		{
			get => GetProperty(ref _choices);
			set => SetProperty(ref _choices, value);
		}

		[Ordinal(6)] 
		[RED("timeProvider")] 
		public CWeakHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetProperty(ref _timeProvider);
			set => SetProperty(ref _timeProvider, value);
		}

		[Ordinal(7)] 
		[RED("hubPriority")] 
		public CUInt8 HubPriority
		{
			get => GetProperty(ref _hubPriority);
			set => SetProperty(ref _hubPriority, value);
		}

		public gameinteractionsvisListChoiceHubData()
		{
			_id = -1;
		}
	}
}
