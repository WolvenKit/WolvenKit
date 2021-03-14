using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterruptionScenario : CVariable
	{
		private scnInterruptionScenarioId _id;
		private CName _name;
		private CBool _enabled;
		private CBool _talkOnReturn;
		private CBool _playInterruptLine;
		private CBool _forcePlayReturnLine;
		private CBool _interruptionSpammingSafeguard;
		private CEnum<scnInterruptReturnLinesBehavior> _playingLinesBehavior;
		private CFloat _postInterruptSignalTimeDelay;
		private CFloat _postReturnSignalTimeDelay;
		private CHandle<scnInterruptFactConditionType> _postInterruptSignalFactCondition;
		private CHandle<scnInterruptFactConditionType> _postReturnSignalFactCondition;
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;
		private CArray<CHandle<scnIReturnCondition>> _returnConditions;

		[Ordinal(0)] 
		[RED("id")] 
		public scnInterruptionScenarioId Id
		{
			get
			{
				if (_id == null)
				{
					_id = (scnInterruptionScenarioId) CR2WTypeManager.Create("scnInterruptionScenarioId", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("talkOnReturn")] 
		public CBool TalkOnReturn
		{
			get
			{
				if (_talkOnReturn == null)
				{
					_talkOnReturn = (CBool) CR2WTypeManager.Create("Bool", "talkOnReturn", cr2w, this);
				}
				return _talkOnReturn;
			}
			set
			{
				if (_talkOnReturn == value)
				{
					return;
				}
				_talkOnReturn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playInterruptLine")] 
		public CBool PlayInterruptLine
		{
			get
			{
				if (_playInterruptLine == null)
				{
					_playInterruptLine = (CBool) CR2WTypeManager.Create("Bool", "playInterruptLine", cr2w, this);
				}
				return _playInterruptLine;
			}
			set
			{
				if (_playInterruptLine == value)
				{
					return;
				}
				_playInterruptLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("forcePlayReturnLine")] 
		public CBool ForcePlayReturnLine
		{
			get
			{
				if (_forcePlayReturnLine == null)
				{
					_forcePlayReturnLine = (CBool) CR2WTypeManager.Create("Bool", "forcePlayReturnLine", cr2w, this);
				}
				return _forcePlayReturnLine;
			}
			set
			{
				if (_forcePlayReturnLine == value)
				{
					return;
				}
				_forcePlayReturnLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("interruptionSpammingSafeguard")] 
		public CBool InterruptionSpammingSafeguard
		{
			get
			{
				if (_interruptionSpammingSafeguard == null)
				{
					_interruptionSpammingSafeguard = (CBool) CR2WTypeManager.Create("Bool", "interruptionSpammingSafeguard", cr2w, this);
				}
				return _interruptionSpammingSafeguard;
			}
			set
			{
				if (_interruptionSpammingSafeguard == value)
				{
					return;
				}
				_interruptionSpammingSafeguard = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playingLinesBehavior")] 
		public CEnum<scnInterruptReturnLinesBehavior> PlayingLinesBehavior
		{
			get
			{
				if (_playingLinesBehavior == null)
				{
					_playingLinesBehavior = (CEnum<scnInterruptReturnLinesBehavior>) CR2WTypeManager.Create("scnInterruptReturnLinesBehavior", "playingLinesBehavior", cr2w, this);
				}
				return _playingLinesBehavior;
			}
			set
			{
				if (_playingLinesBehavior == value)
				{
					return;
				}
				_playingLinesBehavior = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("postInterruptSignalTimeDelay")] 
		public CFloat PostInterruptSignalTimeDelay
		{
			get
			{
				if (_postInterruptSignalTimeDelay == null)
				{
					_postInterruptSignalTimeDelay = (CFloat) CR2WTypeManager.Create("Float", "postInterruptSignalTimeDelay", cr2w, this);
				}
				return _postInterruptSignalTimeDelay;
			}
			set
			{
				if (_postInterruptSignalTimeDelay == value)
				{
					return;
				}
				_postInterruptSignalTimeDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("postReturnSignalTimeDelay")] 
		public CFloat PostReturnSignalTimeDelay
		{
			get
			{
				if (_postReturnSignalTimeDelay == null)
				{
					_postReturnSignalTimeDelay = (CFloat) CR2WTypeManager.Create("Float", "postReturnSignalTimeDelay", cr2w, this);
				}
				return _postReturnSignalTimeDelay;
			}
			set
			{
				if (_postReturnSignalTimeDelay == value)
				{
					return;
				}
				_postReturnSignalTimeDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("postInterruptSignalFactCondition")] 
		public CHandle<scnInterruptFactConditionType> PostInterruptSignalFactCondition
		{
			get
			{
				if (_postInterruptSignalFactCondition == null)
				{
					_postInterruptSignalFactCondition = (CHandle<scnInterruptFactConditionType>) CR2WTypeManager.Create("handle:scnInterruptFactConditionType", "postInterruptSignalFactCondition", cr2w, this);
				}
				return _postInterruptSignalFactCondition;
			}
			set
			{
				if (_postInterruptSignalFactCondition == value)
				{
					return;
				}
				_postInterruptSignalFactCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("postReturnSignalFactCondition")] 
		public CHandle<scnInterruptFactConditionType> PostReturnSignalFactCondition
		{
			get
			{
				if (_postReturnSignalFactCondition == null)
				{
					_postReturnSignalFactCondition = (CHandle<scnInterruptFactConditionType>) CR2WTypeManager.Create("handle:scnInterruptFactConditionType", "postReturnSignalFactCondition", cr2w, this);
				}
				return _postReturnSignalFactCondition;
			}
			set
			{
				if (_postReturnSignalFactCondition == value)
				{
					return;
				}
				_postReturnSignalFactCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get
			{
				if (_interruptConditions == null)
				{
					_interruptConditions = (CArray<CHandle<scnIInterruptCondition>>) CR2WTypeManager.Create("array:handle:scnIInterruptCondition", "interruptConditions", cr2w, this);
				}
				return _interruptConditions;
			}
			set
			{
				if (_interruptConditions == value)
				{
					return;
				}
				_interruptConditions = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get
			{
				if (_returnConditions == null)
				{
					_returnConditions = (CArray<CHandle<scnIReturnCondition>>) CR2WTypeManager.Create("array:handle:scnIReturnCondition", "returnConditions", cr2w, this);
				}
				return _returnConditions;
			}
			set
			{
				if (_returnConditions == value)
				{
					return;
				}
				_returnConditions = value;
				PropertySet(this);
			}
		}

		public scnInterruptionScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
