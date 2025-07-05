
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameaudioIWeaponAudioComponentSubSystem : gameaudioIAudioSubSystem
	{
		public gameaudioIWeaponAudioComponentSubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
