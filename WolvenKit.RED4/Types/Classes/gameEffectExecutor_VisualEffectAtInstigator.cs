using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectExecutor_VisualEffectAtInstigator : gameEffectExecutor
	{
		[Ordinal(1)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		public gameEffectExecutor_VisualEffectAtInstigator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
