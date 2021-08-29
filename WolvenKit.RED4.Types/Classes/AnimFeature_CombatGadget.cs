using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CombatGadget : animAnimFeature
	{
		private CBool _isQuickthrow;
		private CBool _isChargedThrow;
		private CBool _isDetonated;

		[Ordinal(0)] 
		[RED("isQuickthrow")] 
		public CBool IsQuickthrow
		{
			get => GetProperty(ref _isQuickthrow);
			set => SetProperty(ref _isQuickthrow, value);
		}

		[Ordinal(1)] 
		[RED("isChargedThrow")] 
		public CBool IsChargedThrow
		{
			get => GetProperty(ref _isChargedThrow);
			set => SetProperty(ref _isChargedThrow, value);
		}

		[Ordinal(2)] 
		[RED("isDetonated")] 
		public CBool IsDetonated
		{
			get => GetProperty(ref _isDetonated);
			set => SetProperty(ref _isDetonated, value);
		}
	}
}
