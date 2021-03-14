using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRoadEditorObstacleSettings : CVariable
	{
		private CName _libraryName;
		private CFloat _offset;
		private CFloat _speed;
		private CUInt32 _segmentOffset;

		[Ordinal(0)] 
		[RED("libraryName")] 
		public CName LibraryName
		{
			get
			{
				if (_libraryName == null)
				{
					_libraryName = (CName) CR2WTypeManager.Create("CName", "libraryName", cr2w, this);
				}
				return _libraryName;
			}
			set
			{
				if (_libraryName == value)
				{
					return;
				}
				_libraryName = value;
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
		[RED("speed")] 
		public CFloat Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (CFloat) CR2WTypeManager.Create("Float", "speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("segmentOffset")] 
		public CUInt32 SegmentOffset
		{
			get
			{
				if (_segmentOffset == null)
				{
					_segmentOffset = (CUInt32) CR2WTypeManager.Create("Uint32", "segmentOffset", cr2w, this);
				}
				return _segmentOffset;
			}
			set
			{
				if (_segmentOffset == value)
				{
					return;
				}
				_segmentOffset = value;
				PropertySet(this);
			}
		}

		public gameuiRoadEditorObstacleSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
