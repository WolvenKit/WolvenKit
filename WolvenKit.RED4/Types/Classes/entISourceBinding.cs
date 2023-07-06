
namespace WolvenKit.RED4.Types
{
	public abstract partial class entISourceBinding : entIBinding
	{
		public entISourceBinding()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
