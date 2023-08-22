
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemCallbackInfo : gameDelaySystemDelayStruct
	{
		public gameDelaySystemCallbackInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
