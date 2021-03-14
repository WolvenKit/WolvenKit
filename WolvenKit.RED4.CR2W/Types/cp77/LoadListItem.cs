using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoadListItem : AnimatedListItemController
	{
		private inkImageWidgetReference _imageReplacement;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _labelDate;
		private inkTextWidgetReference _type;
		private inkTextWidgetReference _quest;
		private inkTextWidgetReference _level;
		private inkImageWidgetReference _lifepath;
		private inkTextWidgetReference _playTime;
		private inkTextWidgetReference _characterLevel;
		private inkTextWidgetReference _characterLevelLabel;
		private inkWidgetReference _emptySlotWrapper;
		private inkWidgetReference _wrapper;
		private CInt32 _index;
		private CBool _emptySlot;
		private CBool _validSlot;
		private CUInt64 _initialLoadingID;

		[Ordinal(30)] 
		[RED("imageReplacement")] 
		public inkImageWidgetReference ImageReplacement
		{
			get
			{
				if (_imageReplacement == null)
				{
					_imageReplacement = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "imageReplacement", cr2w, this);
				}
				return _imageReplacement;
			}
			set
			{
				if (_imageReplacement == value)
				{
					return;
				}
				_imageReplacement = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get
			{
				if (_labelDate == null)
				{
					_labelDate = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "labelDate", cr2w, this);
				}
				return _labelDate;
			}
			set
			{
				if (_labelDate == value)
				{
					return;
				}
				_labelDate = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("type")] 
		public inkTextWidgetReference Type
		{
			get
			{
				if (_type == null)
				{
					_type = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "type", cr2w, this);
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

		[Ordinal(34)] 
		[RED("quest")] 
		public inkTextWidgetReference Quest
		{
			get
			{
				if (_quest == null)
				{
					_quest = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quest", cr2w, this);
				}
				return _quest;
			}
			set
			{
				if (_quest == value)
				{
					return;
				}
				_quest = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get
			{
				if (_level == null)
				{
					_level = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get
			{
				if (_lifepath == null)
				{
					_lifepath = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "lifepath", cr2w, this);
				}
				return _lifepath;
			}
			set
			{
				if (_lifepath == value)
				{
					return;
				}
				_lifepath = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
		{
			get
			{
				if (_playTime == null)
				{
					_playTime = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playTime", cr2w, this);
				}
				return _playTime;
			}
			set
			{
				if (_playTime == value)
				{
					return;
				}
				_playTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("characterLevel")] 
		public inkTextWidgetReference CharacterLevel
		{
			get
			{
				if (_characterLevel == null)
				{
					_characterLevel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "characterLevel", cr2w, this);
				}
				return _characterLevel;
			}
			set
			{
				if (_characterLevel == value)
				{
					return;
				}
				_characterLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("characterLevelLabel")] 
		public inkTextWidgetReference CharacterLevelLabel
		{
			get
			{
				if (_characterLevelLabel == null)
				{
					_characterLevelLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "characterLevelLabel", cr2w, this);
				}
				return _characterLevelLabel;
			}
			set
			{
				if (_characterLevelLabel == value)
				{
					return;
				}
				_characterLevelLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("emptySlotWrapper")] 
		public inkWidgetReference EmptySlotWrapper
		{
			get
			{
				if (_emptySlotWrapper == null)
				{
					_emptySlotWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "emptySlotWrapper", cr2w, this);
				}
				return _emptySlotWrapper;
			}
			set
			{
				if (_emptySlotWrapper == value)
				{
					return;
				}
				_emptySlotWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get
			{
				if (_wrapper == null)
				{
					_wrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "wrapper", cr2w, this);
				}
				return _wrapper;
			}
			set
			{
				if (_wrapper == value)
				{
					return;
				}
				_wrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("emptySlot")] 
		public CBool EmptySlot
		{
			get
			{
				if (_emptySlot == null)
				{
					_emptySlot = (CBool) CR2WTypeManager.Create("Bool", "emptySlot", cr2w, this);
				}
				return _emptySlot;
			}
			set
			{
				if (_emptySlot == value)
				{
					return;
				}
				_emptySlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("validSlot")] 
		public CBool ValidSlot
		{
			get
			{
				if (_validSlot == null)
				{
					_validSlot = (CBool) CR2WTypeManager.Create("Bool", "validSlot", cr2w, this);
				}
				return _validSlot;
			}
			set
			{
				if (_validSlot == value)
				{
					return;
				}
				_validSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("initialLoadingID")] 
		public CUInt64 InitialLoadingID
		{
			get
			{
				if (_initialLoadingID == null)
				{
					_initialLoadingID = (CUInt64) CR2WTypeManager.Create("Uint64", "initialLoadingID", cr2w, this);
				}
				return _initialLoadingID;
			}
			set
			{
				if (_initialLoadingID == value)
				{
					return;
				}
				_initialLoadingID = value;
				PropertySet(this);
			}
		}

		public LoadListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
