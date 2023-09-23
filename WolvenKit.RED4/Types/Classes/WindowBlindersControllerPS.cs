using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WindowBlindersControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("windowBlindersSkillChecks")] 
		public CHandle<EngDemoContainer> WindowBlindersSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(108)] 
		[RED("windowBlindersData")] 
		public WindowBlindersData WindowBlindersData
		{
			get => GetPropertyValue<WindowBlindersData>();
			set => SetPropertyValue<WindowBlindersData>(value);
		}

		[Ordinal(109)] 
		[RED("cachedState")] 
		public CEnum<EWindowBlindersStates> CachedState
		{
			get => GetPropertyValue<CEnum<EWindowBlindersStates>>();
			set => SetPropertyValue<CEnum<EWindowBlindersStates>>(value);
		}

		[Ordinal(110)] 
		[RED("alarmRaised")] 
		public CBool AlarmRaised
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WindowBlindersControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
