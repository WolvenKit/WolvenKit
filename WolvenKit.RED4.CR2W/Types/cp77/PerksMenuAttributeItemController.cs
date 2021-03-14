using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksMenuAttributeItemController : inkWidgetLogicController
	{
		private inkWidgetReference _attributeDisplay;
		private inkImageWidgetReference _connectionLine;
		private CEnum<PerkMenuAttribute> _attributeType;
		private inkCompoundWidgetReference _skillsLevelsContainer;
		private CArray<inkWidgetReference> _proficiencyButtonRefs;
		private CBool _isReversed;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CHandle<PerksMenuAttributeDisplayController> _attributeDisplayController;
		private CBool _recentlyPurchased;
		private CBool _holdStarted;
		private CHandle<AttributeData> _data;
		private CHandle<inkanimProxy> _cool_in_proxy;
		private CHandle<inkanimProxy> _cool_out_proxy;

		[Ordinal(1)] 
		[RED("attributeDisplay")] 
		public inkWidgetReference AttributeDisplay
		{
			get
			{
				if (_attributeDisplay == null)
				{
					_attributeDisplay = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "attributeDisplay", cr2w, this);
				}
				return _attributeDisplay;
			}
			set
			{
				if (_attributeDisplay == value)
				{
					return;
				}
				_attributeDisplay = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("connectionLine")] 
		public inkImageWidgetReference ConnectionLine
		{
			get
			{
				if (_connectionLine == null)
				{
					_connectionLine = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "connectionLine", cr2w, this);
				}
				return _connectionLine;
			}
			set
			{
				if (_connectionLine == value)
				{
					return;
				}
				_connectionLine = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attributeType")] 
		public CEnum<PerkMenuAttribute> AttributeType
		{
			get
			{
				if (_attributeType == null)
				{
					_attributeType = (CEnum<PerkMenuAttribute>) CR2WTypeManager.Create("PerkMenuAttribute", "attributeType", cr2w, this);
				}
				return _attributeType;
			}
			set
			{
				if (_attributeType == value)
				{
					return;
				}
				_attributeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("skillsLevelsContainer")] 
		public inkCompoundWidgetReference SkillsLevelsContainer
		{
			get
			{
				if (_skillsLevelsContainer == null)
				{
					_skillsLevelsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "skillsLevelsContainer", cr2w, this);
				}
				return _skillsLevelsContainer;
			}
			set
			{
				if (_skillsLevelsContainer == value)
				{
					return;
				}
				_skillsLevelsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("proficiencyButtonRefs")] 
		public CArray<inkWidgetReference> ProficiencyButtonRefs
		{
			get
			{
				if (_proficiencyButtonRefs == null)
				{
					_proficiencyButtonRefs = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "proficiencyButtonRefs", cr2w, this);
				}
				return _proficiencyButtonRefs;
			}
			set
			{
				if (_proficiencyButtonRefs == value)
				{
					return;
				}
				_proficiencyButtonRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get
			{
				if (_isReversed == null)
				{
					_isReversed = (CBool) CR2WTypeManager.Create("Bool", "isReversed", cr2w, this);
				}
				return _isReversed;
			}
			set
			{
				if (_isReversed == value)
				{
					return;
				}
				_isReversed = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<PlayerDevelopmentDataManager>) CR2WTypeManager.Create("handle:PlayerDevelopmentDataManager", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("attributeDisplayController")] 
		public CHandle<PerksMenuAttributeDisplayController> AttributeDisplayController
		{
			get
			{
				if (_attributeDisplayController == null)
				{
					_attributeDisplayController = (CHandle<PerksMenuAttributeDisplayController>) CR2WTypeManager.Create("handle:PerksMenuAttributeDisplayController", "attributeDisplayController", cr2w, this);
				}
				return _attributeDisplayController;
			}
			set
			{
				if (_attributeDisplayController == value)
				{
					return;
				}
				_attributeDisplayController = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("recentlyPurchased")] 
		public CBool RecentlyPurchased
		{
			get
			{
				if (_recentlyPurchased == null)
				{
					_recentlyPurchased = (CBool) CR2WTypeManager.Create("Bool", "recentlyPurchased", cr2w, this);
				}
				return _recentlyPurchased;
			}
			set
			{
				if (_recentlyPurchased == value)
				{
					return;
				}
				_recentlyPurchased = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("holdStarted")] 
		public CBool HoldStarted
		{
			get
			{
				if (_holdStarted == null)
				{
					_holdStarted = (CBool) CR2WTypeManager.Create("Bool", "holdStarted", cr2w, this);
				}
				return _holdStarted;
			}
			set
			{
				if (_holdStarted == value)
				{
					return;
				}
				_holdStarted = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<AttributeData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<AttributeData>) CR2WTypeManager.Create("handle:AttributeData", "data", cr2w, this);
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

		[Ordinal(12)] 
		[RED("cool_in_proxy")] 
		public CHandle<inkanimProxy> Cool_in_proxy
		{
			get
			{
				if (_cool_in_proxy == null)
				{
					_cool_in_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "cool_in_proxy", cr2w, this);
				}
				return _cool_in_proxy;
			}
			set
			{
				if (_cool_in_proxy == value)
				{
					return;
				}
				_cool_in_proxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("cool_out_proxy")] 
		public CHandle<inkanimProxy> Cool_out_proxy
		{
			get
			{
				if (_cool_out_proxy == null)
				{
					_cool_out_proxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "cool_out_proxy", cr2w, this);
				}
				return _cool_out_proxy;
			}
			set
			{
				if (_cool_out_proxy == value)
				{
					return;
				}
				_cool_out_proxy = value;
				PropertySet(this);
			}
		}

		public PerksMenuAttributeItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
