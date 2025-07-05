using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPhoneCallInformation : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("callMode")] 
		public CEnum<questPhoneCallMode> CallMode
		{
			get => GetPropertyValue<CEnum<questPhoneCallMode>>();
			set => SetPropertyValue<CEnum<questPhoneCallMode>>(value);
		}

		[Ordinal(1)] 
		[RED("isAudioCall")] 
		public CBool IsAudioCall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("contactName")] 
		public CName ContactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayerCalling")] 
		public CBool IsPlayerCalling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isPlayerTriggered")] 
		public CBool IsPlayerTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("callPhase")] 
		public CEnum<questPhoneCallPhase> CallPhase
		{
			get => GetPropertyValue<CEnum<questPhoneCallPhase>>();
			set => SetPropertyValue<CEnum<questPhoneCallPhase>>(value);
		}

		[Ordinal(6)] 
		[RED("isRejectable")] 
		public CBool IsRejectable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("showAvatar")] 
		public CBool ShowAvatar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("visuals")] 
		public CEnum<questPhoneCallVisuals> Visuals
		{
			get => GetPropertyValue<CEnum<questPhoneCallVisuals>>();
			set => SetPropertyValue<CEnum<questPhoneCallVisuals>>(value);
		}

		public questPhoneCallInformation()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
