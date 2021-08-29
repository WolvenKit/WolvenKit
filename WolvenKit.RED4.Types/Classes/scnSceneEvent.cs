using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneEvent : ISerializable
	{
		private scnSceneEventId _id;
		private CEnum<scnEventType> _type;
		private CUInt32 _startTime;
		private CUInt32 _duration;
		private CUInt8 _executionTagFlags;
		private CHandle<scnIScalingData> _scalingData;

		[Ordinal(0)] 
		[RED("id")] 
		public scnSceneEventId Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<scnEventType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(2)] 
		[RED("startTime")] 
		public CUInt32 StartTime
		{
			get => GetProperty(ref _startTime);
			set => SetProperty(ref _startTime, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CUInt32 Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("executionTagFlags")] 
		public CUInt8 ExecutionTagFlags
		{
			get => GetProperty(ref _executionTagFlags);
			set => SetProperty(ref _executionTagFlags, value);
		}

		[Ordinal(5)] 
		[RED("scalingData")] 
		public CHandle<scnIScalingData> ScalingData
		{
			get => GetProperty(ref _scalingData);
			set => SetProperty(ref _scalingData, value);
		}
	}
}
