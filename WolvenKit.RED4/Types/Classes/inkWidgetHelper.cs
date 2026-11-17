
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkWidgetHelper : IScriptable
	{
		public inkWidgetHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
