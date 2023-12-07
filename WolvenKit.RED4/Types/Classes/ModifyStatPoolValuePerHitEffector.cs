using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyStatPoolValuePerHitEffector : ModifyStatPoolValueEffector
	{
		[Ordinal(4)] 
		[RED("damageScaleFactor")] 
		public CFloat DamageScaleFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ModifyStatPoolValuePerHitEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
