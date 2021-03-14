using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForwardVehicleRaceUIEvent : redEvent
	{
		private CEnum<vehicleRaceUI> _mode;
		private CInt32 _maxPosition;
		private CInt32 _maxCheckpoints;

		[Ordinal(0)] 
		[RED("mode")] 
		public CEnum<vehicleRaceUI> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<vehicleRaceUI>) CR2WTypeManager.Create("vehicleRaceUI", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxPosition")] 
		public CInt32 MaxPosition
		{
			get
			{
				if (_maxPosition == null)
				{
					_maxPosition = (CInt32) CR2WTypeManager.Create("Int32", "maxPosition", cr2w, this);
				}
				return _maxPosition;
			}
			set
			{
				if (_maxPosition == value)
				{
					return;
				}
				_maxPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("maxCheckpoints")] 
		public CInt32 MaxCheckpoints
		{
			get
			{
				if (_maxCheckpoints == null)
				{
					_maxCheckpoints = (CInt32) CR2WTypeManager.Create("Int32", "maxCheckpoints", cr2w, this);
				}
				return _maxCheckpoints;
			}
			set
			{
				if (_maxCheckpoints == value)
				{
					return;
				}
				_maxCheckpoints = value;
				PropertySet(this);
			}
		}

		public ForwardVehicleRaceUIEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
