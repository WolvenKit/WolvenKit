using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCHealthListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<NPCPuppet> Npc
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public NPCHealthListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
