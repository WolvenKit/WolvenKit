
namespace WolvenKit.RED4.Types
{
	public abstract partial class AnimFeatureCustom : animAnimFeature
	{
		public AnimFeatureCustom()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
