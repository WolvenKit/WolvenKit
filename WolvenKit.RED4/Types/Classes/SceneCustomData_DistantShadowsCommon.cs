
namespace WolvenKit.RED4.Types
{
	public abstract partial class SceneCustomData_DistantShadowsCommon : ISceneStorageCustomData
	{
		public SceneCustomData_DistantShadowsCommon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
