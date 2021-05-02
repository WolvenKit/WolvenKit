using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TalkingTriggerRequest : gameScriptableSystemRequest
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

		public TalkingTriggerRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
