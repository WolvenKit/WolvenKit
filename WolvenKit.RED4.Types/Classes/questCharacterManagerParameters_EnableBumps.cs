using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_EnableBumps : questICharacterManagerParameters_NodeSubType
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
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("policy")] 
		public CEnum<AIinfluenceEBumpPolicy> Policy
		{
			get => GetPropertyValue<CEnum<AIinfluenceEBumpPolicy>>();
			set => SetPropertyValue<CEnum<AIinfluenceEBumpPolicy>>(value);
		}

		public questCharacterManagerParameters_EnableBumps()
		{
			PuppetRef = new() { Names = new() };
			Enable = true;
			Policy = Enums.AIinfluenceEBumpPolicy.Lean;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
