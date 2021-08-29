using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakspotRecordData : RedBaseClass
	{
		private CBool _isInvulnerable;
		private TweakDBID _slotID;
		private CBool _reducedMeleeDamage;

		[Ordinal(0)] 
		[RED("isInvulnerable")] 
		public CBool IsInvulnerable
		{
			get => GetProperty(ref _isInvulnerable);
			set => SetProperty(ref _isInvulnerable, value);
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(2)] 
		[RED("reducedMeleeDamage")] 
		public CBool ReducedMeleeDamage
		{
			get => GetProperty(ref _reducedMeleeDamage);
			set => SetProperty(ref _reducedMeleeDamage, value);
		}
	}
}
