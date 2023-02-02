
namespace WolvenKit.RED4.Types
{
	public partial class inkanimTextValueProgressInterpolator : inkanimTextInterpolator
	{
		public inkanimTextValueProgressInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
