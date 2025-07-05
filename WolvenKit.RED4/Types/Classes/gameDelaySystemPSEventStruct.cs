
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemPSEventStruct : gameDelaySystemDelayStruct
	{
		public gameDelaySystemPSEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
