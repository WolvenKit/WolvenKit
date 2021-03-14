using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioEvent : redEvent
	{
		private CBool _toggle;
		private CBool _setStation;
		private CInt32 _station;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get
			{
				if (_toggle == null)
				{
					_toggle = (CBool) CR2WTypeManager.Create("Bool", "toggle", cr2w, this);
				}
				return _toggle;
			}
			set
			{
				if (_toggle == value)
				{
					return;
				}
				_toggle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("setStation")] 
		public CBool SetStation
		{
			get
			{
				if (_setStation == null)
				{
					_setStation = (CBool) CR2WTypeManager.Create("Bool", "setStation", cr2w, this);
				}
				return _setStation;
			}
			set
			{
				if (_setStation == value)
				{
					return;
				}
				_setStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("station")] 
		public CInt32 Station
		{
			get
			{
				if (_station == null)
				{
					_station = (CInt32) CR2WTypeManager.Create("Int32", "station", cr2w, this);
				}
				return _station;
			}
			set
			{
				if (_station == value)
				{
					return;
				}
				_station = value;
				PropertySet(this);
			}
		}

		public VehicleRadioEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
