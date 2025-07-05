using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExitCombatOnOpticalCamoActivatedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<gameObject> Npc
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ExitCombatOnOpticalCamoActivatedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
