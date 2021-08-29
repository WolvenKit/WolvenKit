using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SPresetTimetableEntry : RedBaseClass
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
	}
}
