using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class LeftHandCyberwareTransition : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("leftCWFeature")] 
		public CHandle<AnimFeature_LeftHandCyberware> LeftCWFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_LeftHandCyberware>>();
			set => SetPropertyValue<CHandle<AnimFeature_LeftHandCyberware>>(value);
		}

		[Ordinal(1)] 
		[RED("overchargeStatFlag")] 
		public CHandle<gameStatModifierData_Deprecated> OverchargeStatFlag
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		public LeftHandCyberwareTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
