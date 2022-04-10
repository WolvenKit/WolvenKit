using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CacheFXOnDefeated : StatusEffectTasks
	{
		[Ordinal(0)] 
		[RED("npcPuppet")] 
		public CWeakHandle<NPCPuppet> NpcPuppet
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public CacheFXOnDefeated()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
