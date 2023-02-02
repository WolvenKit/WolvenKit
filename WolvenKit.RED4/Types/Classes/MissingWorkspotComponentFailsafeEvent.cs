using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MissingWorkspotComponentFailsafeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public MissingWorkspotComponentFailsafeEvent()
		{
			PlayerEntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
