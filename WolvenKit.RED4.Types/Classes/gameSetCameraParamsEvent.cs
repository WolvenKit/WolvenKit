using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetCameraParamsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("paramsName")] 
		public CName ParamsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameSetCameraParamsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
