
namespace WolvenKit.RED4.Types
{
	public abstract partial class entIPositionProvider : IScriptable
	{
		public entIPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
