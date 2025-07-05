
namespace WolvenKit.RED4.Types
{
	public partial class inkanimTextReplaceInterpolator : inkanimTextInterpolator
	{
		public inkanimTextReplaceInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
