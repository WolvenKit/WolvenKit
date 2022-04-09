using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDelayedFunctionsScheduler : ISerializable
	{
		[Ordinal(0)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("currentTime")] 
		public EngineTime CurrentTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(2)] 
		[RED("nextCallId")] 
		public CUInt32 NextCallId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameDelayedFunctionsScheduler()
		{
			CurrentTime = new();
			NextCallId = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
