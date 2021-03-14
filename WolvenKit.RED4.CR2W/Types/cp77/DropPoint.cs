using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPoint : BasicDistractionDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private gameNewMappinID _mappinID;
		private CHandle<gameInventory> _inventory;

		[Ordinal(99)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get
			{
				if (_mappinID == null)
				{
					_mappinID = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "mappinID", cr2w, this);
				}
				return _mappinID;
			}
			set
			{
				if (_mappinID == value)
				{
					return;
				}
				_mappinID = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get
			{
				if (_inventory == null)
				{
					_inventory = (CHandle<gameInventory>) CR2WTypeManager.Create("handle:gameInventory", "inventory", cr2w, this);
				}
				return _inventory;
			}
			set
			{
				if (_inventory == value)
				{
					return;
				}
				_inventory = value;
				PropertySet(this);
			}
		}

		public DropPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
