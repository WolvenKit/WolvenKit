using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEnemyPushedToSquad : AIAIEvent
	{
		private CWeakHandle<entEntity> _threat;

		[Ordinal(2)] 
		[RED("threat")] 
		public CWeakHandle<entEntity> Threat
		{
			get => GetProperty(ref _threat);
			set => SetProperty(ref _threat, value);
		}
	}
}
