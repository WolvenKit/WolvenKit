
namespace WolvenKit.RED4.Types
{
	public abstract partial class entITransformBinding : entISourceBinding
	{
		public entITransformBinding()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
