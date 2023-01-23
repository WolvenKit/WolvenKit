using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealDevicesGridOnEntityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RevealDevicesGridOnEntityEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
