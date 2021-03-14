using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDeviceTimetableEntry : CVariable
	{
		private SSimpleGameTime _time;
		private CEnum<EDeviceStatus> _state;
		private CUInt32 _entryID;

		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get
			{
				if (_time == null)
				{
					_time = (SSimpleGameTime) CR2WTypeManager.Create("SSimpleGameTime", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<EDeviceStatus>) CR2WTypeManager.Create("EDeviceStatus", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryID")] 
		public CUInt32 EntryID
		{
			get
			{
				if (_entryID == null)
				{
					_entryID = (CUInt32) CR2WTypeManager.Create("Uint32", "entryID", cr2w, this);
				}
				return _entryID;
			}
			set
			{
				if (_entryID == value)
				{
					return;
				}
				_entryID = value;
				PropertySet(this);
			}
		}

		public SDeviceTimetableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
