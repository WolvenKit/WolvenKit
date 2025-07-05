
namespace WolvenKit.RED4.Types
{
	public abstract partial class entIDestinationBinding : entIBinding
	{
		public entIDestinationBinding()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
