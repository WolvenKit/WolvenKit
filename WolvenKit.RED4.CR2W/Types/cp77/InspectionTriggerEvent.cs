using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InspectionTriggerEvent : redEvent
	{
		private CString _item;
		private CFloat _offset;
		private CFloat _adsOffset;
		private CFloat _timeToScan;
		private entEntityID _inspectedObjID;

		[Ordinal(0)] 
		[RED("item")] 
		public CString Item
		{
			get
			{
				if (_item == null)
				{
					_item = (CString) CR2WTypeManager.Create("String", "item", cr2w, this);
				}
				return _item;
			}
			set
			{
				if (_item == value)
				{
					return;
				}
				_item = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("inspectedObjID")] 
		public entEntityID InspectedObjID
		{
			get
			{
				if (_inspectedObjID == null)
				{
					_inspectedObjID = (entEntityID) CR2WTypeManager.Create("entEntityID", "inspectedObjID", cr2w, this);
				}
				return _inspectedObjID;
			}
			set
			{
				if (_inspectedObjID == value)
				{
					return;
				}
				_inspectedObjID = value;
				PropertySet(this);
			}
		}

		public InspectionTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
