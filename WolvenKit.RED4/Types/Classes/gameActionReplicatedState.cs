using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameActionReplicatedState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("replicationId")] 
		public CUInt32 ReplicationId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CUInt16 Type
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("startTimeStamp")] 
		public netTime StartTimeStamp
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(3)] 
		[RED("stopTimeStamp")] 
		public netTime StopTimeStamp
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(4)] 
		[RED("updateBucket")] 
		public CUInt8 UpdateBucket
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public gameActionReplicatedState()
		{
			Type = 72;
			StartTimeStamp = new() { MilliSecs = 18446744073709551615 };
			StopTimeStamp = new() { MilliSecs = 18446744073709551615 };
			UpdateBucket = 2;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
