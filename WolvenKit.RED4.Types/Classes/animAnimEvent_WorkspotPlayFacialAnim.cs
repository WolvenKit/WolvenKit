using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimEvent_WorkspotPlayFacialAnim : animAnimEvent
	{
		[Ordinal(3)] 
		[RED("facialAnimName")] 
		public CName FacialAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
