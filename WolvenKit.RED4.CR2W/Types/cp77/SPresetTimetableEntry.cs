using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPresetTimetableEntry : CVariable
	{
		private SSimpleGameTime _time;
		private CBool _useTime;
		private CInt32 _arrayPosition;
		private CUInt32 _entryID;

		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("useTime")] 
		public CBool UseTime
		{
			get => GetProperty(ref _useTime);
			set => SetProperty(ref _useTime, value);
		}

		[Ordinal(2)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get => GetProperty(ref _arrayPosition);
			set => SetProperty(ref _arrayPosition, value);
		}

		[Ordinal(3)] 
		[RED("entryID")] 
		public CUInt32 EntryID
		{
			get => GetProperty(ref _entryID);
			set => SetProperty(ref _entryID, value);
		}

		public SPresetTimetableEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
