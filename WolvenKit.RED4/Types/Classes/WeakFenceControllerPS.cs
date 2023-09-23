using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeakFenceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("weakfenceSkillChecks")] 
		public CHandle<EngDemoContainer> WeakfenceSkillChecks
		{
			get => GetPropertyValue<CHandle<EngDemoContainer>>();
			set => SetPropertyValue<CHandle<EngDemoContainer>>(value);
		}

		[Ordinal(108)] 
		[RED("weakFenceSetup")] 
		public WeakFenceSetup WeakFenceSetup
		{
			get => GetPropertyValue<WeakFenceSetup>();
			set => SetPropertyValue<WeakFenceSetup>(value);
		}

		public WeakFenceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
