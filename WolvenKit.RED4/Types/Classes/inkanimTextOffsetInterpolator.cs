
namespace WolvenKit.RED4.Types
{
	public partial class inkanimTextOffsetInterpolator : inkanimTextInterpolator
	{
		public inkanimTextOffsetInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
