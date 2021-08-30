using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsAttemptedChoice : RedBaseClass
	{
		private CInt32 _choiceIdx;
		private CEnum<gameinteractionsvisEVisualizerType> _visualizerType;
		private CBool _isSuccess;
		private gameinteractionsChoice _choice;

		[Ordinal(0)] 
		[RED("choiceIdx")] 
		public CInt32 ChoiceIdx
		{
			get => GetProperty(ref _choiceIdx);
			set => SetProperty(ref _choiceIdx, value);
		}

		[Ordinal(1)] 
		[RED("visualizerType")] 
		public CEnum<gameinteractionsvisEVisualizerType> VisualizerType
		{
			get => GetProperty(ref _visualizerType);
			set => SetProperty(ref _visualizerType, value);
		}

		[Ordinal(2)] 
		[RED("isSuccess")] 
		public CBool IsSuccess
		{
			get => GetProperty(ref _isSuccess);
			set => SetProperty(ref _isSuccess, value);
		}

		[Ordinal(3)] 
		[RED("choice")] 
		public gameinteractionsChoice Choice
		{
			get => GetProperty(ref _choice);
			set => SetProperty(ref _choice, value);
		}

		public gameinteractionsAttemptedChoice()
		{
			_choiceIdx = -1;
			_visualizerType = new() { Value = Enums.gameinteractionsvisEVisualizerType.Invalid };
		}
	}
}
