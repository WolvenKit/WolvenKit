using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallInformation : CVariable
	{
		private CEnum<questPhoneCallMode> _callMode;
		private CBool _isAudioCall;
		private CName _contactName;
		private CBool _isPlayerCalling;
		private CBool _isPlayerTriggered;
		private CEnum<questPhoneCallPhase> _callPhase;

		[Ordinal(0)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get => GetProperty(ref _callMode);
			set => SetProperty(ref _callMode, value);
		}

		[Ordinal(1)] 
		[RED("isAudioCall")] 
		public CBool IsAudioCall
		{
			get => GetProperty(ref _isAudioCall);
			set => SetProperty(ref _isAudioCall, value);
		}

		[Ordinal(2)] 
		[RED("contactName")] 
		public CName ContactName
		{
			get => GetProperty(ref _contactName);
			set => SetProperty(ref _contactName, value);
		}

		[Ordinal(3)] 
		[RED("isPlayerCalling")] 
		public CBool IsPlayerCalling
		{
			get => GetProperty(ref _isPlayerCalling);
			set => SetProperty(ref _isPlayerCalling, value);
		}

		[Ordinal(4)] 
		[RED("isPlayerTriggered")] 
		public CBool IsPlayerTriggered
		{
			get => GetProperty(ref _isPlayerTriggered);
			set => SetProperty(ref _isPlayerTriggered, value);
		}

		[Ordinal(5)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetProperty(ref _callPhase);
			set => SetProperty(ref _callPhase, value);
		}

		public questPhoneCallInformation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
