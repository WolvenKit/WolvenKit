
namespace WolvenKit.RED4.Types
{
	public partial class inkanimTextKiroshiInterpolator : inkanimTextInterpolator
	{
		public inkanimTextKiroshiInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
