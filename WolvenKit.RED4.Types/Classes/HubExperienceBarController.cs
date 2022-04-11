using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HubExperienceBarController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("foregroundContainer")] 
		public inkWidgetReference ForegroundContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public HubExperienceBarController()
		{
			ForegroundContainer = new();
		}
	}
}
