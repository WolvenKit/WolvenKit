using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HitHistoryItem : RedBaseClass
	{
		private CWeakHandle<gameObject> _instigator;
		private CFloat _hitTime;
		private CBool _isMelee;

		[Ordinal(0)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(1)] 
		[RED("hitTime")] 
		public CFloat HitTime
		{
			get => GetProperty(ref _hitTime);
			set => SetProperty(ref _hitTime, value);
		}

		[Ordinal(2)] 
		[RED("isMelee")] 
		public CBool IsMelee
		{
			get => GetProperty(ref _isMelee);
			set => SetProperty(ref _isMelee, value);
		}
	}
}
