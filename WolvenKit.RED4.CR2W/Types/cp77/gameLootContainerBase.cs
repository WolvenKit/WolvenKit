using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLootContainerBase : gameObject
	{
		private CBool _useAreaLoot;
		private CArray<TweakDBID> _lootTables;
		private TweakDBID _contentAssignment;
		private CBool _isIllegal;
		private CEnum<gamedataQuality> _lootQuality;
		private CBool _hasQuestItems;
		private CBool _wasLootInitalized;
		private CBool _isInIconForcedVisibilityRange;
		private CBool _isIconic;
		private CName _activeQualityRangeInteraction;

		[Ordinal(40)] 
		[RED("useAreaLoot")] 
		public CBool UseAreaLoot
		{
			get
			{
				if (_useAreaLoot == null)
				{
					_useAreaLoot = (CBool) CR2WTypeManager.Create("Bool", "useAreaLoot", cr2w, this);
				}
				return _useAreaLoot;
			}
			set
			{
				if (_useAreaLoot == value)
				{
					return;
				}
				_useAreaLoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get
			{
				if (_lootTables == null)
				{
					_lootTables = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "lootTables", cr2w, this);
				}
				return _lootTables;
			}
			set
			{
				if (_lootTables == value)
				{
					return;
				}
				_lootTables = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("contentAssignment")] 
		public TweakDBID ContentAssignment
		{
			get
			{
				if (_contentAssignment == null)
				{
					_contentAssignment = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "contentAssignment", cr2w, this);
				}
				return _contentAssignment;
			}
			set
			{
				if (_contentAssignment == value)
				{
					return;
				}
				_contentAssignment = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("isIllegal")] 
		public CBool IsIllegal
		{
			get
			{
				if (_isIllegal == null)
				{
					_isIllegal = (CBool) CR2WTypeManager.Create("Bool", "isIllegal", cr2w, this);
				}
				return _isIllegal;
			}
			set
			{
				if (_isIllegal == value)
				{
					return;
				}
				_isIllegal = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get
			{
				if (_lootQuality == null)
				{
					_lootQuality = (CEnum<gamedataQuality>) CR2WTypeManager.Create("gamedataQuality", "lootQuality", cr2w, this);
				}
				return _lootQuality;
			}
			set
			{
				if (_lootQuality == value)
				{
					return;
				}
				_lootQuality = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get
			{
				if (_hasQuestItems == null)
				{
					_hasQuestItems = (CBool) CR2WTypeManager.Create("Bool", "hasQuestItems", cr2w, this);
				}
				return _hasQuestItems;
			}
			set
			{
				if (_hasQuestItems == value)
				{
					return;
				}
				_hasQuestItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("wasLootInitalized")] 
		public CBool WasLootInitalized
		{
			get
			{
				if (_wasLootInitalized == null)
				{
					_wasLootInitalized = (CBool) CR2WTypeManager.Create("Bool", "wasLootInitalized", cr2w, this);
				}
				return _wasLootInitalized;
			}
			set
			{
				if (_wasLootInitalized == value)
				{
					return;
				}
				_wasLootInitalized = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get
			{
				if (_isInIconForcedVisibilityRange == null)
				{
					_isInIconForcedVisibilityRange = (CBool) CR2WTypeManager.Create("Bool", "isInIconForcedVisibilityRange", cr2w, this);
				}
				return _isInIconForcedVisibilityRange;
			}
			set
			{
				if (_isInIconForcedVisibilityRange == value)
				{
					return;
				}
				_isInIconForcedVisibilityRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get
			{
				if (_isIconic == null)
				{
					_isIconic = (CBool) CR2WTypeManager.Create("Bool", "isIconic", cr2w, this);
				}
				return _isIconic;
			}
			set
			{
				if (_isIconic == value)
				{
					return;
				}
				_isIconic = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get
			{
				if (_activeQualityRangeInteraction == null)
				{
					_activeQualityRangeInteraction = (CName) CR2WTypeManager.Create("CName", "activeQualityRangeInteraction", cr2w, this);
				}
				return _activeQualityRangeInteraction;
			}
			set
			{
				if (_activeQualityRangeInteraction == value)
				{
					return;
				}
				_activeQualityRangeInteraction = value;
				PropertySet(this);
			}
		}

		public gameLootContainerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
