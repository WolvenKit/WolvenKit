
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemEventStruct : gameDelaySystemDelayStruct
	{
		public gameDelaySystemEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
