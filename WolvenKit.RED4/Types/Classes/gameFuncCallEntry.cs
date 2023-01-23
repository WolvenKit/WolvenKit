using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFuncCallEntry : ISerializable
	{
		[Ordinal(0)] 
		[RED("callTime")] 
		public EngineTime CallTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(1)] 
		[RED("callId")] 
		public CUInt32 CallId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameFuncCallEntry()
		{
			CallTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
