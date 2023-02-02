using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPanzerEnemyAV : gameuiPanzerEnemy
	{
		[Ordinal(16)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("shotsAmount")] 
		public CUInt32 ShotsAmount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("longShotInterval")] 
		public CFloat LongShotInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("shortShotInterval")] 
		public CFloat ShortShotInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiPanzerEnemyAV()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
