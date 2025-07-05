
namespace WolvenKit.RED4.Types
{
	public abstract partial class entFactory : ISerializable
	{
		public entFactory()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
