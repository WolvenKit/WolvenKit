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
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("entryID")] 
		public CUInt32 EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}

		public SDeviceTimetableEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
