
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIMandatoryComponents : AIRelatedComponents
	{
		public AIMandatoryComponents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
