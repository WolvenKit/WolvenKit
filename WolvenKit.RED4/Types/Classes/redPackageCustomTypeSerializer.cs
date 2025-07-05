
namespace WolvenKit.RED4.Types
{
	public abstract partial class redPackageCustomTypeSerializer : RedBaseClass
	{
		public redPackageCustomTypeSerializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
