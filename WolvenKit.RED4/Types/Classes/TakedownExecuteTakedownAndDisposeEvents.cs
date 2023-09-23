using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TakedownExecuteTakedownAndDisposeEvents : LocomotionTakedownEvents
	{
		[Ordinal(7)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public TakedownExecuteTakedownAndDisposeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
