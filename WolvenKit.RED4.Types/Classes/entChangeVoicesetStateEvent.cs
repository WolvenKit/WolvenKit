using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entChangeVoicesetStateEvent : redEvent
	{
		private CBool _enableVoicesetLines;
		private CBool _enableVoicesetGrunts;
		private CArray<entVoicesetInputToBlock> _inputsToBlock;

		[Ordinal(0)] 
		[RED("enableVoicesetLines")] 
		public CBool EnableVoicesetLines
		{
			get => GetProperty(ref _enableVoicesetLines);
			set => SetProperty(ref _enableVoicesetLines, value);
		}

		[Ordinal(1)] 
		[RED("enableVoicesetGrunts")] 
		public CBool EnableVoicesetGrunts
		{
			get => GetProperty(ref _enableVoicesetGrunts);
			set => SetProperty(ref _enableVoicesetGrunts, value);
		}

		[Ordinal(2)] 
		[RED("inputsToBlock")] 
		public CArray<entVoicesetInputToBlock> InputsToBlock
		{
			get => GetProperty(ref _inputsToBlock);
			set => SetProperty(ref _inputsToBlock, value);
		}

		public entChangeVoicesetStateEvent()
		{
			_enableVoicesetLines = true;
			_enableVoicesetGrunts = true;
		}
	}
}
