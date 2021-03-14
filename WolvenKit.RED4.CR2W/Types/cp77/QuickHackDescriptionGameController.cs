using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackDescriptionGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _subHeader;
		private inkTextWidgetReference _tier;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _recompileTimer;
		private inkTextWidgetReference _duration;
		private inkTextWidgetReference _cooldown;
		private inkTextWidgetReference _uploadTime;
		private inkTextWidgetReference _memoryCost;
		private inkTextWidgetReference _memoryRawCost;
		private inkTextWidgetReference _categoryText;
		private inkWidgetReference _categoryContainer;
		private inkWidgetReference _damageWrapper;
		private inkTextWidgetReference _damageLabel;
		private inkTextWidgetReference _damageValue;
		private inkTextWidgetReference _healthPercentageLabel;
		private CUInt32 _quickHackDataCallbackID;
		private CHandle<QuickhackData> _selectedData;

		[Ordinal(5)] 
		[RED("subHeader")] 
		public inkTextWidgetReference SubHeader
		{
			get
			{
				if (_subHeader == null)
				{
					_subHeader = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "subHeader", cr2w, this);
				}
				return _subHeader;
			}
			set
			{
				if (_subHeader == value)
				{
					return;
				}
				_subHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("tier")] 
		public inkTextWidgetReference Tier
		{
			get
			{
				if (_tier == null)
				{
					_tier = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "tier", cr2w, this);
				}
				return _tier;
			}
			set
			{
				if (_tier == value)
				{
					return;
				}
				_tier = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get
			{
				if (_description == null)
				{
					_description = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("recompileTimer")] 
		public inkTextWidgetReference RecompileTimer
		{
			get
			{
				if (_recompileTimer == null)
				{
					_recompileTimer = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "recompileTimer", cr2w, this);
				}
				return _recompileTimer;
			}
			set
			{
				if (_recompileTimer == value)
				{
					return;
				}
				_recompileTimer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("duration")] 
		public inkTextWidgetReference Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("cooldown")] 
		public inkTextWidgetReference Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("uploadTime")] 
		public inkTextWidgetReference UploadTime
		{
			get
			{
				if (_uploadTime == null)
				{
					_uploadTime = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "uploadTime", cr2w, this);
				}
				return _uploadTime;
			}
			set
			{
				if (_uploadTime == value)
				{
					return;
				}
				_uploadTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("memoryCost")] 
		public inkTextWidgetReference MemoryCost
		{
			get
			{
				if (_memoryCost == null)
				{
					_memoryCost = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "memoryCost", cr2w, this);
				}
				return _memoryCost;
			}
			set
			{
				if (_memoryCost == value)
				{
					return;
				}
				_memoryCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("memoryRawCost")] 
		public inkTextWidgetReference MemoryRawCost
		{
			get
			{
				if (_memoryRawCost == null)
				{
					_memoryRawCost = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "memoryRawCost", cr2w, this);
				}
				return _memoryRawCost;
			}
			set
			{
				if (_memoryRawCost == value)
				{
					return;
				}
				_memoryRawCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("categoryText")] 
		public inkTextWidgetReference CategoryText
		{
			get
			{
				if (_categoryText == null)
				{
					_categoryText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "categoryText", cr2w, this);
				}
				return _categoryText;
			}
			set
			{
				if (_categoryText == value)
				{
					return;
				}
				_categoryText = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("categoryContainer")] 
		public inkWidgetReference CategoryContainer
		{
			get
			{
				if (_categoryContainer == null)
				{
					_categoryContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "categoryContainer", cr2w, this);
				}
				return _categoryContainer;
			}
			set
			{
				if (_categoryContainer == value)
				{
					return;
				}
				_categoryContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("damageWrapper")] 
		public inkWidgetReference DamageWrapper
		{
			get
			{
				if (_damageWrapper == null)
				{
					_damageWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "damageWrapper", cr2w, this);
				}
				return _damageWrapper;
			}
			set
			{
				if (_damageWrapper == value)
				{
					return;
				}
				_damageWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("damageLabel")] 
		public inkTextWidgetReference DamageLabel
		{
			get
			{
				if (_damageLabel == null)
				{
					_damageLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "damageLabel", cr2w, this);
				}
				return _damageLabel;
			}
			set
			{
				if (_damageLabel == value)
				{
					return;
				}
				_damageLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("damageValue")] 
		public inkTextWidgetReference DamageValue
		{
			get
			{
				if (_damageValue == null)
				{
					_damageValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "damageValue", cr2w, this);
				}
				return _damageValue;
			}
			set
			{
				if (_damageValue == value)
				{
					return;
				}
				_damageValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("healthPercentageLabel")] 
		public inkTextWidgetReference HealthPercentageLabel
		{
			get
			{
				if (_healthPercentageLabel == null)
				{
					_healthPercentageLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "healthPercentageLabel", cr2w, this);
				}
				return _healthPercentageLabel;
			}
			set
			{
				if (_healthPercentageLabel == value)
				{
					return;
				}
				_healthPercentageLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("quickHackDataCallbackID")] 
		public CUInt32 QuickHackDataCallbackID
		{
			get
			{
				if (_quickHackDataCallbackID == null)
				{
					_quickHackDataCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "quickHackDataCallbackID", cr2w, this);
				}
				return _quickHackDataCallbackID;
			}
			set
			{
				if (_quickHackDataCallbackID == value)
				{
					return;
				}
				_quickHackDataCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get
			{
				if (_selectedData == null)
				{
					_selectedData = (CHandle<QuickhackData>) CR2WTypeManager.Create("handle:QuickhackData", "selectedData", cr2w, this);
				}
				return _selectedData;
			}
			set
			{
				if (_selectedData == value)
				{
					return;
				}
				_selectedData = value;
				PropertySet(this);
			}
		}

		public QuickHackDescriptionGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
