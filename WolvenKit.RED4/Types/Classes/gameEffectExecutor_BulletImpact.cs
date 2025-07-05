using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_BulletImpact : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("isBackfaceImpact")] 
		public CBool IsBackfaceImpact
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("noAudio")] 
		public CBool NoAudio
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isMeleeAttack")] 
		public CBool IsMeleeAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectExecutor_BulletImpact()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
