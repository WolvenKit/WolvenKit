using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsAttemptedChoice : CVariable
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

		public gameinteractionsAttemptedChoice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
