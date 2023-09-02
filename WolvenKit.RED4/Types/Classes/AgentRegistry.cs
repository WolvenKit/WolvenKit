using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AgentRegistry : IScriptable
	{
		[Ordinal(0)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("agents")] 
		public CArray<Agent> Agents
		{
			get => GetPropertyValue<CArray<Agent>>();
			set => SetPropertyValue<CArray<Agent>>(value);
		}

		[Ordinal(2)] 
		[RED("agentsLock")] 
		public ScriptReentrantRWLock AgentsLock
		{
			get => GetPropertyValue<ScriptReentrantRWLock>();
			set => SetPropertyValue<ScriptReentrantRWLock>(value);
		}

		[Ordinal(3)] 
		[RED("maxReprimandsPerNPC")] 
		public CInt32 MaxReprimandsPerNPC
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("maxReprimandsPerDEVICE")] 
		public CInt32 MaxReprimandsPerDEVICE
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AgentRegistry()
		{
			Agents = new();
			AgentsLock = new ScriptReentrantRWLock();
			MaxReprimandsPerNPC = 2;
			MaxReprimandsPerDEVICE = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
