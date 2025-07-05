using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PoliceAgentRegistry : IScriptable
	{
		[Ordinal(0)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleAgents")] 
		public CArray<CHandle<VehicleAgent>> VehicleAgents
		{
			get => GetPropertyValue<CArray<CHandle<VehicleAgent>>>();
			set => SetPropertyValue<CArray<CHandle<VehicleAgent>>>(value);
		}

		[Ordinal(2)] 
		[RED("npcAgents")] 
		public CArray<CHandle<NPCAgent>> NpcAgents
		{
			get => GetPropertyValue<CArray<CHandle<NPCAgent>>>();
			set => SetPropertyValue<CArray<CHandle<NPCAgent>>>(value);
		}

		[Ordinal(3)] 
		[RED("requestTickets")] 
		public CArray<TicketData> RequestTickets
		{
			get => GetPropertyValue<CArray<TicketData>>();
			set => SetPropertyValue<CArray<TicketData>>(value);
		}

		public PoliceAgentRegistry()
		{
			Game = new ScriptGameInstance();
			VehicleAgents = new();
			NpcAgents = new();
			RequestTickets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
