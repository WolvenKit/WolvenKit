using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CandleControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
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
		}
	}
}
