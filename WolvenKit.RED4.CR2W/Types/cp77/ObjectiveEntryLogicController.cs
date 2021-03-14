using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObjectiveEntryLogicController : inkWidgetLogicController
	{
		private CFloat _blinkInterval;
		private CFloat _blinkTotalTime;
		private CName _texturePart_Tracked;
		private CName _texturePart_Untracked;
		private CName _texturePart_Succeeded;
		private CName _texturePart_Failed;
		private CBool _isLargeUpdateWidget;
		private wCHandle<inkTextWidget> _entryName;
		private wCHandle<inkTextWidget> _entryOptional;
		private wCHandle<inkImageWidget> _stateIcon;
		private wCHandle<inkImageWidget> _trackedIcon;
		private wCHandle<inkWidget> _blinkWidget;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimDefinition> _animBlinkDef;
		private CHandle<inkanimProxy> _animBlink;
		private CHandle<inkanimDefinition> _animFadeDef;
		private CHandle<inkanimProxy> _animFade;
		private CInt32 _entryId;
		private CEnum<UIObjectiveEntryType> _type;
		private CEnum<gameJournalEntryState> _state;
		private wCHandle<ObjectiveEntryLogicController> _parentEntry;
		private CInt32 _childCount;
		private CBool _updated;
		private CBool _isTracked;
		private CBool _isOptional;

		[Ordinal(1)] 
		[RED("blinkInterval")] 
		public CFloat BlinkInterval
		{
			get
			{
				if (_blinkInterval == null)
				{
					_blinkInterval = (CFloat) CR2WTypeManager.Create("Float", "blinkInterval", cr2w, this);
				}
				return _blinkInterval;
			}
			set
			{
				if (_blinkInterval == value)
				{
					return;
				}
				_blinkInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("blinkTotalTime")] 
		public CFloat BlinkTotalTime
		{
			get
			{
				if (_blinkTotalTime == null)
				{
					_blinkTotalTime = (CFloat) CR2WTypeManager.Create("Float", "blinkTotalTime", cr2w, this);
				}
				return _blinkTotalTime;
			}
			set
			{
				if (_blinkTotalTime == value)
				{
					return;
				}
				_blinkTotalTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("texturePart_Tracked")] 
		public CName TexturePart_Tracked
		{
			get
			{
				if (_texturePart_Tracked == null)
				{
					_texturePart_Tracked = (CName) CR2WTypeManager.Create("CName", "texturePart_Tracked", cr2w, this);
				}
				return _texturePart_Tracked;
			}
			set
			{
				if (_texturePart_Tracked == value)
				{
					return;
				}
				_texturePart_Tracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("texturePart_Untracked")] 
		public CName TexturePart_Untracked
		{
			get
			{
				if (_texturePart_Untracked == null)
				{
					_texturePart_Untracked = (CName) CR2WTypeManager.Create("CName", "texturePart_Untracked", cr2w, this);
				}
				return _texturePart_Untracked;
			}
			set
			{
				if (_texturePart_Untracked == value)
				{
					return;
				}
				_texturePart_Untracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("texturePart_Succeeded")] 
		public CName TexturePart_Succeeded
		{
			get
			{
				if (_texturePart_Succeeded == null)
				{
					_texturePart_Succeeded = (CName) CR2WTypeManager.Create("CName", "texturePart_Succeeded", cr2w, this);
				}
				return _texturePart_Succeeded;
			}
			set
			{
				if (_texturePart_Succeeded == value)
				{
					return;
				}
				_texturePart_Succeeded = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("texturePart_Failed")] 
		public CName TexturePart_Failed
		{
			get
			{
				if (_texturePart_Failed == null)
				{
					_texturePart_Failed = (CName) CR2WTypeManager.Create("CName", "texturePart_Failed", cr2w, this);
				}
				return _texturePart_Failed;
			}
			set
			{
				if (_texturePart_Failed == value)
				{
					return;
				}
				_texturePart_Failed = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isLargeUpdateWidget")] 
		public CBool IsLargeUpdateWidget
		{
			get
			{
				if (_isLargeUpdateWidget == null)
				{
					_isLargeUpdateWidget = (CBool) CR2WTypeManager.Create("Bool", "isLargeUpdateWidget", cr2w, this);
				}
				return _isLargeUpdateWidget;
			}
			set
			{
				if (_isLargeUpdateWidget == value)
				{
					return;
				}
				_isLargeUpdateWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("entryName")] 
		public wCHandle<inkTextWidget> EntryName
		{
			get
			{
				if (_entryName == null)
				{
					_entryName = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "entryName", cr2w, this);
				}
				return _entryName;
			}
			set
			{
				if (_entryName == value)
				{
					return;
				}
				_entryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("entryOptional")] 
		public wCHandle<inkTextWidget> EntryOptional
		{
			get
			{
				if (_entryOptional == null)
				{
					_entryOptional = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "entryOptional", cr2w, this);
				}
				return _entryOptional;
			}
			set
			{
				if (_entryOptional == value)
				{
					return;
				}
				_entryOptional = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("stateIcon")] 
		public wCHandle<inkImageWidget> StateIcon
		{
			get
			{
				if (_stateIcon == null)
				{
					_stateIcon = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "stateIcon", cr2w, this);
				}
				return _stateIcon;
			}
			set
			{
				if (_stateIcon == value)
				{
					return;
				}
				_stateIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("trackedIcon")] 
		public wCHandle<inkImageWidget> TrackedIcon
		{
			get
			{
				if (_trackedIcon == null)
				{
					_trackedIcon = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "trackedIcon", cr2w, this);
				}
				return _trackedIcon;
			}
			set
			{
				if (_trackedIcon == value)
				{
					return;
				}
				_trackedIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("blinkWidget")] 
		public wCHandle<inkWidget> BlinkWidget
		{
			get
			{
				if (_blinkWidget == null)
				{
					_blinkWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "blinkWidget", cr2w, this);
				}
				return _blinkWidget;
			}
			set
			{
				if (_blinkWidget == value)
				{
					return;
				}
				_blinkWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("animBlinkDef")] 
		public CHandle<inkanimDefinition> AnimBlinkDef
		{
			get
			{
				if (_animBlinkDef == null)
				{
					_animBlinkDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animBlinkDef", cr2w, this);
				}
				return _animBlinkDef;
			}
			set
			{
				if (_animBlinkDef == value)
				{
					return;
				}
				_animBlinkDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("animBlink")] 
		public CHandle<inkanimProxy> AnimBlink
		{
			get
			{
				if (_animBlink == null)
				{
					_animBlink = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animBlink", cr2w, this);
				}
				return _animBlink;
			}
			set
			{
				if (_animBlink == value)
				{
					return;
				}
				_animBlink = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("animFadeDef")] 
		public CHandle<inkanimDefinition> AnimFadeDef
		{
			get
			{
				if (_animFadeDef == null)
				{
					_animFadeDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "animFadeDef", cr2w, this);
				}
				return _animFadeDef;
			}
			set
			{
				if (_animFadeDef == value)
				{
					return;
				}
				_animFadeDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("animFade")] 
		public CHandle<inkanimProxy> AnimFade
		{
			get
			{
				if (_animFade == null)
				{
					_animFade = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animFade", cr2w, this);
				}
				return _animFade;
			}
			set
			{
				if (_animFade == value)
				{
					return;
				}
				_animFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("entryId")] 
		public CInt32 EntryId
		{
			get
			{
				if (_entryId == null)
				{
					_entryId = (CInt32) CR2WTypeManager.Create("Int32", "entryId", cr2w, this);
				}
				return _entryId;
			}
			set
			{
				if (_entryId == value)
				{
					return;
				}
				_entryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("type")] 
		public CEnum<UIObjectiveEntryType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<UIObjectiveEntryType>) CR2WTypeManager.Create("UIObjectiveEntryType", "type", cr2w, this);
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

		[Ordinal(20)] 
		[RED("state")] 
		public CEnum<gameJournalEntryState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gameJournalEntryState>) CR2WTypeManager.Create("gameJournalEntryState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("parentEntry")] 
		public wCHandle<ObjectiveEntryLogicController> ParentEntry
		{
			get
			{
				if (_parentEntry == null)
				{
					_parentEntry = (wCHandle<ObjectiveEntryLogicController>) CR2WTypeManager.Create("whandle:ObjectiveEntryLogicController", "parentEntry", cr2w, this);
				}
				return _parentEntry;
			}
			set
			{
				if (_parentEntry == value)
				{
					return;
				}
				_parentEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("childCount")] 
		public CInt32 ChildCount
		{
			get
			{
				if (_childCount == null)
				{
					_childCount = (CInt32) CR2WTypeManager.Create("Int32", "childCount", cr2w, this);
				}
				return _childCount;
			}
			set
			{
				if (_childCount == value)
				{
					return;
				}
				_childCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("updated")] 
		public CBool Updated
		{
			get
			{
				if (_updated == null)
				{
					_updated = (CBool) CR2WTypeManager.Create("Bool", "updated", cr2w, this);
				}
				return _updated;
			}
			set
			{
				if (_updated == value)
				{
					return;
				}
				_updated = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get
			{
				if (_isTracked == null)
				{
					_isTracked = (CBool) CR2WTypeManager.Create("Bool", "isTracked", cr2w, this);
				}
				return _isTracked;
			}
			set
			{
				if (_isTracked == value)
				{
					return;
				}
				_isTracked = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("isOptional")] 
		public CBool IsOptional
		{
			get
			{
				if (_isOptional == null)
				{
					_isOptional = (CBool) CR2WTypeManager.Create("Bool", "isOptional", cr2w, this);
				}
				return _isOptional;
			}
			set
			{
				if (_isOptional == value)
				{
					return;
				}
				_isOptional = value;
				PropertySet(this);
			}
		}

		public ObjectiveEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
