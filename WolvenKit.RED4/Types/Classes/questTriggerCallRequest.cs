using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTriggerCallRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("caller")] 
		public CName Caller
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("addressee")] 
		public CName Addressee
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetPropertyValue<CEnum<questPhoneCallPhase>>();
			set => SetPropertyValue<CEnum<questPhoneCallPhase>>(value);
		}

		[Ordinal(3)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get => GetPropertyValue<CEnum<questPhoneCallMode>>();
			set => SetPropertyValue<CEnum<questPhoneCallMode>>(value);
		}

		[Ordinal(4)] 
		[RED("isPlayerTriggered")] 
		public CBool IsPlayerTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isRejectable")] 
		public CBool IsRejectable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("showAvatar")] 
		public CBool ShowAvatar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("visuals")] 
		public CEnum<questPhoneCallVisuals> Visuals
		{
			get => GetPropertyValue<CEnum<questPhoneCallVisuals>>();
			set => SetPropertyValue<CEnum<questPhoneCallVisuals>>(value);
		}

		public questTriggerCallRequest()
		{
			CallPhase = Enums.questPhoneCallPhase.IncomingCall;
			CallMode = Enums.questPhoneCallMode.Audio;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
