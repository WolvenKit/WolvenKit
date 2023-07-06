
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkIWorldFluffWidgetComponentWrapper : inkIWorldWidgetComponentWrapper
	{
		public inkIWorldFluffWidgetComponentWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
