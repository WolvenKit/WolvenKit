
namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_SweepOverTime_Box : gameEffectObjectProvider_SweepOverTime
	{
		public gameEffectObjectProvider_SweepOverTime_Box()
		{
			QueryPreset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
