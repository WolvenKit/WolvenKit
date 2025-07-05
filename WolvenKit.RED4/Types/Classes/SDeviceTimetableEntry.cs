using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SDeviceTimetableEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get => GetPropertyValue<SSimpleGameTime>();
			set => SetPropertyValue<SSimpleGameTime>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EDeviceStatus> State
		{
			get => GetPropertyValue<CEnum<EDeviceStatus>>();
			set => SetPropertyValue<CEnum<EDeviceStatus>>(value);
		}

		[Ordinal(2)] 
		[RED("entryID")] 
		public CUInt32 EntryID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public SDeviceTimetableEntry()
		{
			Time = new SSimpleGameTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
