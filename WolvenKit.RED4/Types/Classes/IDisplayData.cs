
namespace WolvenKit.RED4.Types
{
	public partial class IDisplayData : IScriptable
	{
		public IDisplayData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
