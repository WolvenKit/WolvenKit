using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectableObjectComponent : gameScriptableComponent
	{
		private CName _factToAdd;
		private CString _itemID;
		private CFloat _offset;
		private CFloat _adsOffset;
		private CFloat _timeToScan;
		private CString _slot;

		[Ordinal(5)] 
		[RED("factToAdd")] 
		public CName FactToAdd
		{
			get
			{
				if (_factToAdd == null)
				{
					_factToAdd = (CName) CR2WTypeManager.Create("CName", "factToAdd", cr2w, this);
				}
				return _factToAdd;
			}
			set
			{
				if (_factToAdd == value)
				{
					return;
				}
				_factToAdd = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("itemID")] 
		public CString ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (CString) CR2WTypeManager.Create("String", "itemID", cr2w, this);
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
		[RED("offset")] 
		public CFloat Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CFloat) CR2WTypeManager.Create("Float", "offset", cr2w, this);
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

		[Ordinal(8)] 
		[RED("adsOffset")] 
		public CFloat AdsOffset
		{
			get
			{
				if (_adsOffset == null)
				{
					_adsOffset = (CFloat) CR2WTypeManager.Create("Float", "adsOffset", cr2w, this);
				}
				return _adsOffset;
			}
			set
			{
				if (_adsOffset == value)
				{
					return;
				}
				_adsOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("timeToScan")] 
		public CFloat TimeToScan
		{
			get
			{
				if (_timeToScan == null)
				{
					_timeToScan = (CFloat) CR2WTypeManager.Create("Float", "timeToScan", cr2w, this);
				}
				return _timeToScan;
			}
			set
			{
				if (_timeToScan == value)
				{
					return;
				}
				_timeToScan = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("slot")] 
		public CString Slot
		{
			get
			{
				if (_slot == null)
				{
					_slot = (CString) CR2WTypeManager.Create("String", "slot", cr2w, this);
				}
				return _slot;
			}
			set
			{
				if (_slot == value)
				{
					return;
				}
				_slot = value;
				PropertySet(this);
			}
		}

		public InspectableObjectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
