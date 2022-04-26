using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_SceneItem : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimEvent_SceneItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
