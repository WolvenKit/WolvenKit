using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestObjectiveBase : gameJournalContainerEntry
	{
		private LocalizationString _description;
		private CUInt32 _counter;
		private CBool _optional;
		private NodeRef _locationPrefabRef;
		private TweakDBID _itemID;
		private CString _districtID;

		[Ordinal(2)] 
		[RED("description")] 
		public LocalizationString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "description", cr2w, this);
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

		[Ordinal(3)] 
		[RED("counter")] 
		public CUInt32 Counter
		{
			get
			{
				if (_counter == null)
				{
					_counter = (CUInt32) CR2WTypeManager.Create("Uint32", "counter", cr2w, this);
				}
				return _counter;
			}
			set
			{
				if (_counter == value)
				{
					return;
				}
				_counter = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("optional")] 
		public CBool Optional
		{
			get
			{
				if (_optional == null)
				{
					_optional = (CBool) CR2WTypeManager.Create("Bool", "optional", cr2w, this);
				}
				return _optional;
			}
			set
			{
				if (_optional == value)
				{
					return;
				}
				_optional = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("locationPrefabRef")] 
		public NodeRef LocationPrefabRef
		{
			get
			{
				if (_locationPrefabRef == null)
				{
					_locationPrefabRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "locationPrefabRef", cr2w, this);
				}
				return _locationPrefabRef;
			}
			set
			{
				if (_locationPrefabRef == value)
				{
					return;
				}
				_locationPrefabRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("districtID")] 
		public CString DistrictID
		{
			get
			{
				if (_districtID == null)
				{
					_districtID = (CString) CR2WTypeManager.Create("String", "districtID", cr2w, this);
				}
				return _districtID;
			}
			set
			{
				if (_districtID == value)
				{
					return;
				}
				_districtID = value;
				PropertySet(this);
			}
		}

		public gameJournalQuestObjectiveBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
