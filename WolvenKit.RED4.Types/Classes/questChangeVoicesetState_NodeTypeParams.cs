using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questChangeVoicesetState_NodeTypeParams : RedBaseClass
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enableVoicesetLines;
		private CBool _enableVoicesetGrunts;
		private CArray<entVoicesetInputToBlock> _inputsToBlock;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("enableVoicesetLines")] 
		public CBool EnableVoicesetLines
		{
			get => GetProperty(ref _enableVoicesetLines);
			set => SetProperty(ref _enableVoicesetLines, value);
		}

		[Ordinal(3)] 
		[RED("enableVoicesetGrunts")] 
		public CBool EnableVoicesetGrunts
		{
			get => GetProperty(ref _enableVoicesetGrunts);
			set => SetProperty(ref _enableVoicesetGrunts, value);
		}

		[Ordinal(4)] 
		[RED("inputsToBlock")] 
		public CArray<entVoicesetInputToBlock> InputsToBlock
		{
			get => GetProperty(ref _inputsToBlock);
			set => SetProperty(ref _inputsToBlock, value);
		}
	}
}
