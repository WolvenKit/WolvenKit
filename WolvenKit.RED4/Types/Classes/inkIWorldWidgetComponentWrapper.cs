
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkIWorldWidgetComponentWrapper : RedBaseClass
	{
		public inkIWorldWidgetComponentWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
