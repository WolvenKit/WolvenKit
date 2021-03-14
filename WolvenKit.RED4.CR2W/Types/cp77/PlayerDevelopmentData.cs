using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentData : IScriptable
	{
		private wCHandle<gameObject> _owner;
		private entEntityID _ownerID;
		private CArray<SExperiencePoints> _queuedCombatExp;
		private CArray<SProficiency> _proficiencies;
		private CArray<SAttribute> _attributes;
		private CArray<SPerkArea> _perkAreas;
		private CArray<STrait> _traits;
		private CArray<SDevelopmentPoints> _devPoints;
		private CArray<CHandle<SkillCheckPrereqState>> _skillPrereqs;
		private CArray<CHandle<StatCheckPrereqState>> _statPrereqs;
		private CArray<ItemRecipe> _knownRecipes;
		private CInt32 _highestCompletedMinigameLevel;
		private CInt32 _startingLevel;
		private CInt32 _startingExperience;
		private CEnum<gamedataLifePath> _lifePath;
		private CBool _displayActivityLog;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("queuedCombatExp")] 
		public CArray<SExperiencePoints> QueuedCombatExp
		{
			get
			{
				if (_queuedCombatExp == null)
				{
					_queuedCombatExp = (CArray<SExperiencePoints>) CR2WTypeManager.Create("array:SExperiencePoints", "queuedCombatExp", cr2w, this);
				}
				return _queuedCombatExp;
			}
			set
			{
				if (_queuedCombatExp == value)
				{
					return;
				}
				_queuedCombatExp = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("proficiencies")] 
		public CArray<SProficiency> Proficiencies
		{
			get
			{
				if (_proficiencies == null)
				{
					_proficiencies = (CArray<SProficiency>) CR2WTypeManager.Create("array:SProficiency", "proficiencies", cr2w, this);
				}
				return _proficiencies;
			}
			set
			{
				if (_proficiencies == value)
				{
					return;
				}
				_proficiencies = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attributes")] 
		public CArray<SAttribute> Attributes
		{
			get
			{
				if (_attributes == null)
				{
					_attributes = (CArray<SAttribute>) CR2WTypeManager.Create("array:SAttribute", "attributes", cr2w, this);
				}
				return _attributes;
			}
			set
			{
				if (_attributes == value)
				{
					return;
				}
				_attributes = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("perkAreas")] 
		public CArray<SPerkArea> PerkAreas
		{
			get
			{
				if (_perkAreas == null)
				{
					_perkAreas = (CArray<SPerkArea>) CR2WTypeManager.Create("array:SPerkArea", "perkAreas", cr2w, this);
				}
				return _perkAreas;
			}
			set
			{
				if (_perkAreas == value)
				{
					return;
				}
				_perkAreas = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("traits")] 
		public CArray<STrait> Traits
		{
			get
			{
				if (_traits == null)
				{
					_traits = (CArray<STrait>) CR2WTypeManager.Create("array:STrait", "traits", cr2w, this);
				}
				return _traits;
			}
			set
			{
				if (_traits == value)
				{
					return;
				}
				_traits = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("devPoints")] 
		public CArray<SDevelopmentPoints> DevPoints
		{
			get
			{
				if (_devPoints == null)
				{
					_devPoints = (CArray<SDevelopmentPoints>) CR2WTypeManager.Create("array:SDevelopmentPoints", "devPoints", cr2w, this);
				}
				return _devPoints;
			}
			set
			{
				if (_devPoints == value)
				{
					return;
				}
				_devPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("skillPrereqs")] 
		public CArray<CHandle<SkillCheckPrereqState>> SkillPrereqs
		{
			get
			{
				if (_skillPrereqs == null)
				{
					_skillPrereqs = (CArray<CHandle<SkillCheckPrereqState>>) CR2WTypeManager.Create("array:handle:SkillCheckPrereqState", "skillPrereqs", cr2w, this);
				}
				return _skillPrereqs;
			}
			set
			{
				if (_skillPrereqs == value)
				{
					return;
				}
				_skillPrereqs = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("statPrereqs")] 
		public CArray<CHandle<StatCheckPrereqState>> StatPrereqs
		{
			get
			{
				if (_statPrereqs == null)
				{
					_statPrereqs = (CArray<CHandle<StatCheckPrereqState>>) CR2WTypeManager.Create("array:handle:StatCheckPrereqState", "statPrereqs", cr2w, this);
				}
				return _statPrereqs;
			}
			set
			{
				if (_statPrereqs == value)
				{
					return;
				}
				_statPrereqs = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("knownRecipes")] 
		public CArray<ItemRecipe> KnownRecipes
		{
			get
			{
				if (_knownRecipes == null)
				{
					_knownRecipes = (CArray<ItemRecipe>) CR2WTypeManager.Create("array:ItemRecipe", "knownRecipes", cr2w, this);
				}
				return _knownRecipes;
			}
			set
			{
				if (_knownRecipes == value)
				{
					return;
				}
				_knownRecipes = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("highestCompletedMinigameLevel")] 
		public CInt32 HighestCompletedMinigameLevel
		{
			get
			{
				if (_highestCompletedMinigameLevel == null)
				{
					_highestCompletedMinigameLevel = (CInt32) CR2WTypeManager.Create("Int32", "highestCompletedMinigameLevel", cr2w, this);
				}
				return _highestCompletedMinigameLevel;
			}
			set
			{
				if (_highestCompletedMinigameLevel == value)
				{
					return;
				}
				_highestCompletedMinigameLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("startingLevel")] 
		public CInt32 StartingLevel
		{
			get
			{
				if (_startingLevel == null)
				{
					_startingLevel = (CInt32) CR2WTypeManager.Create("Int32", "startingLevel", cr2w, this);
				}
				return _startingLevel;
			}
			set
			{
				if (_startingLevel == value)
				{
					return;
				}
				_startingLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("startingExperience")] 
		public CInt32 StartingExperience
		{
			get
			{
				if (_startingExperience == null)
				{
					_startingExperience = (CInt32) CR2WTypeManager.Create("Int32", "startingExperience", cr2w, this);
				}
				return _startingExperience;
			}
			set
			{
				if (_startingExperience == value)
				{
					return;
				}
				_startingExperience = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("lifePath")] 
		public CEnum<gamedataLifePath> LifePath
		{
			get
			{
				if (_lifePath == null)
				{
					_lifePath = (CEnum<gamedataLifePath>) CR2WTypeManager.Create("gamedataLifePath", "lifePath", cr2w, this);
				}
				return _lifePath;
			}
			set
			{
				if (_lifePath == value)
				{
					return;
				}
				_lifePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("displayActivityLog")] 
		public CBool DisplayActivityLog
		{
			get
			{
				if (_displayActivityLog == null)
				{
					_displayActivityLog = (CBool) CR2WTypeManager.Create("Bool", "displayActivityLog", cr2w, this);
				}
				return _displayActivityLog;
			}
			set
			{
				if (_displayActivityLog == value)
				{
					return;
				}
				_displayActivityLog = value;
				PropertySet(this);
			}
		}

		public PlayerDevelopmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
