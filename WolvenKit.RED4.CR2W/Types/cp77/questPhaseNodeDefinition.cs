using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhaseNodeDefinition : questEmbeddedGraphNodeDefinition
	{
		private CBool _saveLock;
		private raRef<questQuestPhaseResource> _phaseResource;
		private NodeRef _unfreezingTriggerNodeRef;
		private CArray<questQuestPrefabEntry> _phaseInstancePrefabs;
		private CHandle<questGraphDefinition> _phaseGraph;

		[Ordinal(2)] 
		[RED("saveLock")] 
		public CBool SaveLock
		{
			get
			{
				if (_saveLock == null)
				{
					_saveLock = (CBool) CR2WTypeManager.Create("Bool", "saveLock", cr2w, this);
				}
				return _saveLock;
			}
			set
			{
				if (_saveLock == value)
				{
					return;
				}
				_saveLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("phaseResource")] 
		public raRef<questQuestPhaseResource> PhaseResource
		{
			get
			{
				if (_phaseResource == null)
				{
					_phaseResource = (raRef<questQuestPhaseResource>) CR2WTypeManager.Create("raRef:questQuestPhaseResource", "phaseResource", cr2w, this);
				}
				return _phaseResource;
			}
			set
			{
				if (_phaseResource == value)
				{
					return;
				}
				_phaseResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("unfreezingTriggerNodeRef")] 
		public NodeRef UnfreezingTriggerNodeRef
		{
			get
			{
				if (_unfreezingTriggerNodeRef == null)
				{
					_unfreezingTriggerNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "unfreezingTriggerNodeRef", cr2w, this);
				}
				return _unfreezingTriggerNodeRef;
			}
			set
			{
				if (_unfreezingTriggerNodeRef == value)
				{
					return;
				}
				_unfreezingTriggerNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("phaseInstancePrefabs")] 
		public CArray<questQuestPrefabEntry> PhaseInstancePrefabs
		{
			get
			{
				if (_phaseInstancePrefabs == null)
				{
					_phaseInstancePrefabs = (CArray<questQuestPrefabEntry>) CR2WTypeManager.Create("array:questQuestPrefabEntry", "phaseInstancePrefabs", cr2w, this);
				}
				return _phaseInstancePrefabs;
			}
			set
			{
				if (_phaseInstancePrefabs == value)
				{
					return;
				}
				_phaseInstancePrefabs = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("phaseGraph")] 
		public CHandle<questGraphDefinition> PhaseGraph
		{
			get
			{
				if (_phaseGraph == null)
				{
					_phaseGraph = (CHandle<questGraphDefinition>) CR2WTypeManager.Create("handle:questGraphDefinition", "phaseGraph", cr2w, this);
				}
				return _phaseGraph;
			}
			set
			{
				if (_phaseGraph == value)
				{
					return;
				}
				_phaseGraph = value;
				PropertySet(this);
			}
		}

		public questPhaseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
