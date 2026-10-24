using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioTermsPopupCloseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isAccepted")] 
		public CBool IsAccepted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ModioTermsPopupCloseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
