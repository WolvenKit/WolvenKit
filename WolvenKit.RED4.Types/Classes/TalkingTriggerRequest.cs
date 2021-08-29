using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TalkingTriggerRequest : gameScriptableSystemRequest
	{
		private CBool _isPlayerCalling;
		private CName _contact;
		private CEnum<questPhoneTalkingState> _state;

		[Ordinal(0)] 
		[RED("isPlayerCalling")] 
		public CBool IsPlayerCalling
		{
			get => GetProperty(ref _isPlayerCalling);
			set => SetProperty(ref _isPlayerCalling, value);
		}

		[Ordinal(1)] 
		[RED("contact")] 
		public CName Contact
		{
			get => GetProperty(ref _contact);
			set => SetProperty(ref _contact, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<questPhoneTalkingState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}
	}
}
