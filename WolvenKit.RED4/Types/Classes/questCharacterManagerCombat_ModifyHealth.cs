using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerCombat_ModifyHealth : questICharacterManagerCombat_NodeSubType
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
		[RED("percent")] 
		public CFloat Percent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("setExactValue")] 
		public CBool SetExactValue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("noDamageIndicator")] 
		public CBool NoDamageIndicator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("damageSourceRef")] 
		public gameEntityReference DamageSourceRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questCharacterManagerCombat_ModifyHealth()
		{
			PuppetRef = new gameEntityReference { Names = new() };
			DamageSourceRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
