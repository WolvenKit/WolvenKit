
namespace WolvenKit.RED4.Types
{
	public abstract partial class ItemPreviewHelper : IScriptable
	{
		public ItemPreviewHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
