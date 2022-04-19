using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEffectNode : worldNode
	{
		[Ordinal(4)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(5)] 
		[RED("streamingDistanceOverride")] 
		public CFloat StreamingDistanceOverride
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldEffectNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
