using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_HealPlayer : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("heal")] 
		public CBool Heal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("removeStatusEffects")] 
		public CBool RemoveStatusEffects
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("removeBuffs")] 
		public CBool RemoveBuffs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("removeDebuffs")] 
		public CBool RemoveDebuffs
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("resetCyberdeckRAM")] 
		public CBool ResetCyberdeckRAM
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterManagerParameters_HealPlayer()
		{
			PuppetRef = new gameEntityReference { Names = new() };
			Heal = true;
			RemoveStatusEffects = true;
			RemoveBuffs = true;
			RemoveDebuffs = true;
			ResetCyberdeckRAM = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
