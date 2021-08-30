using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTriggerCallRequest : gameScriptableSystemRequest
	{
		private CName _caller;
		private CName _addressee;
		private CEnum<questPhoneCallPhase> _callPhase;
		private CEnum<questPhoneCallMode> _callMode;
		private CBool _isPlayerTriggered;
		private CBool _isRejectable;

		[Ordinal(0)] 
		[RED("caller")] 
		public CName Caller
		{
			get => GetProperty(ref _caller);
			set => SetProperty(ref _caller, value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CName Addressee
		{
			get => GetProperty(ref _addressee);
			set => SetProperty(ref _addressee, value);
		}

		[Ordinal(2)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetProperty(ref _callPhase);
			set => SetProperty(ref _callPhase, value);
		}

		[Ordinal(3)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get => GetProperty(ref _callMode);
			set => SetProperty(ref _callMode, value);
		}

		[Ordinal(4)] 
		[RED("isPlayerTriggered")] 
		public CBool IsPlayerTriggered
		{
			get => GetProperty(ref _isPlayerTriggered);
			set => SetProperty(ref _isPlayerTriggered, value);
		}

		[Ordinal(5)] 
		[RED("isRejectable")] 
		public CBool IsRejectable
		{
			get => GetProperty(ref _isRejectable);
			set => SetProperty(ref _isRejectable, value);
		}

		public questTriggerCallRequest()
		{
			_callPhase = new() { Value = Enums.questPhoneCallPhase.IncomingCall };
			_callMode = new() { Value = Enums.questPhoneCallMode.Audio };
		}
	}
}
