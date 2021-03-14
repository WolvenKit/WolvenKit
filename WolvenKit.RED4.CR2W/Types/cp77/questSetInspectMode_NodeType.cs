using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetInspectMode_NodeType : questIInteractiveObjectManagerNodeType
	{
		private CString _objectID;
		private CFloat _startingOffset;
		private CFloat _zoomOffset;
		private CFloat _timeInterval;

		[Ordinal(0)] 
		[RED("objectID")] 
		public CString ObjectID
		{
			get
			{
				if (_objectID == null)
				{
					_objectID = (CString) CR2WTypeManager.Create("String", "objectID", cr2w, this);
				}
				return _objectID;
			}
			set
			{
				if (_objectID == value)
				{
					return;
				}
				_objectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startingOffset")] 
		public CFloat StartingOffset
		{
			get
			{
				if (_startingOffset == null)
				{
					_startingOffset = (CFloat) CR2WTypeManager.Create("Float", "startingOffset", cr2w, this);
				}
				return _startingOffset;
			}
			set
			{
				if (_startingOffset == value)
				{
					return;
				}
				_startingOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("zoomOffset")] 
		public CFloat ZoomOffset
		{
			get
			{
				if (_zoomOffset == null)
				{
					_zoomOffset = (CFloat) CR2WTypeManager.Create("Float", "zoomOffset", cr2w, this);
				}
				return _zoomOffset;
			}
			set
			{
				if (_zoomOffset == value)
				{
					return;
				}
				_zoomOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get
			{
				if (_timeInterval == null)
				{
					_timeInterval = (CFloat) CR2WTypeManager.Create("Float", "timeInterval", cr2w, this);
				}
				return _timeInterval;
			}
			set
			{
				if (_timeInterval == value)
				{
					return;
				}
				_timeInterval = value;
				PropertySet(this);
			}
		}

		public questSetInspectMode_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
