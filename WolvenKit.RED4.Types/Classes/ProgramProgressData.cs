using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProgramProgressData : RedBaseClass
	{
		private CString _id;
		private CArray<CInt32> _completionProgress;
		private CBool _isComplete;
		private CBool _revealLocalizedName;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("completionProgress")] 
		public CArray<CInt32> CompletionProgress
		{
			get => GetProperty(ref _completionProgress);
			set => SetProperty(ref _completionProgress, value);
		}

		[Ordinal(2)] 
		[RED("isComplete")] 
		public CBool IsComplete
		{
			get => GetProperty(ref _isComplete);
			set => SetProperty(ref _isComplete, value);
		}

		[Ordinal(3)] 
		[RED("revealLocalizedName")] 
		public CBool RevealLocalizedName
		{
			get => GetProperty(ref _revealLocalizedName);
			set => SetProperty(ref _revealLocalizedName, value);
		}
	}
}
