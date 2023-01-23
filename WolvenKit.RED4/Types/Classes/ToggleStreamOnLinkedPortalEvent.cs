using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleStreamOnLinkedPortalEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("activate")] 
		public CBool Activate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleStreamOnLinkedPortalEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
