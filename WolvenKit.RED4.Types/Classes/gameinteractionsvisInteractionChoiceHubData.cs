using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsvisInteractionChoiceHubData : RedBaseClass
	{
		private CInt32 _id;
		private CEnum<gameinteractionsvisEVisualizerDefinitionFlags> _flags;
		private CBool _active;
		private CString _title;
		private CArray<gameinteractionsvisInteractionChoiceData> _choices;
		private CWeakHandle<gameinteractionsvisIVisualizerTimeProvider> _timeProvider;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("flags")] 
		public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		[Ordinal(2)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(3)] 
		[RED("title")] 
		public CString Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(4)] 
		[RED("choices")] 
		public CArray<gameinteractionsvisInteractionChoiceData> Choices
		{
			get => GetProperty(ref _choices);
			set => SetProperty(ref _choices, value);
		}

		[Ordinal(5)] 
		[RED("timeProvider")] 
		public CWeakHandle<gameinteractionsvisIVisualizerTimeProvider> TimeProvider
		{
			get => GetProperty(ref _timeProvider);
			set => SetProperty(ref _timeProvider, value);
		}

		public gameinteractionsvisInteractionChoiceHubData()
		{
			_id = -1;
		}
	}
}
