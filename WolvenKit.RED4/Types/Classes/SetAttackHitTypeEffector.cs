using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetAttackHitTypeEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get => GetPropertyValue<CEnum<gameuiHitType>>();
			set => SetPropertyValue<CEnum<gameuiHitType>>(value);
		}

		public SetAttackHitTypeEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
