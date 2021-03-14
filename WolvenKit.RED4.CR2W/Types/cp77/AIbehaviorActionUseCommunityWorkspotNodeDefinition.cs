using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUseCommunityWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CHandle<AIArgumentMapping> _playExitAutomatically;
		private CHandle<AIArgumentMapping> _fastForwardAfterTeleport;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("playExitAutomatically")] 
		public CHandle<AIArgumentMapping> PlayExitAutomatically
		{
			get
			{
				if (_playExitAutomatically == null)
				{
					_playExitAutomatically = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "playExitAutomatically", cr2w, this);
				}
				return _playExitAutomatically;
			}
			set
			{
				if (_playExitAutomatically == value)
				{
					return;
				}
				_playExitAutomatically = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public AIbehaviorActionUseCommunityWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
