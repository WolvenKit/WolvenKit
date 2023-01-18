using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimEvent_WorkspotPlayFacialAnim : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("facialAnimName")] 
		public CName FacialAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimEvent_WorkspotPlayFacialAnim()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
