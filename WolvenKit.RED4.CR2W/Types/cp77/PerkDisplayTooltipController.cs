using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayTooltipController : AGenericTooltipController
	{
		private inkWidgetReference _root;
		private inkTextWidgetReference _perkNameText;
		private inkWidgetReference _videoWrapper;
		private inkVideoWidgetReference _videoWidget;
		private inkTextWidgetReference _unlockStateText;
		private inkTextWidgetReference _perkTypeText;
		private inkWidgetReference _perkTypeWrapper;
		private inkWidgetReference _unlockInfoWrapper;
		private inkTextWidgetReference _unlockPointsText;
		private inkTextWidgetReference _unlockPointsDesc;
		private inkWidgetReference _unlockPerkWrapper;
		private inkTextWidgetReference _levelText;
		private inkTextWidgetReference _levelDescriptionText;
		private inkWidgetReference _nextLevelWrapper;
		private inkTextWidgetReference _nextLevelText;
		private inkTextWidgetReference _nextLevelDescriptionText;
		private inkTextWidgetReference _traitLevelGrowthText;
		private inkTextWidgetReference _unlockTraitPointsText;
		private inkWidgetReference _unlockTraitWrapper;
		private inkWidgetReference _holdToUpgradeHint;
		private CHandle<BasePerksMenuTooltipData> _data;

		[Ordinal(2)] 
		[RED("root")] 
		public inkWidgetReference Root_16
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
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

		[Ordinal(3)] 
		[RED("perkNameText")] 
		public inkTextWidgetReference PerkNameText
		{
			get
			{
				if (_perkNameText == null)
				{
					_perkNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "perkNameText", cr2w, this);
				}
				return _perkNameText;
			}
			set
			{
				if (_perkNameText == value)
				{
					return;
				}
				_perkNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("videoWrapper")] 
		public inkWidgetReference VideoWrapper
		{
			get
			{
				if (_videoWrapper == null)
				{
					_videoWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "videoWrapper", cr2w, this);
				}
				return _videoWrapper;
			}
			set
			{
				if (_videoWrapper == value)
				{
					return;
				}
				_videoWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get
			{
				if (_videoWidget == null)
				{
					_videoWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoWidget", cr2w, this);
				}
				return _videoWidget;
			}
			set
			{
				if (_videoWidget == value)
				{
					return;
				}
				_videoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("unlockStateText")] 
		public inkTextWidgetReference UnlockStateText
		{
			get
			{
				if (_unlockStateText == null)
				{
					_unlockStateText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "unlockStateText", cr2w, this);
				}
				return _unlockStateText;
			}
			set
			{
				if (_unlockStateText == value)
				{
					return;
				}
				_unlockStateText = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("perkTypeText")] 
		public inkTextWidgetReference PerkTypeText
		{
			get
			{
				if (_perkTypeText == null)
				{
					_perkTypeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "perkTypeText", cr2w, this);
				}
				return _perkTypeText;
			}
			set
			{
				if (_perkTypeText == value)
				{
					return;
				}
				_perkTypeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("perkTypeWrapper")] 
		public inkWidgetReference PerkTypeWrapper
		{
			get
			{
				if (_perkTypeWrapper == null)
				{
					_perkTypeWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "perkTypeWrapper", cr2w, this);
				}
				return _perkTypeWrapper;
			}
			set
			{
				if (_perkTypeWrapper == value)
				{
					return;
				}
				_perkTypeWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("unlockInfoWrapper")] 
		public inkWidgetReference UnlockInfoWrapper
		{
			get
			{
				if (_unlockInfoWrapper == null)
				{
					_unlockInfoWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "unlockInfoWrapper", cr2w, this);
				}
				return _unlockInfoWrapper;
			}
			set
			{
				if (_unlockInfoWrapper == value)
				{
					return;
				}
				_unlockInfoWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("unlockPointsText")] 
		public inkTextWidgetReference UnlockPointsText
		{
			get
			{
				if (_unlockPointsText == null)
				{
					_unlockPointsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "unlockPointsText", cr2w, this);
				}
				return _unlockPointsText;
			}
			set
			{
				if (_unlockPointsText == value)
				{
					return;
				}
				_unlockPointsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("unlockPointsDesc")] 
		public inkTextWidgetReference UnlockPointsDesc
		{
			get
			{
				if (_unlockPointsDesc == null)
				{
					_unlockPointsDesc = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "unlockPointsDesc", cr2w, this);
				}
				return _unlockPointsDesc;
			}
			set
			{
				if (_unlockPointsDesc == value)
				{
					return;
				}
				_unlockPointsDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("unlockPerkWrapper")] 
		public inkWidgetReference UnlockPerkWrapper
		{
			get
			{
				if (_unlockPerkWrapper == null)
				{
					_unlockPerkWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "unlockPerkWrapper", cr2w, this);
				}
				return _unlockPerkWrapper;
			}
			set
			{
				if (_unlockPerkWrapper == value)
				{
					return;
				}
				_unlockPerkWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get
			{
				if (_levelText == null)
				{
					_levelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelText", cr2w, this);
				}
				return _levelText;
			}
			set
			{
				if (_levelText == value)
				{
					return;
				}
				_levelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("levelDescriptionText")] 
		public inkTextWidgetReference LevelDescriptionText
		{
			get
			{
				if (_levelDescriptionText == null)
				{
					_levelDescriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelDescriptionText", cr2w, this);
				}
				return _levelDescriptionText;
			}
			set
			{
				if (_levelDescriptionText == value)
				{
					return;
				}
				_levelDescriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("nextLevelWrapper")] 
		public inkWidgetReference NextLevelWrapper
		{
			get
			{
				if (_nextLevelWrapper == null)
				{
					_nextLevelWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nextLevelWrapper", cr2w, this);
				}
				return _nextLevelWrapper;
			}
			set
			{
				if (_nextLevelWrapper == value)
				{
					return;
				}
				_nextLevelWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("nextLevelText")] 
		public inkTextWidgetReference NextLevelText
		{
			get
			{
				if (_nextLevelText == null)
				{
					_nextLevelText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nextLevelText", cr2w, this);
				}
				return _nextLevelText;
			}
			set
			{
				if (_nextLevelText == value)
				{
					return;
				}
				_nextLevelText = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("nextLevelDescriptionText")] 
		public inkTextWidgetReference NextLevelDescriptionText
		{
			get
			{
				if (_nextLevelDescriptionText == null)
				{
					_nextLevelDescriptionText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nextLevelDescriptionText", cr2w, this);
				}
				return _nextLevelDescriptionText;
			}
			set
			{
				if (_nextLevelDescriptionText == value)
				{
					return;
				}
				_nextLevelDescriptionText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("traitLevelGrowthText")] 
		public inkTextWidgetReference TraitLevelGrowthText
		{
			get
			{
				if (_traitLevelGrowthText == null)
				{
					_traitLevelGrowthText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "traitLevelGrowthText", cr2w, this);
				}
				return _traitLevelGrowthText;
			}
			set
			{
				if (_traitLevelGrowthText == value)
				{
					return;
				}
				_traitLevelGrowthText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("unlockTraitPointsText")] 
		public inkTextWidgetReference UnlockTraitPointsText
		{
			get
			{
				if (_unlockTraitPointsText == null)
				{
					_unlockTraitPointsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "unlockTraitPointsText", cr2w, this);
				}
				return _unlockTraitPointsText;
			}
			set
			{
				if (_unlockTraitPointsText == value)
				{
					return;
				}
				_unlockTraitPointsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("unlockTraitWrapper")] 
		public inkWidgetReference UnlockTraitWrapper
		{
			get
			{
				if (_unlockTraitWrapper == null)
				{
					_unlockTraitWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "unlockTraitWrapper", cr2w, this);
				}
				return _unlockTraitWrapper;
			}
			set
			{
				if (_unlockTraitWrapper == value)
				{
					return;
				}
				_unlockTraitWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("holdToUpgradeHint")] 
		public inkWidgetReference HoldToUpgradeHint
		{
			get
			{
				if (_holdToUpgradeHint == null)
				{
					_holdToUpgradeHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "holdToUpgradeHint", cr2w, this);
				}
				return _holdToUpgradeHint;
			}
			set
			{
				if (_holdToUpgradeHint == value)
				{
					return;
				}
				_holdToUpgradeHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("data")] 
		public CHandle<BasePerksMenuTooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<BasePerksMenuTooltipData>) CR2WTypeManager.Create("handle:BasePerksMenuTooltipData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public PerkDisplayTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
