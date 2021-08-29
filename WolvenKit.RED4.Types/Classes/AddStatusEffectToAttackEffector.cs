using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddStatusEffectToAttackEffector : ModifyAttackEffector
	{
		private CBool _isRandom;
		private CFloat _applicationChance;
		private SHitStatusEffect _statusEffect;
		private CFloat _stacks;

		[Ordinal(0)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get => GetProperty(ref _isRandom);
			set => SetProperty(ref _isRandom, value);
		}

		[Ordinal(1)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get => GetProperty(ref _applicationChance);
			set => SetProperty(ref _applicationChance, value);
		}

		[Ordinal(2)] 
		[RED("statusEffect")] 
		public SHitStatusEffect StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		[Ordinal(3)] 
		[RED("stacks")] 
		public CFloat Stacks
		{
			get => GetProperty(ref _stacks);
			set => SetProperty(ref _stacks, value);
		}
	}
}
