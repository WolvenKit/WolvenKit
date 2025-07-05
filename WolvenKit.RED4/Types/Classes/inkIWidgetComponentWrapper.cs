
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkIWidgetComponentWrapper : RedBaseClass
	{
		public inkIWidgetComponentWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
