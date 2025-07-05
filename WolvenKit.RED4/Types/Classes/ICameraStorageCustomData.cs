
namespace WolvenKit.RED4.Types
{
	public abstract partial class ICameraStorageCustomData : RedBaseClass
	{
		public ICameraStorageCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
