using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CHandle<AIArgumentMapping> _spotInstance;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CBool _repeatChild;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;

		[Ordinal(1)] 
		[RED("spotInstance")] 
		public CHandle<AIArgumentMapping> SpotInstance
		{
			get
			{
				if (_spotInstance == null)
				{
					_spotInstance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spotInstance", cr2w, this);
				}
				return _spotInstance;
			}
			set
			{
				if (_spotInstance == value)
				{
					return;
				}
				_spotInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dependentWorkspotData")] 
		public CHandle<AIArgumentMapping> DependentWorkspotData
		{
			get
			{
				if (_dependentWorkspotData == null)
				{
					_dependentWorkspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "dependentWorkspotData", cr2w, this);
				}
				return _dependentWorkspotData;
			}
			set
			{
				if (_dependentWorkspotData == value)
				{
					return;
				}
				_dependentWorkspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("repeatChild")] 
		public CBool RepeatChild
		{
			get
			{
				if (_repeatChild == null)
				{
					_repeatChild = (CBool) CR2WTypeManager.Create("Bool", "repeatChild", cr2w, this);
				}
				return _repeatChild;
			}
			set
			{
				if (_repeatChild == value)
				{
					return;
				}
				_repeatChild = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fastForwardAfterTeleport")] 
		public CHandle<AIArgumentMapping> FastForwardAfterTeleport
		{
			get
			{
				if (_fastForwardAfterTeleport == null)
				{
					_fastForwardAfterTeleport = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "fastForwardAfterTeleport", cr2w, this);
				}
				return _fastForwardAfterTeleport;
			}
			set
			{
				if (_fastForwardAfterTeleport == value)
				{
					return;
				}
				_fastForwardAfterTeleport = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSelectWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
