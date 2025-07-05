using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class scnSceneEvent : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public scnSceneEventId Id
		{
			get => GetPropertyValue<scnSceneEventId>();
			set => SetPropertyValue<scnSceneEventId>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<scnEventType> Type
		{
			get => GetPropertyValue<CEnum<scnEventType>>();
			set => SetPropertyValue<CEnum<scnEventType>>(value);
		}

		[Ordinal(2)] 
		[RED("startTime")] 
		public CUInt32 StartTime
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CUInt32 Duration
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("executionTagFlags")] 
		public CUInt8 ExecutionTagFlags
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(5)] 
		[RED("scalingData")] 
		public CHandle<scnIScalingData> ScalingData
		{
			get => GetPropertyValue<CHandle<scnIScalingData>>();
			set => SetPropertyValue<CHandle<scnIScalingData>>(value);
		}

		public scnSceneEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
