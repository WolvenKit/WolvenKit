
namespace WolvenKit.RED4.Types
{
	public abstract partial class entIOrientationProvider : IScriptable
	{
		public entIOrientationProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
