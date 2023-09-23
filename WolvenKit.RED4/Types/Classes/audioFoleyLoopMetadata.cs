using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioFoleyLoopMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startEvent")] 
		public CName StartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioFoleyLoopMetadata()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
