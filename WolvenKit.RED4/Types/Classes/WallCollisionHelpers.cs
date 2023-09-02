
namespace WolvenKit.RED4.Types
{
	public abstract partial class WallCollisionHelpers : IScriptable
	{
		public WallCollisionHelpers()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
