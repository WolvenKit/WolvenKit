using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotoModeUIVisibilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("visible")] 
		public CBool Visible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPhotoModeUIVisibilityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
