using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WindowBlindersControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("windowBlindersSkillChecks")] 
		public CHandle<EngDemoContainer> WindowBlindersSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(105)] 
		[RED("windowBlindersData")] 
		public WindowBlindersData WindowBlindersData
		{
			get => GetPropertyValue<WindowBlindersData>();
			set => SetPropertyValue<WindowBlindersData>(value);
		}

		[Ordinal(106)] 
		[RED("cachedState")] 
		public CEnum<EWindowBlindersStates> CachedState
		{
			get => GetPropertyValue<CEnum<EWindowBlindersStates>>();
			set => SetPropertyValue<CEnum<EWindowBlindersStates>>(value);
		}

		[Ordinal(107)] 
		[RED("alarmRaised")] 
		public CBool AlarmRaised
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public WindowBlindersControllerPS()
		{
			DeviceName = "LocKey#104";
			TweakDBRecord = "Devices.WindowBlinders";
			TweakDBDescriptionRecord = 148393279395;
			WindowBlindersData = new WindowBlindersData { WindowBlindersState = Enums.EWindowBlindersStates.Closed, HasOpenInteraction = true, HasQuickHack = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
