using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPhotoModeUIInteractiveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("interactive")] 
		public CBool Interactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiPhotoModeUIInteractiveEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
