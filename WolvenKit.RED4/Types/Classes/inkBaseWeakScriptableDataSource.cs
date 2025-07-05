
namespace WolvenKit.RED4.Types
{
	public partial class inkBaseWeakScriptableDataSource : inkAbstractDataSourceWrapper
	{
		public inkBaseWeakScriptableDataSource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
