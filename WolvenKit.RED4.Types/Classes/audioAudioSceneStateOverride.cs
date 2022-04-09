using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioSceneStateOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("templateStateName")] 
		public CName TemplateStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("enterEventOverride")] 
		public CName EnterEventOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("exitEventOverride")] 
		public CName ExitEventOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioAudioSceneStateOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
