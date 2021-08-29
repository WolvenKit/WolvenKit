using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectExecutor_BulletImpact : gameEffectExecutor
	{
		private CBool _isBackfaceImpact;
		private CBool _noAudio;
		private CBool _isMeleeAttack;

		[Ordinal(1)] 
		[RED("isBackfaceImpact")] 
		public CBool IsBackfaceImpact
		{
			get => GetProperty(ref _isBackfaceImpact);
			set => SetProperty(ref _isBackfaceImpact, value);
		}

		[Ordinal(2)] 
		[RED("noAudio")] 
		public CBool NoAudio
		{
			get => GetProperty(ref _noAudio);
			set => SetProperty(ref _noAudio, value);
		}

		[Ordinal(3)] 
		[RED("isMeleeAttack")] 
		public CBool IsMeleeAttack
		{
			get => GetProperty(ref _isMeleeAttack);
			set => SetProperty(ref _isMeleeAttack, value);
		}
	}
}
