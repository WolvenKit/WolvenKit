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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
