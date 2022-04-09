using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDamage : IScriptable
	{
		[Ordinal(0)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataDamageType>>();
			set => SetPropertyValue<CEnum<gamedataDamageType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameDamage()
		{
			DamageType = Enums.gamedataDamageType.Physical;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
