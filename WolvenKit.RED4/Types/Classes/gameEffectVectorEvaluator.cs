using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectVectorEvaluator : ISerializable
	{
		[Ordinal(0)] 
		[RED("modifier")] 
		public CFloat Modifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEffectVectorEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
