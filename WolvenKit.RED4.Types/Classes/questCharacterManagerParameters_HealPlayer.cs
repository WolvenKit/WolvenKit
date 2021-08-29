using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerParameters_HealPlayer : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _heal;
		private CBool _removeStatusEffects;
		private CBool _removeBuffs;
		private CBool _removeDebuffs;
		private CBool _resetCyberdeckRAM;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("heal")] 
		public CBool Heal
		{
			get => GetProperty(ref _heal);
			set => SetProperty(ref _heal, value);
		}

		[Ordinal(3)] 
		[RED("removeStatusEffects")] 
		public CBool RemoveStatusEffects
		{
			get => GetProperty(ref _removeStatusEffects);
			set => SetProperty(ref _removeStatusEffects, value);
		}

		[Ordinal(4)] 
		[RED("removeBuffs")] 
		public CBool RemoveBuffs
		{
			get => GetProperty(ref _removeBuffs);
			set => SetProperty(ref _removeBuffs, value);
		}

		[Ordinal(5)] 
		[RED("removeDebuffs")] 
		public CBool RemoveDebuffs
		{
			get => GetProperty(ref _removeDebuffs);
			set => SetProperty(ref _removeDebuffs, value);
		}

		[Ordinal(6)] 
		[RED("resetCyberdeckRAM")] 
		public CBool ResetCyberdeckRAM
		{
			get => GetProperty(ref _resetCyberdeckRAM);
			set => SetProperty(ref _resetCyberdeckRAM, value);
		}
	}
}
