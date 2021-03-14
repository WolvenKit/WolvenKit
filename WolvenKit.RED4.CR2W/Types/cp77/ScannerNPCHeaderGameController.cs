using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerNPCHeaderGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _nameText;
		private inkWidgetReference _skullIndicator;
		private inkImageWidgetReference _archetypeIcon;
		private CUInt32 _levelCallbackID;
		private CUInt32 _nameCallbackID;
		private CUInt32 _attitudeCallbackID;
		private CUInt32 _archtypeCallbackID;
		private CBool _isValidName;
		private CBool _isValidRarity;
		private CBool _isValidArchetype;

		[Ordinal(5)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get
			{
				if (_nameText == null)
				{
					_nameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nameText", cr2w, this);
				}
				return _nameText;
			}
			set
			{
				if (_nameText == value)
				{
					return;
				}
				_nameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("skullIndicator")] 
		public inkWidgetReference SkullIndicator
		{
			get
			{
				if (_skullIndicator == null)
				{
					_skullIndicator = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "skullIndicator", cr2w, this);
				}
				return _skullIndicator;
			}
			set
			{
				if (_skullIndicator == value)
				{
					return;
				}
				_skullIndicator = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("archetypeIcon")] 
		public inkImageWidgetReference ArchetypeIcon
		{
			get
			{
				if (_archetypeIcon == null)
				{
					_archetypeIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "archetypeIcon", cr2w, this);
				}
				return _archetypeIcon;
			}
			set
			{
				if (_archetypeIcon == value)
				{
					return;
				}
				_archetypeIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("levelCallbackID")] 
		public CUInt32 LevelCallbackID
		{
			get
			{
				if (_levelCallbackID == null)
				{
					_levelCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "levelCallbackID", cr2w, this);
				}
				return _levelCallbackID;
			}
			set
			{
				if (_levelCallbackID == value)
				{
					return;
				}
				_levelCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("nameCallbackID")] 
		public CUInt32 NameCallbackID
		{
			get
			{
				if (_nameCallbackID == null)
				{
					_nameCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "nameCallbackID", cr2w, this);
				}
				return _nameCallbackID;
			}
			set
			{
				if (_nameCallbackID == value)
				{
					return;
				}
				_nameCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("attitudeCallbackID")] 
		public CUInt32 AttitudeCallbackID
		{
			get
			{
				if (_attitudeCallbackID == null)
				{
					_attitudeCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "attitudeCallbackID", cr2w, this);
				}
				return _attitudeCallbackID;
			}
			set
			{
				if (_attitudeCallbackID == value)
				{
					return;
				}
				_attitudeCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("archtypeCallbackID")] 
		public CUInt32 ArchtypeCallbackID
		{
			get
			{
				if (_archtypeCallbackID == null)
				{
					_archtypeCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "archtypeCallbackID", cr2w, this);
				}
				return _archtypeCallbackID;
			}
			set
			{
				if (_archtypeCallbackID == value)
				{
					return;
				}
				_archtypeCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isValidName")] 
		public CBool IsValidName
		{
			get
			{
				if (_isValidName == null)
				{
					_isValidName = (CBool) CR2WTypeManager.Create("Bool", "isValidName", cr2w, this);
				}
				return _isValidName;
			}
			set
			{
				if (_isValidName == value)
				{
					return;
				}
				_isValidName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isValidRarity")] 
		public CBool IsValidRarity
		{
			get
			{
				if (_isValidRarity == null)
				{
					_isValidRarity = (CBool) CR2WTypeManager.Create("Bool", "isValidRarity", cr2w, this);
				}
				return _isValidRarity;
			}
			set
			{
				if (_isValidRarity == value)
				{
					return;
				}
				_isValidRarity = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("isValidArchetype")] 
		public CBool IsValidArchetype
		{
			get
			{
				if (_isValidArchetype == null)
				{
					_isValidArchetype = (CBool) CR2WTypeManager.Create("Bool", "isValidArchetype", cr2w, this);
				}
				return _isValidArchetype;
			}
			set
			{
				if (_isValidArchetype == value)
				{
					return;
				}
				_isValidArchetype = value;
				PropertySet(this);
			}
		}

		public ScannerNPCHeaderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
