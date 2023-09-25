using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CandleControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("candleSkillChecks")] 
		public CHandle<EngDemoContainer> CandleSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		public CandleControllerPS()
		{
			DeviceName = "LocKey#45725";
			TweakDBRecord = 62927945580;
			TweakDBDescriptionRecord = 115775549431;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
