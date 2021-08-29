using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionReplicatedState : RedBaseClass
	{
		private CUInt32 _replicationId;
		private CUInt16 _type;
		private netTime _startTimeStamp;
		private netTime _stopTimeStamp;
		private CUInt8 _updateBucket;

		[Ordinal(0)] 
		[RED("replicationId")] 
		public CUInt32 ReplicationId
		{
			get => GetProperty(ref _replicationId);
			set => SetProperty(ref _replicationId, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CUInt16 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("startTimeStamp")] 
		public netTime StartTimeStamp
		{
			get => GetProperty(ref _startTimeStamp);
			set => SetProperty(ref _startTimeStamp, value);
		}

		[Ordinal(3)] 
		[RED("stopTimeStamp")] 
		public netTime StopTimeStamp
		{
			get => GetProperty(ref _stopTimeStamp);
			set => SetProperty(ref _stopTimeStamp, value);
		}

		[Ordinal(4)] 
		[RED("updateBucket")] 
		public CUInt8 UpdateBucket
		{
			get => GetProperty(ref _updateBucket);
			set => SetProperty(ref _updateBucket, value);
		}
	}
}
