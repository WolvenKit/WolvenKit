using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageTypePrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataDamageType>>();
			set => SetPropertyValue<CEnum<gamedataDamageType>>(value);
		}

		public DamageTypePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
