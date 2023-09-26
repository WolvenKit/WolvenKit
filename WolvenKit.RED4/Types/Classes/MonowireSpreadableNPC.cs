using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MonowireSpreadableNPC : IScriptable
	{
		[Ordinal(0)] 
		[RED("NPCPuppet")] 
		public CWeakHandle<NPCPuppet> NPCPuppet
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("HitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get => GetPropertyValue<CHandle<gameeventsHitEvent>>();
			set => SetPropertyValue<CHandle<gameeventsHitEvent>>(value);
		}

		public MonowireSpreadableNPC()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
