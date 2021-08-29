using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFuncCallEntry : ISerializable
	{
		private EngineTime _callTime;
		private CUInt32 _callId;

		[Ordinal(0)] 
		[RED("callTime")] 
		public EngineTime CallTime
		{
			get => GetProperty(ref _callTime);
			set => SetProperty(ref _callTime, value);
		}

		[Ordinal(1)] 
		[RED("callId")] 
		public CUInt32 CallId
		{
			get => GetProperty(ref _callId);
			set => SetProperty(ref _callId, value);
		}
	}
}
