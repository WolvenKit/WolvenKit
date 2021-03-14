using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterTimetableRequest : gameScriptableSystemRequest
	{
		private PSOwnerData _requesterData;
		private CArray<SDeviceTimetableEntry> _timeTable;
		private CInt32 _lights;

		[Ordinal(0)] 
		[RED("requesterData")] 
		public PSOwnerData RequesterData
		{
			get
			{
				if (_requesterData == null)
				{
					_requesterData = (PSOwnerData) CR2WTypeManager.Create("PSOwnerData", "requesterData", cr2w, this);
				}
				return _requesterData;
			}
			set
			{
				if (_requesterData == value)
				{
					return;
				}
				_requesterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeTable")] 
		public CArray<SDeviceTimetableEntry> TimeTable
		{
			get
			{
				if (_timeTable == null)
				{
					_timeTable = (CArray<SDeviceTimetableEntry>) CR2WTypeManager.Create("array:SDeviceTimetableEntry", "timeTable", cr2w, this);
				}
				return _timeTable;
			}
			set
			{
				if (_timeTable == value)
				{
					return;
				}
				_timeTable = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lights")] 
		public CInt32 Lights
		{
			get
			{
				if (_lights == null)
				{
					_lights = (CInt32) CR2WTypeManager.Create("Int32", "lights", cr2w, this);
				}
				return _lights;
			}
			set
			{
				if (_lights == value)
				{
					return;
				}
				_lights = value;
				PropertySet(this);
			}
		}

		public RegisterTimetableRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
