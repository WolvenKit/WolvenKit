using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseData : CVariable
	{
		private PSOwnerData _psOwnerData;
		private CArray<SDeviceTimetableEntry> _timeTable;
		private CInt32 _lights;

		[Ordinal(0)] 
		[RED("psOwnerData")] 
		public PSOwnerData PsOwnerData
		{
			get
			{
				if (_psOwnerData == null)
				{
					_psOwnerData = (PSOwnerData) CR2WTypeManager.Create("PSOwnerData", "psOwnerData", cr2w, this);
				}
				return _psOwnerData;
			}
			set
			{
				if (_psOwnerData == value)
				{
					return;
				}
				_psOwnerData = value;
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

		public FuseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
