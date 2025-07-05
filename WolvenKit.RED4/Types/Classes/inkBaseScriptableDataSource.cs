
namespace WolvenKit.RED4.Types
{
	public partial class inkBaseScriptableDataSource : inkAbstractDataSourceWrapper
	{
		public inkBaseScriptableDataSource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
