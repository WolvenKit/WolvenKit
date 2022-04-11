
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class CVariableStoragePtr : RedBaseClass
	{
		public CVariableStoragePtr()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
