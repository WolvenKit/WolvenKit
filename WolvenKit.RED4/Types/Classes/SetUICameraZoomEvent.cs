using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetUICameraZoomEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hasUICameraZoom")] 
		public CBool HasUICameraZoom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetUICameraZoomEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
