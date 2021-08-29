using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HubExperienceBarController : inkWidgetLogicController
	{
		private inkWidgetReference _foregroundContainer;

		[Ordinal(1)] 
		[RED("foregroundContainer")] 
		public inkWidgetReference ForegroundContainer
		{
			get => GetProperty(ref _foregroundContainer);
			set => SetProperty(ref _foregroundContainer, value);
		}
	}
}
