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
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("agents")] 
		public CArray<Agent> Agents
		{
			get
			{
				if (_agents == null)
				{
					_agents = (CArray<Agent>) CR2WTypeManager.Create("array:Agent", "agents", cr2w, this);
				}
				return _agents;
			}
			set
			{
				if (_agents == value)
				{
					return;
				}
				_agents = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("agentsLock")] 
		public ScriptReentrantRWLock AgentsLock
		{
			get
			{
				if (_agentsLock == null)
				{
					_agentsLock = (ScriptReentrantRWLock) CR2WTypeManager.Create("ScriptReentrantRWLock", "agentsLock", cr2w, this);
				}
				return _agentsLock;
			}
			set
			{
				if (_agentsLock == value)
				{
					return;
				}
				_agentsLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxReprimandsPerNPC")] 
		public CInt32 MaxReprimandsPerNPC
		{
			get
			{
				if (_maxReprimandsPerNPC == null)
				{
					_maxReprimandsPerNPC = (CInt32) CR2WTypeManager.Create("Int32", "maxReprimandsPerNPC", cr2w, this);
				}
				return _maxReprimandsPerNPC;
			}
			set
			{
				if (_maxReprimandsPerNPC == value)
				{
					return;
				}
				_maxReprimandsPerNPC = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxReprimandsPerDEVICE")] 
		public CInt32 MaxReprimandsPerDEVICE
		{
			get
			{
				if (_maxReprimandsPerDEVICE == null)
				{
					_maxReprimandsPerDEVICE = (CInt32) CR2WTypeManager.Create("Int32", "maxReprimandsPerDEVICE", cr2w, this);
				}
				return _maxReprimandsPerDEVICE;
			}
			set
			{
				if (_maxReprimandsPerDEVICE == value)
				{
					return;
				}
				_maxReprimandsPerDEVICE = value;
				PropertySet(this);
			}
		}

		public AgentRegistry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
