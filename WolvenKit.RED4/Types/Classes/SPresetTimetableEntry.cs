using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SPresetTimetableEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get => GetPropertyValue<SSimpleGameTime>();
			set => SetPropertyValue<SSimpleGameTime>(value);
		}

		[Ordinal(1)] 
		[RED("useTime")] 
		public CBool UseTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("entryID")] 
		public CUInt32 EntryID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public SPresetTimetableEntry()
		{
			Time = new SSimpleGameTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
