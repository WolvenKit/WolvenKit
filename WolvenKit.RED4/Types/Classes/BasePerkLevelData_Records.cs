
namespace WolvenKit.RED4.Types
{
	public abstract partial class BasePerkLevelData_Records : IScriptable
	{
		public BasePerkLevelData_Records()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
