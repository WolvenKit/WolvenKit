using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_OverrideMaterial : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("material")] 
		public CResourceReference<IMaterial> Material
		{
			get => GetPropertyValue<CResourceReference<IMaterial>>();
			set => SetPropertyValue<CResourceReference<IMaterial>>(value);
		}

		public gameEffectExecutor_OverrideMaterial()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
