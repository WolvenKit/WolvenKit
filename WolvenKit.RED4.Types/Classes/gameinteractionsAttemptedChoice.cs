using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsAttemptedChoice : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("choiceIdx")] 
		public CInt32 ChoiceIdx
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("visualizerType")] 
		public CEnum<gameinteractionsvisEVisualizerType> VisualizerType
		{
			get => GetPropertyValue<CEnum<gameinteractionsvisEVisualizerType>>();
			set => SetPropertyValue<CEnum<gameinteractionsvisEVisualizerType>>(value);
		}

		[Ordinal(2)] 
		[RED("isSuccess")] 
		public CBool IsSuccess
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("choice")] 
		public gameinteractionsChoice Choice
		{
			get => GetPropertyValue<gameinteractionsChoice>();
			set => SetPropertyValue<gameinteractionsChoice>(value);
		}

		public gameinteractionsAttemptedChoice()
		{
			ChoiceIdx = -1;
			VisualizerType = Enums.gameinteractionsvisEVisualizerType.Invalid;
			Choice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
