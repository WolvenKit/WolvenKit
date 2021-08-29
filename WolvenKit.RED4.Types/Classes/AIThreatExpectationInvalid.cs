using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatExpectationInvalid : AIAIEvent
	{
		private CWeakHandle<entEntity> _owner;
		private CWeakHandle<entEntity> _threat;
		private CUInt32 _threatId;

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<entEntity> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("threat")] 
		public CWeakHandle<entEntity> Threat
		{
			get => GetProperty(ref _threat);
			set => SetProperty(ref _threat, value);
		}

		[Ordinal(4)] 
		[RED("threatId")] 
		public CUInt32 ThreatId
		{
			get => GetProperty(ref _threatId);
			set => SetProperty(ref _threatId, value);
		}
	}
}
