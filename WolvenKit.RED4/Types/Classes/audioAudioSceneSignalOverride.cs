using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioSceneSignalOverride : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("templateSignal")] 
		public CName TemplateSignal
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("signalOverride")] 
		public CName SignalOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioAudioSceneSignalOverride()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
