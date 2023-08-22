
namespace WolvenKit.RED4.Types
{
	public abstract partial class entEntityParameter : ISerializable
	{
		public entEntityParameter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
