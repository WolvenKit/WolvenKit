using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCDeathListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("npc")] 
		public CWeakHandle<NPCPuppet> Npc
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public NPCDeathListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
