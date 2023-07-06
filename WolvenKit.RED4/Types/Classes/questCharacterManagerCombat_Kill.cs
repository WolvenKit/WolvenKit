using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerCombat_Kill : questICharacterManagerCombat_NodeSubType
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
		[RED("noAnimation")] 
		public CBool NoAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("noRagdoll")] 
		public CBool NoRagdoll
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("skipDefeatedState")] 
		public CBool SkipDefeatedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("doDismemberment")] 
		public CBool DoDismemberment
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("bodyPart")] 
		public CBitField<physicsRagdollBodyPartE> BodyPart
		{
			get => GetPropertyValue<CBitField<physicsRagdollBodyPartE>>();
			set => SetPropertyValue<CBitField<physicsRagdollBodyPartE>>(value);
		}

		[Ordinal(7)] 
		[RED("woundType")] 
		public CBitField<entdismembermentWoundTypeE> WoundType
		{
			get => GetPropertyValue<CBitField<entdismembermentWoundTypeE>>();
			set => SetPropertyValue<CBitField<entdismembermentWoundTypeE>>(value);
		}

		[Ordinal(8)] 
		[RED("dismembermentStrenght")] 
		public CFloat DismembermentStrenght
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questCharacterManagerCombat_Kill()
		{
			PuppetRef = new gameEntityReference { Names = new() };
			SkipDefeatedState = true;
			WoundType = Enums.entdismembermentWoundTypeE.COARSE;
			DismembermentStrenght = 8.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
