using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEnemyThreatDetected : AIAIEvent
	{
		private CWeakHandle<entEntity> _owner;
		private CWeakHandle<entEntity> _threat;
		private CBool _status;

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
		[RED("status")] 
		public CBool Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}
	}
}
