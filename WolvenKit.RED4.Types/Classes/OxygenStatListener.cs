using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OxygenStatListener : gameCustomValueStatPoolsListener
	{
		private CWeakHandle<PlayerPuppet> _ownerPuppet;
		private CHandle<worldEffectBlackboard> _oxygenVfxBlackboard;

		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<PlayerPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		[Ordinal(1)] 
		[RED("oxygenVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> OxygenVfxBlackboard
		{
			get => GetProperty(ref _oxygenVfxBlackboard);
			set => SetProperty(ref _oxygenVfxBlackboard, value);
		}
	}
}
