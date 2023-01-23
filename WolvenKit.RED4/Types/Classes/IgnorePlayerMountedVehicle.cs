
namespace WolvenKit.RED4.Types
{
	public partial class IgnorePlayerMountedVehicle : gameEffectObjectSingleFilter_Scripted
	{
		public IgnorePlayerMountedVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
