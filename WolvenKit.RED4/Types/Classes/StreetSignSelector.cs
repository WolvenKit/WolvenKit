
namespace WolvenKit.RED4.Types
{
	public abstract partial class StreetSignSelector : inkTweakDBIDSelector
	{
		public StreetSignSelector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
