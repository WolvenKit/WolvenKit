using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionUseWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _eventData;
		private CHandle<AIArgumentMapping> _playStartAnimationAfterwards;
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<AIArgumentMapping> _dependentWorkspotData;
		private CHandle<AIArgumentMapping> _playExitAutomatically;
		private CHandle<AIArgumentMapping> _markUninterruptable;

		[Ordinal(1)] 
		[RED("eventData")] 
		public CHandle<AIArgumentMapping> EventData
		{
			get
			{
				if (_eventData == null)
				{
					_eventData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "eventData", cr2w, this);
				}
				return _eventData;
			}
			set
			{
				if (_eventData == value)
				{
					return;
				}
				_eventData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playStartAnimationAfterwards")] 
		public CHandle<AIArgumentMapping> PlayStartAnimationAfterwards
		{
			get
			{
				if (_playStartAnimationAfterwards == null)
				{
					_playStartAnimationAfterwards = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "playStartAnimationAfterwards", cr2w, this);
				}
				return _playStartAnimationAfterwards;
			}
			set
			{
				if (_playStartAnimationAfterwards == value)
				{
					return;
				}
				_playStartAnimationAfterwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountData", cr2w, this);
				}
				return _mountData;
			}
			set
			{
				if (_mountData == value)
				{
					return;
				}
				_mountData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("markUninterruptable")] 
		public CHandle<AIArgumentMapping> MarkUninterruptable
		{
			get
			{
				if (_markUninterruptable == null)
				{
					_markUninterruptable = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "markUninterruptable", cr2w, this);
				}
				return _markUninterruptable;
			}
			set
			{
				if (_markUninterruptable == value)
				{
					return;
				}
				_markUninterruptable = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionUseWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
