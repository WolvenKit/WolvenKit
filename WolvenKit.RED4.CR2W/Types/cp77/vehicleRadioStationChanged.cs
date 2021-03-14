using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleRadioStationChanged : redEvent
	{
		private CBool _isActive;
		private CUInt32 _radioIndex;
		private CName _radioStationName;
		private CName _radioSongName;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("radioIndex")] 
		public CUInt32 RadioIndex
		{
			get
			{
				if (_radioIndex == null)
				{
					_radioIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "radioIndex", cr2w, this);
				}
				return _radioIndex;
			}
			set
			{
				if (_radioIndex == value)
				{
					return;
				}
				_radioIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get
			{
				if (_radioStationName == null)
				{
					_radioStationName = (CName) CR2WTypeManager.Create("CName", "radioStationName", cr2w, this);
				}
				return _radioStationName;
			}
			set
			{
				if (_radioStationName == value)
				{
					return;
				}
				_radioStationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get
			{
				if (_radioSongName == null)
				{
					_radioSongName = (CName) CR2WTypeManager.Create("CName", "radioSongName", cr2w, this);
				}
				return _radioSongName;
			}
			set
			{
				if (_radioSongName == value)
				{
					return;
				}
				_radioSongName = value;
				PropertySet(this);
			}
		}

		public vehicleRadioStationChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
