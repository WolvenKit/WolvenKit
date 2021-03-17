using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AgentRegistry : IScriptable
	{
		private CBool _isInitialized;
		private CArray<Agent> _agents;
		private ScriptReentrantRWLock _agentsLock;
		private CInt32 _maxReprimandsPerNPC;
		private CInt32 _maxReprimandsPerDEVICE;

		[Ordinal(0)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(1)] 
		[RED("agents")] 
		public CArray<Agent> Agents
		{
			get => GetProperty(ref _agents);
			set => SetProperty(ref _agents, value);
		}

		[Ordinal(2)] 
		[RED("agentsLock")] 
		public ScriptReentrantRWLock AgentsLock
		{
			get => GetProperty(ref _agentsLock);
			set => SetProperty(ref _agentsLock, value);
		}

		[Ordinal(3)] 
		[RED("maxReprimandsPerNPC")] 
		public CInt32 MaxReprimandsPerNPC
		{
			get => GetProperty(ref _maxReprimandsPerNPC);
			set => SetProperty(ref _maxReprimandsPerNPC, value);
		}

		[Ordinal(4)] 
		[RED("maxReprimandsPerDEVICE")] 
		public CInt32 MaxReprimandsPerDEVICE
		{
			get => GetProperty(ref _maxReprimandsPerDEVICE);
			set => SetProperty(ref _maxReprimandsPerDEVICE, value);
		}

		public AgentRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
