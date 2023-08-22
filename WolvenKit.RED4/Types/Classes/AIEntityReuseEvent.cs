using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIEntityReuseEvent : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("destination")] 
		public worldGlobalNodeID Destination
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		public AIEntityReuseEvent()
		{
			Name = "EntityTeleportRequested";
			Destination = new worldGlobalNodeID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
