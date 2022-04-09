
namespace WolvenKit.RED4.Types
{
	public partial class entFactory : ISerializable
	{
		public entFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
