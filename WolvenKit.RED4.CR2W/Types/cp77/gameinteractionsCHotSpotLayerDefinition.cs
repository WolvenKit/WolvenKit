using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotLayerDefinition : gameinteractionsNodeDefinition
	{
		private CBool _enabled;
		private CName _tag;
		private CEnum<gameinteractionsEGroupType> _group;
		private CFloat _priorityMultiplier;
		private CHandle<gameinteractionsCHotSpotAreaFilterDefinition> _areaFilterDefinition;
		private CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> _gameLogicFilterDefinition;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("group")] 
		public CEnum<gameinteractionsEGroupType> Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CEnum<gameinteractionsEGroupType>) CR2WTypeManager.Create("gameinteractionsEGroupType", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("priorityMultiplier")] 
		public CFloat PriorityMultiplier
		{
			get
			{
				if (_priorityMultiplier == null)
				{
					_priorityMultiplier = (CFloat) CR2WTypeManager.Create("Float", "priorityMultiplier", cr2w, this);
				}
				return _priorityMultiplier;
			}
			set
			{
				if (_priorityMultiplier == value)
				{
					return;
				}
				_priorityMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("areaFilterDefinition")] 
		public CHandle<gameinteractionsCHotSpotAreaFilterDefinition> AreaFilterDefinition
		{
			get
			{
				if (_areaFilterDefinition == null)
				{
					_areaFilterDefinition = (CHandle<gameinteractionsCHotSpotAreaFilterDefinition>) CR2WTypeManager.Create("handle:gameinteractionsCHotSpotAreaFilterDefinition", "areaFilterDefinition", cr2w, this);
				}
				return _areaFilterDefinition;
			}
			set
			{
				if (_areaFilterDefinition == value)
				{
					return;
				}
				_areaFilterDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("gameLogicFilterDefinition")] 
		public CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition> GameLogicFilterDefinition
		{
			get
			{
				if (_gameLogicFilterDefinition == null)
				{
					_gameLogicFilterDefinition = (CHandle<gameinteractionsCHotSpotGameLogicFilterDefinition>) CR2WTypeManager.Create("handle:gameinteractionsCHotSpotGameLogicFilterDefinition", "gameLogicFilterDefinition", cr2w, this);
				}
				return _gameLogicFilterDefinition;
			}
			set
			{
				if (_gameLogicFilterDefinition == value)
				{
					return;
				}
				_gameLogicFilterDefinition = value;
				PropertySet(this);
			}
		}

		public gameinteractionsCHotSpotLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
