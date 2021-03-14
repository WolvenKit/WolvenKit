using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestMultiMapPin : gameJournalQuestMapPinBase
	{
		private CArray<NodeRef> _references;
		private CName _slotName;
		private gamemappinsMappinData _mappinData;
		private Vector3 _offset;
		private TweakDBID _uiAnimation;

		[Ordinal(3)] 
		[RED("references")] 
		public CArray<NodeRef> References
		{
			get
			{
				if (_references == null)
				{
					_references = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "references", cr2w, this);
				}
				return _references;
			}
			set
			{
				if (_references == value)
				{
					return;
				}
				_references = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mappinData")] 
		public gamemappinsMappinData MappinData
		{
			get
			{
				if (_mappinData == null)
				{
					_mappinData = (gamemappinsMappinData) CR2WTypeManager.Create("gamemappinsMappinData", "mappinData", cr2w, this);
				}
				return _mappinData;
			}
			set
			{
				if (_mappinData == value)
				{
					return;
				}
				_mappinData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("uiAnimation")] 
		public TweakDBID UiAnimation
		{
			get
			{
				if (_uiAnimation == null)
				{
					_uiAnimation = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "uiAnimation", cr2w, this);
				}
				return _uiAnimation;
			}
			set
			{
				if (_uiAnimation == value)
				{
					return;
				}
				_uiAnimation = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestMultiMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
