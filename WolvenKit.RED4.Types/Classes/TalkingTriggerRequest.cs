using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TalkingTriggerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isPlayerCalling")] 
		public CBool IsPlayerCalling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("contact")] 
		public CName Contact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<questPhoneTalkingState> State
		{
			get => GetPropertyValue<CEnum<questPhoneTalkingState>>();
			set => SetPropertyValue<CEnum<questPhoneTalkingState>>(value);
		}
	}
}
