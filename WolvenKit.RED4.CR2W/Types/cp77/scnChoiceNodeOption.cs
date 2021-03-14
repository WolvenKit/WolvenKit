using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeOption : CVariable
	{
		private scnscreenplayItemId _screenplayOptionId;
		private CBool _blueline;
		private CBool _isSingleChoice;
		private gameinteractionsChoiceTypeWrapper _type;
		private CHandle<scnChoiceNodeNsTimedParams> _timedParams;
		private CHandle<questIBaseCondition> _questCondition;
		private CHandle<questIBaseCondition> _triggerCondition;
		private CHandle<questIBaseCondition> _bluelineCondition;
		private TweakDBID _gameplayAction;
		private CArray<TweakDBID> _iconTagIds;
		private CUInt32 _exDataFlags;
		private scnReferencePointId _mappinReferencePointId;
		private CHandle<scnTimedCondition> _timedCondition;

		[Ordinal(0)] 
		[RED("screenplayOptionId")] 
		public scnscreenplayItemId ScreenplayOptionId
		{
			get
			{
				if (_screenplayOptionId == null)
				{
					_screenplayOptionId = (scnscreenplayItemId) CR2WTypeManager.Create("scnscreenplayItemId", "screenplayOptionId", cr2w, this);
				}
				return _screenplayOptionId;
			}
			set
			{
				if (_screenplayOptionId == value)
				{
					return;
				}
				_screenplayOptionId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blueline")] 
		public CBool Blueline
		{
			get
			{
				if (_blueline == null)
				{
					_blueline = (CBool) CR2WTypeManager.Create("Bool", "blueline", cr2w, this);
				}
				return _blueline;
			}
			set
			{
				if (_blueline == value)
				{
					return;
				}
				_blueline = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isSingleChoice")] 
		public CBool IsSingleChoice
		{
			get
			{
				if (_isSingleChoice == null)
				{
					_isSingleChoice = (CBool) CR2WTypeManager.Create("Bool", "isSingleChoice", cr2w, this);
				}
				return _isSingleChoice;
			}
			set
			{
				if (_isSingleChoice == value)
				{
					return;
				}
				_isSingleChoice = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("type")] 
		public gameinteractionsChoiceTypeWrapper Type
		{
			get
			{
				if (_type == null)
				{
					_type = (gameinteractionsChoiceTypeWrapper) CR2WTypeManager.Create("gameinteractionsChoiceTypeWrapper", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timedParams")] 
		public CHandle<scnChoiceNodeNsTimedParams> TimedParams
		{
			get
			{
				if (_timedParams == null)
				{
					_timedParams = (CHandle<scnChoiceNodeNsTimedParams>) CR2WTypeManager.Create("handle:scnChoiceNodeNsTimedParams", "timedParams", cr2w, this);
				}
				return _timedParams;
			}
			set
			{
				if (_timedParams == value)
				{
					return;
				}
				_timedParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("questCondition")] 
		public CHandle<questIBaseCondition> QuestCondition
		{
			get
			{
				if (_questCondition == null)
				{
					_questCondition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "questCondition", cr2w, this);
				}
				return _questCondition;
			}
			set
			{
				if (_questCondition == value)
				{
					return;
				}
				_questCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("triggerCondition")] 
		public CHandle<questIBaseCondition> TriggerCondition
		{
			get
			{
				if (_triggerCondition == null)
				{
					_triggerCondition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "triggerCondition", cr2w, this);
				}
				return _triggerCondition;
			}
			set
			{
				if (_triggerCondition == value)
				{
					return;
				}
				_triggerCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("bluelineCondition")] 
		public CHandle<questIBaseCondition> BluelineCondition
		{
			get
			{
				if (_bluelineCondition == null)
				{
					_bluelineCondition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "bluelineCondition", cr2w, this);
				}
				return _bluelineCondition;
			}
			set
			{
				if (_bluelineCondition == value)
				{
					return;
				}
				_bluelineCondition = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gameplayAction")] 
		public TweakDBID GameplayAction
		{
			get
			{
				if (_gameplayAction == null)
				{
					_gameplayAction = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "gameplayAction", cr2w, this);
				}
				return _gameplayAction;
			}
			set
			{
				if (_gameplayAction == value)
				{
					return;
				}
				_gameplayAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("iconTagIds")] 
		public CArray<TweakDBID> IconTagIds
		{
			get
			{
				if (_iconTagIds == null)
				{
					_iconTagIds = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "iconTagIds", cr2w, this);
				}
				return _iconTagIds;
			}
			set
			{
				if (_iconTagIds == value)
				{
					return;
				}
				_iconTagIds = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("exDataFlags")] 
		public CUInt32 ExDataFlags
		{
			get
			{
				if (_exDataFlags == null)
				{
					_exDataFlags = (CUInt32) CR2WTypeManager.Create("Uint32", "exDataFlags", cr2w, this);
				}
				return _exDataFlags;
			}
			set
			{
				if (_exDataFlags == value)
				{
					return;
				}
				_exDataFlags = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("mappinReferencePointId")] 
		public scnReferencePointId MappinReferencePointId
		{
			get
			{
				if (_mappinReferencePointId == null)
				{
					_mappinReferencePointId = (scnReferencePointId) CR2WTypeManager.Create("scnReferencePointId", "mappinReferencePointId", cr2w, this);
				}
				return _mappinReferencePointId;
			}
			set
			{
				if (_mappinReferencePointId == value)
				{
					return;
				}
				_mappinReferencePointId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("timedCondition")] 
		public CHandle<scnTimedCondition> TimedCondition
		{
			get
			{
				if (_timedCondition == null)
				{
					_timedCondition = (CHandle<scnTimedCondition>) CR2WTypeManager.Create("handle:scnTimedCondition", "timedCondition", cr2w, this);
				}
				return _timedCondition;
			}
			set
			{
				if (_timedCondition == value)
				{
					return;
				}
				_timedCondition = value;
				PropertySet(this);
			}
		}

		public scnChoiceNodeOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
