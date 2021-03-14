using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWideItemDisplay : InventoryItemDisplay
	{
		private inkTextWidgetReference _itemNameText;
		private inkWidgetReference _rarityBackground;
		private inkWidgetReference _iconWrapper;
		private inkWidgetReference _statsWrapper;
		private inkTextWidgetReference _dpsText;
		private inkWidgetReference _damageIndicatorRef;
		private inkTextWidgetReference _additionalInfoText;
		private Vector2 _singleIconSize;
		private wCHandle<DamageTypeIndicator> _damageTypeIndicator;
		private CEnum<ItemAdditionalInfoType> _additionalInfoToShow;

		[Ordinal(21)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get
			{
				if (_itemNameText == null)
				{
					_itemNameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "itemNameText", cr2w, this);
				}
				return _itemNameText;
			}
			set
			{
				if (_itemNameText == value)
				{
					return;
				}
				_itemNameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("rarityBackground")] 
		public inkWidgetReference RarityBackground
		{
			get
			{
				if (_rarityBackground == null)
				{
					_rarityBackground = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rarityBackground", cr2w, this);
				}
				return _rarityBackground;
			}
			set
			{
				if (_rarityBackground == value)
				{
					return;
				}
				_rarityBackground = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("iconWrapper")] 
		public inkWidgetReference IconWrapper
		{
			get
			{
				if (_iconWrapper == null)
				{
					_iconWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "iconWrapper", cr2w, this);
				}
				return _iconWrapper;
			}
			set
			{
				if (_iconWrapper == value)
				{
					return;
				}
				_iconWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get
			{
				if (_statsWrapper == null)
				{
					_statsWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statsWrapper", cr2w, this);
				}
				return _statsWrapper;
			}
			set
			{
				if (_statsWrapper == value)
				{
					return;
				}
				_statsWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get
			{
				if (_dpsText == null)
				{
					_dpsText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "dpsText", cr2w, this);
				}
				return _dpsText;
			}
			set
			{
				if (_dpsText == value)
				{
					return;
				}
				_dpsText = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("damageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get
			{
				if (_damageIndicatorRef == null)
				{
					_damageIndicatorRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageIndicatorRef", cr2w, this);
				}
				return _damageIndicatorRef;
			}
			set
			{
				if (_damageIndicatorRef == value)
				{
					return;
				}
				_damageIndicatorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("additionalInfoText")] 
		public inkTextWidgetReference AdditionalInfoText
		{
			get
			{
				if (_additionalInfoText == null)
				{
					_additionalInfoText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "additionalInfoText", cr2w, this);
				}
				return _additionalInfoText;
			}
			set
			{
				if (_additionalInfoText == value)
				{
					return;
				}
				_additionalInfoText = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("singleIconSize")] 
		public Vector2 SingleIconSize
		{
			get
			{
				if (_singleIconSize == null)
				{
					_singleIconSize = (Vector2) CR2WTypeManager.Create("Vector2", "singleIconSize", cr2w, this);
				}
				return _singleIconSize;
			}
			set
			{
				if (_singleIconSize == value)
				{
					return;
				}
				_singleIconSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("damageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get
			{
				if (_damageTypeIndicator == null)
				{
					_damageTypeIndicator = (wCHandle<DamageTypeIndicator>) CR2WTypeManager.Create("whandle:DamageTypeIndicator", "damageTypeIndicator", cr2w, this);
				}
				return _damageTypeIndicator;
			}
			set
			{
				if (_damageTypeIndicator == value)
				{
					return;
				}
				_damageTypeIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("additionalInfoToShow")] 
		public CEnum<ItemAdditionalInfoType> AdditionalInfoToShow
		{
			get
			{
				if (_additionalInfoToShow == null)
				{
					_additionalInfoToShow = (CEnum<ItemAdditionalInfoType>) CR2WTypeManager.Create("ItemAdditionalInfoType", "additionalInfoToShow", cr2w, this);
				}
				return _additionalInfoToShow;
			}
			set
			{
				if (_additionalInfoToShow == value)
				{
					return;
				}
				_additionalInfoToShow = value;
				PropertySet(this);
			}
		}

		public InventoryWideItemDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
