using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIEntityLost : AIAIEvent
	{
		private CWeakHandle<entEntity> _spotter;
		private CWeakHandle<entEntity> _spotted;
		private CBool _isHostile;

		[Ordinal(2)] 
		[RED("spotter")] 
		public CWeakHandle<entEntity> Spotter
		{
			get => GetProperty(ref _spotter);
			set => SetProperty(ref _spotter, value);
		}

		[Ordinal(3)] 
		[RED("spotted")] 
		public CWeakHandle<entEntity> Spotted
		{
			get => GetProperty(ref _spotted);
			set => SetProperty(ref _spotted, value);
		}

		[Ordinal(4)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetProperty(ref _isHostile);
			set => SetProperty(ref _isHostile, value);
		}
	}
}
