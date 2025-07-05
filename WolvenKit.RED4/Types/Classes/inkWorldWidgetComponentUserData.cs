
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkWorldWidgetComponentUserData : inkUserData
	{
		public inkWorldWidgetComponentUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
