
namespace WolvenKit.RED4.Types
{
	public abstract partial class UpperBodyTransition : DefaultTransition
	{
		public UpperBodyTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
