
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameItemData : IScriptable
	{
		public gameItemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
