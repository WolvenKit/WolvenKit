using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIThreatDefeated : AIAIEvent
	{
		private CWeakHandle<entEntity> _owner;
		private CWeakHandle<entEntity> _threat;
		private CUInt32 _id;
		private CBool _detected;

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
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(5)] 
		[RED("detected")] 
		public CBool Detected
		{
			get => GetProperty(ref _detected);
			set => SetProperty(ref _detected, value);
		}
	}
}
