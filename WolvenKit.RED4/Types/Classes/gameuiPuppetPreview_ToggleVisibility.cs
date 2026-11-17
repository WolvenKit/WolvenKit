using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPuppetPreview_ToggleVisibility : redEvent
	{
		[Ordinal(0)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPuppetPreview_ToggleVisibility()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
